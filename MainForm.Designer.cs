﻿/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2012/7/17
 * Time: 13:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UmengChannel
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.projects = new System.Windows.Forms.ListBox();
            this.tb_project = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.keystore_file_path = new System.Windows.Forms.Label();
            this.tb_alias = new System.Windows.Forms.TextBox();
            this.keystore_pw = new System.Windows.Forms.Label();
            this.tb_keystore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_keystore_pw = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnChannelDelete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.channels = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtChannel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.key_pw = new System.Windows.Forms.Label();
            this.tb_key_pw = new System.Windows.Forms.TextBox();
            this.btnOpenProject = new System.Windows.Forms.Button();
            this.bt_keystore_path = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.javahome = new System.Windows.Forms.Label();
            this.tb_java_path = new System.Windows.Forms.TextBox();
            this.bt_java_path = new System.Windows.Forms.Button();
            this.bt_delete_project = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_android_sdk_path = new System.Windows.Forms.Button();
            this.label_hint = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSelectAPK = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnChannelAdd = new System.Windows.Forms.Button();
            this.tb_android_sdk_path = new System.Windows.Forms.TextBox();
            this.nudChannelNum = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudChannelNum)).BeginInit();
            this.SuspendLayout();
            // 
            // projects
            // 
            this.projects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.projects.FormattingEnabled = true;
            this.projects.ItemHeight = 17;
            this.projects.Location = new System.Drawing.Point(6, 58);
            this.projects.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.projects.Name = "projects";
            this.projects.Size = new System.Drawing.Size(160, 514);
            this.projects.TabIndex = 0;
            this.projects.SelectedIndexChanged += new System.EventHandler(this.ProjectsSelectedIndexChanged);
            // 
            // tb_project
            // 
            this.tb_project.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_project.Location = new System.Drawing.Point(316, 36);
            this.tb_project.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_project.Name = "tb_project";
            this.tb_project.ReadOnly = true;
            this.tb_project.Size = new System.Drawing.Size(184, 23);
            this.tb_project.TabIndex = 0;
            this.toolTip1.SetToolTip(this.tb_project, "源代码目录或APK文件");
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(226, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "工程目录";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // keystore_file_path
            // 
            this.keystore_file_path.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.keystore_file_path.Location = new System.Drawing.Point(226, 136);
            this.keystore_file_path.Name = "keystore_file_path";
            this.keystore_file_path.Size = new System.Drawing.Size(86, 33);
            this.keystore_file_path.TabIndex = 3;
            this.keystore_file_path.Text = "alias";
            this.keystore_file_path.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb_alias
            // 
            this.tb_alias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_alias.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_alias.Location = new System.Drawing.Point(316, 133);
            this.tb_alias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_alias.Name = "tb_alias";
            this.tb_alias.Size = new System.Drawing.Size(259, 23);
            this.tb_alias.TabIndex = 3;
            // 
            // keystore_pw
            // 
            this.keystore_pw.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.keystore_pw.Location = new System.Drawing.Point(227, 183);
            this.keystore_pw.Name = "keystore_pw";
            this.keystore_pw.Size = new System.Drawing.Size(85, 33);
            this.keystore_pw.TabIndex = 5;
            this.keystore_pw.Text = "keystore";
            this.keystore_pw.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb_keystore
            // 
            this.tb_keystore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_keystore.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_keystore.Location = new System.Drawing.Point(316, 180);
            this.tb_keystore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_keystore.Name = "tb_keystore";
            this.tb_keystore.ReadOnly = true;
            this.tb_keystore.Size = new System.Drawing.Size(210, 23);
            this.tb_keystore.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(218, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "keystore_pw";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label4.Click += new System.EventHandler(this.Label4Click);
            // 
            // tb_keystore_pw
            // 
            this.tb_keystore_pw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_keystore_pw.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_keystore_pw.Location = new System.Drawing.Point(316, 227);
            this.tb_keystore_pw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_keystore_pw.Name = "tb_keystore_pw";
            this.tb_keystore_pw.Size = new System.Drawing.Size(259, 23);
            this.tb_keystore_pw.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(184, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "工程配置";
            // 
            // btnChannelDelete
            // 
            this.btnChannelDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChannelDelete.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChannelDelete.Location = new System.Drawing.Point(724, 114);
            this.btnChannelDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChannelDelete.Name = "btnChannelDelete";
            this.btnChannelDelete.Size = new System.Drawing.Size(87, 33);
            this.btnChannelDelete.TabIndex = 18;
            this.btnChannelDelete.Text = "删除渠道";
            this.toolTip1.SetToolTip(this.btnChannelDelete, "删除当前选中的渠道名");
            this.btnChannelDelete.UseVisualStyleBackColor = true;
            this.btnChannelDelete.Click += new System.EventHandler(this.btnChannelDelete_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(606, 563);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 33);
            this.button2.TabIndex = 17;
            this.button2.Text = "查看生成的APK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2Click);
            // 
            // channels
            // 
            this.channels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.channels.FormattingEnabled = true;
            this.channels.ItemHeight = 17;
            this.channels.Location = new System.Drawing.Point(597, 151);
            this.channels.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.channels.Name = "channels";
            this.channels.Size = new System.Drawing.Size(214, 378);
            this.channels.TabIndex = 12;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Location = new System.Drawing.Point(209, 445);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(370, 84);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "开始打包";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtChannel
            // 
            this.txtChannel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChannel.Location = new System.Drawing.Point(597, 36);
            this.txtChannel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtChannel.Name = "txtChannel";
            this.txtChannel.Size = new System.Drawing.Size(196, 23);
            this.txtChannel.TabIndex = 14;
            this.txtChannel.TabStop = false;
            this.toolTip1.SetToolTip(this.txtChannel, "频道名称不能为空，且不超过128个字符；需要以字符开头，不允许以数字开头");
            this.txtChannel.Enter += new System.EventHandler(this.Tb_input_channel_areaEnter);
            this.txtChannel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox5KeyDown);
            this.txtChannel.Leave += new System.EventHandler(this.Tb_input_channel_areaLeave);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(3, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "工程名称";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(187, 573);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(392, 14);
            this.progressBar1.TabIndex = 16;
            this.progressBar1.Visible = false;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(184, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 27);
            this.label7.TabIndex = 17;
            this.label7.Text = "密钥配置";
            // 
            // key_pw
            // 
            this.key_pw.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.key_pw.Location = new System.Drawing.Point(231, 271);
            this.key_pw.Name = "key_pw";
            this.key_pw.Size = new System.Drawing.Size(82, 33);
            this.key_pw.TabIndex = 18;
            this.key_pw.Text = "key_pw";
            this.key_pw.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb_key_pw
            // 
            this.tb_key_pw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_key_pw.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_key_pw.Location = new System.Drawing.Point(316, 271);
            this.tb_key_pw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_key_pw.Name = "tb_key_pw";
            this.tb_key_pw.Size = new System.Drawing.Size(259, 23);
            this.tb_key_pw.TabIndex = 7;
            // 
            // btnOpenProject
            // 
            this.btnOpenProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenProject.Location = new System.Drawing.Point(506, 36);
            this.btnOpenProject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenProject.Name = "btnOpenProject";
            this.btnOpenProject.Size = new System.Drawing.Size(41, 33);
            this.btnOpenProject.TabIndex = 1;
            this.btnOpenProject.Text = "....";
            this.toolTip1.SetToolTip(this.btnOpenProject, "选择源代码目录进行批量打包");
            this.btnOpenProject.UseVisualStyleBackColor = true;
            this.btnOpenProject.Click += new System.EventHandler(this.btnOpenProject_Click);
            // 
            // bt_keystore_path
            // 
            this.bt_keystore_path.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_keystore_path.Location = new System.Drawing.Point(535, 177);
            this.bt_keystore_path.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_keystore_path.Name = "bt_keystore_path";
            this.bt_keystore_path.Size = new System.Drawing.Size(41, 33);
            this.bt_keystore_path.TabIndex = 5;
            this.bt_keystore_path.Text = "....";
            this.bt_keystore_path.UseVisualStyleBackColor = true;
            this.bt_keystore_path.Click += new System.EventHandler(this.Bt_keystore_pathClick);
            // 
            // checkBox1
            // 
            this.checkBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox1.Location = new System.Drawing.Point(316, 67);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 34);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "混淆";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(184, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "系统配置";
            // 
            // javahome
            // 
            this.javahome.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.javahome.Location = new System.Drawing.Point(238, 368);
            this.javahome.Name = "javahome";
            this.javahome.Size = new System.Drawing.Size(75, 24);
            this.javahome.TabIndex = 24;
            this.javahome.Text = "Java 路径";
            this.javahome.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb_java_path
            // 
            this.tb_java_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_java_path.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_java_path.Location = new System.Drawing.Point(316, 369);
            this.tb_java_path.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_java_path.Name = "tb_java_path";
            this.tb_java_path.ReadOnly = true;
            this.tb_java_path.Size = new System.Drawing.Size(210, 23);
            this.tb_java_path.TabIndex = 8;
            this.tb_java_path.Text = global::UmengChannel.Properties.Settings.Default.txtJDK_Path;
            this.toolTip1.SetToolTip(this.tb_java_path, "例如：C:\\Program Files\\Java\\jdk1.6.0_22");
            // 
            // bt_java_path
            // 
            this.bt_java_path.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_java_path.Location = new System.Drawing.Point(535, 364);
            this.bt_java_path.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_java_path.Name = "bt_java_path";
            this.bt_java_path.Size = new System.Drawing.Size(41, 33);
            this.bt_java_path.TabIndex = 9;
            this.bt_java_path.Text = "...";
            this.toolTip1.SetToolTip(this.bt_java_path, "JDK路径。例如：C:\\Program Files\\Java\\jdk1.6.0_22");
            this.bt_java_path.UseVisualStyleBackColor = true;
            this.bt_java_path.Click += new System.EventHandler(this.Bt_java_pathClick);
            // 
            // bt_delete_project
            // 
            this.bt_delete_project.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_delete_project.Location = new System.Drawing.Point(79, 17);
            this.bt_delete_project.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_delete_project.Name = "bt_delete_project";
            this.bt_delete_project.Size = new System.Drawing.Size(87, 35);
            this.bt_delete_project.TabIndex = 27;
            this.bt_delete_project.Text = "删除工程";
            this.bt_delete_project.UseVisualStyleBackColor = true;
            this.bt_delete_project.Click += new System.EventHandler(this.Bt_delete_projectClick);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(179, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Android SDK 路径";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bt_android_sdk_path
            // 
            this.bt_android_sdk_path.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_android_sdk_path.Location = new System.Drawing.Point(535, 404);
            this.bt_android_sdk_path.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_android_sdk_path.Name = "bt_android_sdk_path";
            this.bt_android_sdk_path.Size = new System.Drawing.Size(41, 33);
            this.bt_android_sdk_path.TabIndex = 11;
            this.bt_android_sdk_path.Text = "...";
            this.toolTip1.SetToolTip(this.bt_android_sdk_path, "只有源代码编译时需要设置。例如：D:\\Android-sdk-windows");
            this.bt_android_sdk_path.UseVisualStyleBackColor = true;
            this.bt_android_sdk_path.Click += new System.EventHandler(this.Bt_android_sdk_pathClick);
            // 
            // label_hint
            // 
            this.label_hint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_hint.BackColor = System.Drawing.Color.Transparent;
            this.label_hint.Enabled = false;
            this.label_hint.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_hint.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_hint.Location = new System.Drawing.Point(603, 41);
            this.label_hint.Name = "label_hint";
            this.label_hint.Size = new System.Drawing.Size(179, 15);
            this.label_hint.TabIndex = 16;
            this.label_hint.Text = "输入渠道名称，然后回车";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(597, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 21);
            this.label8.TabIndex = 32;
            this.label8.Text = "渠道列表";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(597, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 21);
            this.label9.TabIndex = 14;
            this.label9.Text = "添加渠道";
            // 
            // btnSelectAPK
            // 
            this.btnSelectAPK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectAPK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectAPK.BackgroundImage")));
            this.btnSelectAPK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelectAPK.Location = new System.Drawing.Point(546, 36);
            this.btnSelectAPK.Name = "btnSelectAPK";
            this.btnSelectAPK.Size = new System.Drawing.Size(38, 33);
            this.btnSelectAPK.TabIndex = 33;
            this.toolTip1.SetToolTip(this.btnSelectAPK, "选择打包好的APK文件进行批量修改渠道操作");
            this.btnSelectAPK.UseVisualStyleBackColor = true;
            this.btnSelectAPK.Click += new System.EventHandler(this.btnSelectAPK_Click);
            // 
            // btnChannelAdd
            // 
            this.btnChannelAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChannelAdd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChannelAdd.Location = new System.Drawing.Point(707, 60);
            this.btnChannelAdd.Name = "btnChannelAdd";
            this.btnChannelAdd.Size = new System.Drawing.Size(104, 34);
            this.btnChannelAdd.TabIndex = 34;
            this.btnChannelAdd.Text = "批量添加渠道";
            this.toolTip1.SetToolTip(this.btnChannelAdd, "将在渠道名后面加上从0开始的数字生成新的渠道名");
            this.btnChannelAdd.UseVisualStyleBackColor = true;
            this.btnChannelAdd.Click += new System.EventHandler(this.btnChannelAdd_Click);
            // 
            // tb_android_sdk_path
            // 
            this.tb_android_sdk_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_android_sdk_path.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_android_sdk_path.Location = new System.Drawing.Point(316, 409);
            this.tb_android_sdk_path.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_android_sdk_path.Name = "tb_android_sdk_path";
            this.tb_android_sdk_path.ReadOnly = true;
            this.tb_android_sdk_path.Size = new System.Drawing.Size(210, 23);
            this.tb_android_sdk_path.TabIndex = 10;
            this.tb_android_sdk_path.Text = global::UmengChannel.Properties.Settings.Default.txtAndroid_SDK_Path;
            this.toolTip1.SetToolTip(this.tb_android_sdk_path, "例如：D:\\Android-sdk-windows");
            // 
            // nudChannelNum
            // 
            this.nudChannelNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudChannelNum.Location = new System.Drawing.Point(636, 67);
            this.nudChannelNum.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudChannelNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudChannelNum.Name = "nudChannelNum";
            this.nudChannelNum.Size = new System.Drawing.Size(61, 23);
            this.nudChannelNum.TabIndex = 35;
            this.nudChannelNum.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(598, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 17);
            this.label10.TabIndex = 36;
            this.label10.Text = "数量";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 613);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nudChannelNum);
            this.Controls.Add(this.btnChannelAdd);
            this.Controls.Add(this.btnSelectAPK);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label_hint);
            this.Controls.Add(this.txtChannel);
            this.Controls.Add(this.bt_android_sdk_path);
            this.Controls.Add(this.tb_android_sdk_path);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_delete_project);
            this.Controls.Add(this.bt_java_path);
            this.Controls.Add(this.tb_java_path);
            this.Controls.Add(this.javahome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.bt_keystore_path);
            this.Controls.Add(this.btnOpenProject);
            this.Controls.Add(this.tb_key_pw);
            this.Controls.Add(this.key_pw);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.channels);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnChannelDelete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_keystore_pw);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_keystore);
            this.Controls.Add(this.keystore_pw);
            this.Controls.Add(this.tb_alias);
            this.Controls.Add(this.keystore_file_path);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_project);
            this.Controls.Add(this.projects);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "友盟Android渠道打包工具";
            ((System.ComponentModel.ISupportInitialize)(this.nudChannelNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label_hint;
		private System.Windows.Forms.TextBox tb_android_sdk_path;
		private System.Windows.Forms.Button bt_android_sdk_path;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button bt_delete_project;
		private System.Windows.Forms.Button bt_java_path;
		private System.Windows.Forms.TextBox tb_java_path;
		private System.Windows.Forms.Label javahome;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button bt_keystore_path;
		private System.Windows.Forms.Button btnOpenProject;
		private System.Windows.Forms.TextBox tb_key_pw;
		private System.Windows.Forms.Label key_pw;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtChannel;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.ListBox channels;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btnChannelDelete;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tb_keystore_pw;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tb_keystore;
		private System.Windows.Forms.Label keystore_pw;
		private System.Windows.Forms.TextBox tb_alias;
		private System.Windows.Forms.Label keystore_file_path;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tb_project;
		private System.Windows.Forms.ListBox projects;
		
		void Label4Click(object sender, System.EventArgs e)
		{
			
		}

        private System.Windows.Forms.Button btnSelectAPK;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnChannelAdd;
        private System.Windows.Forms.NumericUpDown nudChannelNum;
        private System.Windows.Forms.Label label10;
	}
}
