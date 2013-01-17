/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2012/7/17
 * Time: 17:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Xml;

namespace UmengChannel
{
    /// <summary>
    /// All the build work is here
    /// </summary>
    public class Worker
    {
        static ProjectConfigration project;
        static System.ComponentModel.BackgroundWorker workReporter;
        //public StoredList
        private static Worker worker;
        static Worker()
        {
            worker = new Worker();
        }
        public Worker()
        {

        }

        public static void setProject(ProjectConfigration p, System.ComponentModel.BackgroundWorker bw)
        {
            project = p;
            workReporter = bw;
        }

        public static void start()
        {
            worker.run();

        }
        private void run()
        {

            if (project.isApkProject)
            {
                doWorkFromApk();
            }
            else
            {
                try
                {
                    backup();
                    doWorkFromSource();
                }
                catch (XException xex)
                {
                    throw xex;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    restore();
                }
            }

        }


        private string[] srcs = { "AndroidManifest.xml", "ant.properties", "build.xml", "project.properties" };
        private string apktoolPath = "tools\\apktool\\";
        private string antPath = "tools\\ant\\bin\\";

        /// <summary>
        /// AndroidManifest.xml , ant.properties, build.xml,project.properties should backup
        /// </summary>
        private void backup()
        {
            string src_file = null;
            string dst_file = null;
            foreach (string src in srcs)
            {
                if (!File.Exists(Path.Combine(project.project_path, src)))
                    continue;
                src_file = Path.Combine(project.project_path, src);
                dst_file = src_file + "~";

                if (File.Exists(dst_file)) File.Delete(dst_file);

                File.Copy(src_file, src_file + "~");

                if (src.Equals(srcs[1]))
                {
                    File.Delete(src_file);
                }
            }

        }
        /// <summary>
        /// if original file exits , so has backup file , or delete the original file
        /// </summary>
        private void restore()
        {
            string dst_file = null;
            string src_file = null;
            foreach (string src in srcs)
            {
                dst_file = Path.Combine(project.project_path, src + "~");
                src_file = Path.Combine(project.project_path, src);

                //restore backup file
                if (File.Exists(dst_file) && File.Exists(src_file))
                {
                    File.Replace(dst_file, src_file, null);

                }//restore deleted file
                else if (File.Exists(dst_file) && !File.Exists(src_file))
                {
                    File.Move(dst_file, src_file);
                }//delete App generated file
                else if (!File.Exists(dst_file) && File.Exists(src_file))
                {
                    File.Delete(src_file);
                }

            }
        }
        #region 打包APK包
        //apktool d --no-src  -f DkReader_1.7.0.1671.apk dk
        private void doWorkFromApk()
        {
            Log.i("//===============================");
            Log.i("开始打包APK文件");
            int total = project.channels.Count * 3 + 1;
            int progress = 0;

            publishProgress(progress++, total);
            decodeApk();//反编译APK文件

            foreach (string channle in project.channels)
            {
                clean();
                publishProgress(progress++, total);
                replaceChannle(channle);//修改配置文件
                publishProgress(progress++, total);
                rebuildApk();//重新编译APK

                publishProgress(progress++, total);
                signAPK();
                zipAlign();
                copyToWorkspace(channle);
            }
        }

        /// <summary>
        /// 删除APK打包过程中使用的临时存放目录
        /// </summary>
        private void clean()
        {
            if (Directory.Exists(project.ApkTempFolder))
            {
                Directory.Delete(project.ApkTempFolder, true);
            }
        }
        /// <summary>
        /// 反编译APK文件，要求APK工具放在可执行文件所在目录的 tools\apktool目录下
        /// </summary>
        private void decodeApk()
        {
            if (!File.Exists(project.project_path))
            {
                throw new XException("Target apk is missing..");
            }

            List<String> cmd = new List<string>();

            cmd.Add(apktoolPath + "apktool");
            cmd.Add("d");
            cmd.Add("--no-src");//不需要反编译源代码
            cmd.Add("-f");//覆盖原来的目录
            cmd.Add(string.Format("\"{0}\"", project.project_path));
            cmd.Add(string.Format("\"{0}\"", project.ApkDecodeFolder));

            Sys.Run(ToCommand(cmd));
        }

        private void rebuildApk()
        {

            if (!Directory.Exists(project.ApkTempFolder))
            {
                Directory.CreateDirectory(project.ApkTempFolder);
            }

            List<String> cmd = new List<string>();
            cmd.Add(apktoolPath + "apktool");
            cmd.Add("b");
            cmd.Add(string.Format("\"{0}\"", project.ApkDecodeFolder));
            cmd.Add(string.Format("\"{0}\"", project.UnsignedApkFile));

            Sys.Run(ToCommand(cmd));
        }
        #endregion

        #region 打包源代码

        private void doWorkFromSource()
        {
            //start work//total = channel.length*2 + 3
            Log.i("//===============================");
            Log.i("开始打包源代码");

            int total = project.channels.Count * 3 + 3;
            int progress = 0;

            publishProgress(progress++, total);
            setProjectEnvironmet();
            publishProgress(progress++, total);
            if (project.setProguard)
            {
                setProguard();
            }
            else
            {
                cancleProguard();
            }
            publishProgress(progress++, total);


            List<string> channels = project.channels;

            foreach (string channel in channels)
            {
                Log.i("开始打包渠道:" + channel);
                try
                {
                    publishProgress(progress++, total);
                    replaceChannle(channel);

                    publishProgress(progress++, total);

                    buildUnsignedApk();
                    //检查是否顺利编译成apk文件
                    if (!File.Exists(project.UnzipalignApkFile))
                    {
                        Log.e("编译源代码打包失败，请先尝试编译打包或者关闭所有打开的项目再重试!");
                        return;
                    }
                    signAPK();
                    zipAlign();

                    publishProgress(progress++, total);
                    copyToWorkspace(channel);

                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
        #endregion

        private void publishProgress(int progress, int total)
        {
            workReporter.ReportProgress(progress * 100 / total);
        }

        private void signAPK()
        {

            List<String> cmd = new List<string>();

            cmd.Add("jarsigner");
            cmd.Add("-keystore");
            cmd.Add(string.Format("\"{0}\"", project.keystore_file_path));
            cmd.Add("-storepass");
            cmd.Add(project.keystore_pw);
            cmd.Add("-keypass");
            cmd.Add(project.key_pw);
            cmd.Add("-signedjar");
            cmd.Add(string.Format("\"{0}\"", project.UnzipalignApkFile));
            cmd.Add(string.Format("\"{0}\"", project.UnsignedApkFile));
            cmd.Add(project.alias);
            cmd.Add("-digestalg");
            cmd.Add("SHA1");
            cmd.Add("-sigalg");
            cmd.Add("MD5withRSA");

            Sys.Run(ToCommand(cmd));
        }

        private void zipAlign()
        {

            if (!File.Exists(project.UnzipalignApkFile))
            {
                throw new Exception(string.Format("signer apk error .. can't find {0} file for zip align", project.UnzipalignApkFile));
            }

            List<String> cmd = new List<string>();

            cmd.Add("zipalign");
            cmd.Add("-v");
            cmd.Add("4");
            cmd.Add(string.Format("\"{0}\"", project.UnzipalignApkFile));
            cmd.Add(string.Format("\"{0}\"", project.finalApkFile));

            Sys.Run(ToCommand(cmd));
        }

        private void setProjectEnvironmet()
        {
            Log.i("Update android project environment");

            string build_file = Path.Combine(project.project_path, "Build.xml");
            string project_property_file = Path.Combine(project.project_path, "project.properties");


            if (!File.Exists(build_file) && !File.Exists(project_property_file))
            {
                Sys.Run(string.Format("android update project -p \"{0}\" -t android-4", project.project_path));

            }
            else if (!File.Exists(build_file) && File.Exists(project_property_file))
            {
                Sys.Run(string.Format("android update project -p \"{0}\"", project.project_path));
            }

            Log.i("...");
        }

        private void replaceChannle(string channel)
        {
            Log.i(string.Format("开始修改AndroidManifest.xml文件中的渠道名称为：{0} ", channel));

            string androidmanifest_file = project.AndroidManifestFile;

            if (!File.Exists(androidmanifest_file))
            {
                throw new Exception(string.Format("在路径【{0}】中没有找到 AndroidManifest.xml文件", androidmanifest_file));
            }

            XmlDocument doc = new XmlDocument();
            doc.Load(androidmanifest_file);

            //update 
            XmlNodeList mata_datas = doc.GetElementsByTagName("meta-data");
            bool hasSet = false;
            foreach (XmlElement mata_data in mata_datas)
            {
                if (mata_data.GetAttribute("android:name").Equals("UMENG_CHANNEL"))
                {
                    mata_data.SetAttribute("android:value", channel);
                    hasSet = true;
                    break;
                }
            }

            // if no set ,add it 如果原来的配置文件中没有设置，则添加节点设置
            if (!hasSet)
            {
                Log.i(string.Format("原先未配置UMENG_CHANNEL：正在添加AndroidManifest.xml文件中的渠道[{0}]设置", channel));
                XmlElement application = doc.GetElementsByTagName("application")[0] as XmlElement;

                XmlElement channel_mata = doc.CreateElement("meta-data");
                channel_mata.SetAttribute("android:name", "UMENG_CHANNEL");
                channel_mata.SetAttribute("android:value", channel);

                application.AppendChild(channel_mata);
            }

            doc.Save(androidmanifest_file);

            Log.i("渠道名称修改完成...");
        }

        /// <summary>
        /// 编译生成未签名的APK文件
        /// </summary>
        private void buildUnsignedApk()
        {
            Log.i("编译生成未签名的APK文件 ...");
            Sys.Run(string.Format("{0}ant clean -f \"{1}\"", antPath, Path.Combine(project.project_path, "build.xml")));
            Sys.Run(string.Format("{0}ant release -f \"{1}\"", antPath, Path.Combine(project.project_path, "build.xml")));
        }

        /// <summary>
        /// 开始加入代码混淆支持
        /// </summary>
        private void setProguard()
        {
            Log.i("开始加入代码混淆支持...");

            string projectproperties_file = System.IO.Path.Combine(project.project_path, "project.properties");

            if (!File.Exists(projectproperties_file))
            {
                Log.i("找不到 project.properties 文件，该文件是指定ProGuard配置文件的位置");
                return;
            }
            bool hasSetProguard = false;
            string line = null;
            using (StreamReader sr = File.OpenText(projectproperties_file))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.StartsWith("#"))
                    {
                        continue;
                    }
                    else if (line.Contains("proguard.config"))
                    {//proguard.config=proguard.cfg
                        string proguard_config_file = line.Substring(line.IndexOf("=") + 1);

                        hasSetProguard = true;
                        break;
                    }
                }
            }

            if (!hasSetProguard)
            {
                if (File.Exists(Path.Combine(project.project_path, "proguard.cfg")))
                    using (StreamWriter sw = File.AppendText(projectproperties_file))
                    {
                        sw.WriteLine("proguard.config=proguard.cfg");
                    }
                else if (File.Exists(Path.Combine(project.project_path, "proguard-project.txt")))
                    using (StreamWriter sw = File.AppendText(projectproperties_file))
                    {
                        sw.WriteLine("proguard.config=proguard-project.txt");
                    }
            }
        }

        private void cancleProguard()
        {
            string projectproperties_file = System.IO.Path.Combine(project.project_path, "project.properties");

            if (!File.Exists(projectproperties_file))
            {
                Log.i("Can't find project.properties file");
                return;
            }

            StringBuilder sb = new StringBuilder();
            string line = null;
            using (StreamReader sr = File.OpenText(projectproperties_file))
            {
                while ((line = sr.ReadLine()) != null)
                {

                    if (line.Contains("proguard.config"))
                    {//proguard.config=proguard.cfg
                        continue;
                    }
                    else
                    {
                        sb.Append(line);
                        sb.Append("\n");
                    }
                }//while
            }//using

            File.Delete(projectproperties_file);
            File.AppendAllText(projectproperties_file, sb.ToString());
        }

        private void setSignApk()
        {
            Log.i("Signing apk ...");

            string ant_properties_file = System.IO.Path.Combine(project.project_path, "ant.properties");

            using (StreamWriter sw = File.CreateText(ant_properties_file))
            {
                sw.WriteLine(string.Format("key.store={0}", project.keystore_file_path.Replace('\\', '/')));
                sw.WriteLine(string.Format("key.alias={0}", project.alias));
                sw.WriteLine(string.Format("key.store.password={0}", project.keystore_pw));
                sw.WriteLine(string.Format("key.alias.password={0}", project.key_pw));
                sw.WriteLine(string.Format("key.alias.password={0}", project.key_pw));
            }
        }

        private void copyToWorkspace(string channel)
        {

            string apk_file = project.finalApkFile;

            if (apk_file == null || !File.Exists(apk_file))
            {
                throw new XException("Fail to generate .apk for " + channel);
            }

            string dst_file = generateDstFile(channel);
            if (File.Exists(dst_file)) File.Delete(dst_file);

            File.Copy(apk_file, dst_file);
        }

        private string generateDstFile(string channel)
        {

            string project_name = project.ProjectName;
            string file_name = string.Format("{0}_{1}.apk", project.isApkProject ? project_name.Replace(".apk", "") : project_name, channel);

            string dst_path = Path.Combine(System.Environment.CurrentDirectory,
                Path.Combine("output", project_name));

            if (!Directory.Exists(dst_path))
            {
                Directory.CreateDirectory(dst_path);
            }

            return Path.Combine(dst_path, file_name);
        }

        private string ToCommand(List<string> cmd)
        {

            StringBuilder msb = new StringBuilder();

            foreach (string p in cmd)
            {
                msb.Append(p);
                msb.Append(" ");
            }
            Log.i(string.Format("执行命令：{0}", msb.ToString()));
            return msb.ToString();
        }
    }

    /// <summary>
    /// utils facade !
    /// </summary>
    public class Sys
    {

        public static void Run(string cmd)
        {
            new SyncCmd().run(cmd);
        }

    }

    public class SyncCmd
    {
        Process p = new Process();

        public SyncCmd()
        {
            p.OutputDataReceived += new DataReceivedEventHandler(p_OutputDataReceived);
            p.ErrorDataReceived += new DataReceivedEventHandler(p_ErrorDataReceived);

            p.StartInfo.WorkingDirectory = System.Environment.CurrentDirectory;
            //设定程序名

            p.StartInfo.FileName = "cmd.exe";

            //关闭Shell的使用

            p.StartInfo.UseShellExecute = false;

            //重定向标准输入

            p.StartInfo.RedirectStandardInput = true;

            //重定向标准输出

            p.StartInfo.RedirectStandardOutput = true;

            //重定向错误输出

            p.StartInfo.RedirectStandardError = true;

            //设置不显示窗口

            p.StartInfo.CreateNoWindow = true;

            //上面几个属性的设置是比较关键的一步。

            //既然都设置好了那就启动进程吧，

        }

        public void run(string cmd)
        {
            p.Start();
            p.BeginOutputReadLine();
            p.BeginErrorReadLine();
            p.StandardInput.WriteLine(cmd);
            p.StandardInput.WriteLine("exit");
            p.WaitForExit();
        }

        void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            Log.i(e.Data);
        }

        void p_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            Log.e(e.Data);
        }
    }

    public class XException : Exception
    {
        public XException(string message)
            : base(message)
        {
        }

    }
}
