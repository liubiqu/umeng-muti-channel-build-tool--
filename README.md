#友盟渠道打包工具(windows .net framework 2.0)

##1. 更新内容
    1.删除统计分析的工具，并调整部分linq代码
    2.增加渠道名称批量生成
    3.只需要.net framework2.0即运行,去掉统计相关的组件
    4.更新所有工具包ant apktool 
    5.界面布局调整，支持全屏操作
    6.修改部分提示信息，更明确定位问题所在。
    7.增加对工具相对目录的处理，不需要再设置环境变量
    8.修改工具项目配置，生成时可以自动复制相关的工具目录，不需要手动处理

注意运行环境检查：
1、检查java的环境变量是否设置成功。

检查方法：直接打开cmd  输入 java -version 回车，会出现jre的版本信息，表示环境设置成功，建议使用1.6版本。

--
友盟渠道打包工具开放源码使用 GPL2 许可分发，不能用于除了为个人或团队打包自有App之外的任何商业用途。

##2. 编译运行

   使用VS2010直接打开运行即可。编译成功后会自动把`adds_on` 里面的文件和文件夹拷贝到功能目录的 `bin\debug\` 和 `bin\release\` 目录下。
   
   adds_on 文件内容为：（更新为当前最新版本2013-01-16）
   
   1. ant 文件夹包含 ant 源码打包的相关工具
   2. apktool 文件夹包含 apk 打包的相关工具
   3. ClassLibrary1.dll 一个简单的基于.net 3.5 的统计分析SDK （已移除）

##3. 界面操作

鼠标停留在各个按钮上可以显示相关的提示信息
 

##4. 工程管理
左边栏工程列面，对应右侧显示当前工程的配置信息，包括工程配置和一般配置
系统配置属于系统级别的配置，所有工程共享

右边栏渠道管理，输入渠道后显示在渠道列面里面，点击删除渠道会删除当前选中的渠道（单选），打开文件夹会打开打包后的apk文件。

##5. 打包流程(from source)

1. 设置当前process 的环境变量，保证 ant ，java ， android tools 可以直接运行需要设置 ANT_HOME, JAVA_HOME, PATH = …
2. 备份 工程目录下的 AndroidManifest.xml , ant.properties, build.xml,project.properties四个文件, 如果文件不存在则不备份。
3. 删除 ant.properties  禁止 build 文件自动对apk 进行签名。不用自动签名是因为，在jdk 1.7 中自动签名会失败，所以采用主动签名的方式。
4. 替换或者添加 AndroidManifest.xml 中的 友盟 channel
5. 执行 android update project  –p XXXX  –t  XXXX 更新工程目录
6. 执行 ant clean –f XXXX\build.xml清空 bin , obj 目录
7. 执行 ant release –f XXXX\build.xml 打包生成未签名的 apk
8. 执行 jarsigner 生成签名后的 apk 文件
9. 执行 zipAlign 生成对齐优化后的 apk 文件
10. 回到 4 替换新的渠道。
11. Restore 备份文件
12. 完成打包

##6. 打包流程(from apk)

1. 设置当前process 的环境变量，保证 apktool 可以正常工作
2. 执行 apktool d --no-src -f xxxx.apk temp 拆解apk
3. 替换或者添加 AndroidManifest.xml 中的 友盟 channel
4. 执行 apktool b temp  unsigned.apk 重新打包apk
5. 执行 jarsigner 生成签名后的 apk 文件
6. 执行 zipAlign 生成对齐优化后的 apk 文件
7. 回到 3 替换新的渠道
8. 完成打包
