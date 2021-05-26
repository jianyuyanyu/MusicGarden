# MusicGarden
MusicGarden是使用Visual Studio 2019基于WMP组件开发的兼有搜索下载功能的音乐播放器,`master` 分支是最新的所有代码，支持Windows7+。
## 依赖平台
![Visual Studio 2019](https://img.shields.io/badge/IDE-Visual%20Studio%202019-964ad4.svg?maxAge=3600)![.NET Framework 4.8](https://img.shields.io/badge/.NET-Framework%204.8-lightgrey.svg?maxAge=3600)![Windows OS](https://img.shields.io/badge/OS-Windows%207+-00adef.svg?maxAge=3600)
<br></br>

## 项目信息

| 许可证 | GitHub Releases | 仓库大小 | 最新版本号     |
| ------ | --------------- | -------- | ---- |
|![GitHub](https://img.shields.io/github/license/jianyuyanyu/MusicGarden)|  [![GitHub all releases](https://img.shields.io/github/downloads/jianyuyanyu/MusicGarden/total)](https://github.com/jianyuyanyu/MusicGarden/releases) | ![GitHub repo size](https://img.shields.io/github/repo-size/jianyuyanyu/MusicGarden?label=%E4%BB%93%E5%BA%93%E5%A4%A7%E5%B0%8F)|![GitHub release (latest by date)](https://img.shields.io/github/v/release/jianyuyanyu/MusicGarden)|

<br></br>

## 提示
* 想打开软件运行？欢迎下载最新版本。

* 下载软件后，请先全部解压出来，不要丢失文件，也不要在压缩软件中打开，因为部分压缩软件中无法正常运行程序。
* ⚠️ 如遇安装问题请下载.NET环境及工具，按说明处理。其他操作系统如打不开或者打开报错，则需安装：Microsoft. NET Framework ， 推荐安装[.NET Framework 4.8](https://dotnet.microsoft.com/download/dotnet-framework/thank-you/net48-chs) 。
* 欢迎大家对软件进行修改添加新功能，[点击这里可以pull](https://github.com/jianyuyanyu/MusicGarden/pulls)。
<br></br>

## 项目结构
[PATH](https://github.com/jianyuyanyu/MusicGarden)

```
│  AboutForm.cs                           //关于窗体类
│  AboutForm.Designer.cs
│  AboutForm.resx
│  App.config
│  Dopamine.ico                           //软件图标文件
│  DownloadForm.cs                        //HTTP帮助类
│  DownloadForm.Designer.cs
│  DownloadForm.resx
│  GaussianBlur.cs                        //高斯模糊类
│  HttpHelper.cs                          //HTTP帮助类
│  IniFile.cs                             //读写ini帮助类
│  LyricFile.cs                           //音乐歌词类
│  MusicForm.cs                           //软件主窗体类
│  MusicForm.Designer.cs
│  MusicForm.resx
│  MusicGarden.csproj                     //项目解决方案文件
│  MusicGarden.csproj.user
│  packages.config
│  Program.cs
│  SetForm.cs                             //软件设置窗体类
│  SetForm.Designer.cs
│  SetForm.resx
│  SongInfoForm.cs                        //音乐信息窗体类
│  SongInfoForm.Designer.cs
│  SongInfoForm.resx
│  Songs.cs                               //音乐类
│  TaskbarManager.cs                      //任务栏状态类
│  
│              
├─Http                                    //下载帮助类
│      Song.cs             
│      SongDownloader.cs
│      WebClient.cs
│      
├─Properties                               //项目属性文件夹
│      app.manifest
│      AssemblyInfo.cs
│      Resources.Designer.cs
│      Resources.resx
│      Settings.Designer.cs
│      Settings.settings
│      
├─Resources                                 //资源文件夹
│      
└─Source
        IMusicSource.cs                     //音乐源接口
        KugouSource.cs                      //酷狗音乐源
        KuwoSourse.cs                       //酷我音乐源
        MusicSources.cs                     //音乐源聚合
        NeteaseSource.cs                    //网易音乐源
        QQSource.cs                         //QQ音乐源
        
```
