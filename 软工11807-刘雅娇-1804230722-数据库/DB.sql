--�л�ϵͳ���ݿ⣬��֤��ǰ���ݿⲻ��ʹ����
use master
go

--�������ݿ�,�ж��Ƿ��Ѵ��ڣ����������ɾ�����ٴ���
if exists (select * from sys.databases where name = 'Test')
--begin
	drop database Test
--end
go
create database Test
go

--ʹ�����ݿ�
use Test
go

--������
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

--��������

--��ѯ
select * from dbo.UserInfo