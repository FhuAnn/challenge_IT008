USE master
IF EXISTS (SELECT * FROM SYS.DATABASES WHERE NAME = 'DateUser')
BEGIN
	ALTER DATABASE DateUser SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
	DROP DATABASE DateUser;
END
CREATE DATABASE DateUser
GO

USE DateUser
GO
Create table user_pw
(
	ID varchar(8) primary key,
	name varchar(40) not null,
	username varchar(100) not null,
	password varchar(20) not null
)