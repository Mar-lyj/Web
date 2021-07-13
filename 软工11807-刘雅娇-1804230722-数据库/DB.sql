--切换系统数据库，保证当前数据库不在使用中
use master
go

--创建数据库,判断是否已存在，如果存在先删除，再创建
if exists (select * from sys.databases where name = 'Test')
--begin
	drop database Test
--end
go
create database Test
go

--使用数据库
use Test
go

--创建表
create table UserInfo
(
	U_Id int identity(1,1) primary key,
	U_Name varchar(50) not null,
	U_Pwd varchar(50) not null,
	U_Email varchar(50) null,
	U_ChName  varchar(50) null,
	U_Phone  varchar(50) null,
	U_Sex  varchar(50) not null,
	U_Birth  varchar(50) null
)
go

--测试数据

--查询
select * from dbo.UserInfo