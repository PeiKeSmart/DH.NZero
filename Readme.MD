## DH.NZero 零代脚手架
这里展现了NewLife生态圈各种类型项目的模版，开发新项目时可以直接拷贝使用。  

## 公共项目
1. Zero.Core。零代核心库，Web应用、微服务、应用服务、大数据计算和客户端等多个端共用的类库，例如模型类等。原则上要求最少依赖第三方。  
2. Zero.Data。零代数据层，Web应用、微服务、应用服务、大数据计算等共用数据层，主要包括数据层实体类。一般只用于服务端，内有XCode模版及代码生成器。  

## 现代应用
1. Zero.Web。Web管理平台，零代数据管理平台，基于魔方，快速开发各种管理后台  
2. Zero.WebApi。WebApi接口，数据接口，带有Swagger的标准WebApi接口项目  
3. Zero.Worker。系统后台任务，数据处理、定时任务、MQ生产消费、系统监控等超长独立工作的后台任务  

## 网络应用
1. Zero.HttpServer。Http服务，轻量级Http服务器，可用于追求简单Http服务的场景，例如暴露硬件控制为Http接口，如打印组件  
2. Zero.WebSockerServer。WebSocket服务，轻量级WebSocket服务，可用于网页与终端本地硬件保持长连接通信  
3. Zero.RpcServer。RPC服务端，高性能，长连接，数据接口  
4. Zero.TcpServer。Tcp网络服务器，高性能Tcp网络服务器，单机最高400万连接，可用于建立各种协议的网络服务器  

## 经典应用
1. Zero.Agent。系统守护服务，数据处理、定时任务、MQ生产消费、系统监控等超长独立工作的后台任务，常安装为Windows服务，Linux上需要sudo才能安装为守护进程随系统启动  
2. Zero.AntJob。大数据计算，蚂蚁调度系统子程序，编写数据处理等业务逻辑，连接蚂蚁调度中心，拉取作业任务来执行
3. Zero.Console。控制台项目模版
4. Zero.Server。网络服务器项目模版
