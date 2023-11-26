# Cloudreve Client For Windows

该项目是一个用C# Win Form（.Net Framework 4.8）编写的基于Cloudreve 3.8.X云盘服务的客户端程序。<br>
原本是想给Cloudreve云盘加功能的，但是发现它是用go语言编写的，很遗憾，我不会这个语言。之后又看见GitHub上ErrorCodesForLzx这位朋友所写的安卓客户端CloudreveZX，可惜他没有写完。所以，决定自己写一个客户端吧。但因本人时间有限，只实现了Web客户端主页面的具体功能，配置/设置页面的功能后期会陆续补上。<br>
不论如何，还是要感谢ErrorCodesForLzx这位朋友！！！

# 实现了：<br>
1、登录（包括验证码登录）<br>
2、保存密码，自动登录功能<br>
3、从保存的Cloudreve服务器列表中选择此次所要登录的Cloudreve服务器地址，该信息保存在system.db（SQLite）数据库中<br>
4、跟网页端一样，主页面左边显示的菜单，可以隐藏/显示<br>
5、文件列表<br>
6、路径显示/选择/跳转<br>
7、跟网页端一样，可以按类别显示文件列表，比如图片，视频，文档等等<br>
8、创建/删除目录<br>
9、文件的上传/下载列表，是分开的，上传是上传的文件列表，下载是下载的文件列表。<br>
10、删除文件/目录<br>
10、跟网页端一样，可以对当前文件列表进行排序，比如按字母排序，修改时间排序，文件大小排序等等<br>
11、显示文件/目录的属性<br>
12、创建分享，跟网页端一样，可以密码分享，并选择过期时间等等<br>
13、分享的文件/目录列表显示，及删除分享<br>
14、登录百度网盘（这里使用的是WebView2控件，登录后，就基本上用不着了，除非你点击进入网盘按钮，会在程序中显示百度网盘的页面），并从百度网盘中导入文件至Cloudreve网盘中指定的的目录里。（注：这里不包含破除百度网盘传输限速功能，具体传输速度根据你在百度网盘的会员等级而定）<br>

# 未完成功能：
1、百度网盘登录后，不知道怎么退出登录，所以现在如果想推出的话，只能点击进入网盘按钮，然后在那个页面中退出<br>
2、还没有实现目录的上传（包括从百度网盘中导入一个文件夹到Cloudreve云盘），等我有时间了，我加上这个功能<br>
3、设置页面（包括管理员设置页面）的功能<br>
4、文件在线预览<br>

开源这个项目是想通过这个项目广交志同道合的朋友。<br>
可能大神看了我的代码，会觉得写的不好，在此也希望各位大神们能提出你们宝贵的意见，也让我能进步的更快！谢谢！<br>

如果大家知道如何让这个项目仓库代码变的像Linux一样，大家都可以修改，请告诉我如何设置！我想让感兴趣的朋友都能修改这个代码，但前提是保证运行没问题。谢谢！<br>

以下是程序的界面，我就不一一放出来了，基本上和网页端的一样。<br>

![image](https://private-user-images.githubusercontent.com/30212659/285661072-303eab99-a901-4f61-87e5-31a41714b9a4.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTEiLCJleHAiOjE3MDEwMTI5ODQsIm5iZiI6MTcwMTAxMjY4NCwicGF0aCI6Ii8zMDIxMjY1OS8yODU2NjEwNzItMzAzZWFiOTktYTkwMS00ZjYxLTg3ZTUtMzFhNDE3MTRiOWE0LnBuZz9YLUFtei1BbGdvcml0aG09QVdTNC1ITUFDLVNIQTI1NiZYLUFtei1DcmVkZW50aWFsPUFLSUFJV05KWUFYNENTVkVINTNBJTJGMjAyMzExMjYlMkZ1cy1lYXN0LTElMkZzMyUyRmF3czRfcmVxdWVzdCZYLUFtei1EYXRlPTIwMjMxMTI2VDE1MzEyNFomWC1BbXotRXhwaXJlcz0zMDAmWC1BbXotU2lnbmF0dXJlPWY0MDliMGI4MWI4YWM4OWZiOGFiOTRkYmE1MmU2N2RlYWI0YTZhYWNjMmZhY2Q2ZTcyOTAwMTcxOTk3MTBhN2EmWC1BbXotU2lnbmVkSGVhZGVycz1ob3N0JmFjdG9yX2lkPTAma2V5X2lkPTAmcmVwb19pZD0wIn0.QOJ7EMKExfBhT6LQ_4NfoGdPfPEdUS0fb7MsbEuUb_I)

![image](https://private-user-images.githubusercontent.com/30212659/285661288-31be791f-26a8-4f82-ac69-1e8a3d8312f6.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTEiLCJleHAiOjE3MDEwMTI5ODQsIm5iZiI6MTcwMTAxMjY4NCwicGF0aCI6Ii8zMDIxMjY1OS8yODU2NjEyODgtMzFiZTc5MWYtMjZhOC00ZjgyLWFjNjktMWU4YTNkODMxMmY2LnBuZz9YLUFtei1BbGdvcml0aG09QVdTNC1ITUFDLVNIQTI1NiZYLUFtei1DcmVkZW50aWFsPUFLSUFJV05KWUFYNENTVkVINTNBJTJGMjAyMzExMjYlMkZ1cy1lYXN0LTElMkZzMyUyRmF3czRfcmVxdWVzdCZYLUFtei1EYXRlPTIwMjMxMTI2VDE1MzEyNFomWC1BbXotRXhwaXJlcz0zMDAmWC1BbXotU2lnbmF0dXJlPTY3ZTA1NGZkMmMwZWNjNWY3NTdlZjUyY2MzYjRjYzZjMTZlNDlmMTRhMDQ2YTBmODliNWMxZjMyOGMyNDFhMzUmWC1BbXotU2lnbmVkSGVhZGVycz1ob3N0JmFjdG9yX2lkPTAma2V5X2lkPTAmcmVwb19pZD0wIn0.pqoT5U8Kcuif6bQdeN8fPSi_3ru53D8wVnlEI3G01uk)

