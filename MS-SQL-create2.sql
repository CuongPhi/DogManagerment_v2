﻿CREATE DATABASE DOGMANAGED
GO
USE DOGMANAGED

GO

CREATE TABLE PERSON
(
	ID INT PRIMARY KEY  -- CMND
)
GO

CREATE TABLE DOGHOUSE
(
	ID  NVARCHAR(10) PRIMARY KEY,
	DESTRIPTION VARCHAR(100)
)
GO
CREATE TABLE PERSONINFOR
(
	ID_TT VARCHAR(10) PRIMARY KEY,
	ID INT FOREIGN KEY REFERENCES dbo.PERSON(ID), -- CMND
	NAME NVARCHAR(100),
	EMAIL NVARCHAR(100),
	PHONE VARCHAR(20),
	BIRHDAY DATE,

)
GO
CREATE TABLE ADDRESS
(
	ID INT PRIMARY KEY IDENTITY,
	DETAIL NVARCHAR (20), -- MÔ TẢ 
	STREET NVARCHAR(50),
	WARD VARCHAR(50),
	DISTRICT NVARCHAR(50),
	IDPERSON VARCHAR(10) FOREIGN KEY REFERENCES dbo.PERSONINFOR(ID_TT)
)
GO
CREATE TABLE DOG
(
	WEIGHT FLOAT,
	ID INT IDENTITY PRIMARY KEY, 
	TYPE INT DEFAULT 0, 	
	DAYIN DATE,
	FOODPRICE INT,
	IDDOGHOUSE NVARCHAR(10) FOREIGN KEY REFERENCES dbo.DOGHOUSE(ID)
)
CREATE TABLE DOG_INFOR -- THÔNG TIN BẮT CHÓ
(
	ID INT PRIMARY KEY IDENTITY,	
	STREET NVARCHAR(50),
	WARD VARCHAR(50),
	DISTRICT NVARCHAR(50),
	TIME TIME, -- TOI GIAN BAT CHO
	IDDOG INT FOREIGN KEY REFERENCES dbo.DOG(ID)

)
GO

CREATE TABLE USERAPP
(
	ID INT IDENTITY PRIMARY KEY,
	IDPERSON INT FOREIGN KEY REFERENCES dbo.PERSON(ID),
	SALARY INT, 
	DAYJOIN DATE,
	ID_BANK VARCHAR(20),
	ID_MEDICAL VARCHAR(20)

)
GO
CREATE TABLE CUSTOMER
(
	ID INT PRIMARY KEY IDENTITY,
	IDPERSON INT FOREIGN KEY REFERENCES dbo.PERSON(ID)
)
GO
CREATE TABLE ACCOUNT
(
	ID_USER INT FOREIGN KEY REFERENCES dbo.USERAPP(ID),
	USERNAME VARCHAR(50) PRIMARY KEY,
	PASSWORD VARCHAR(100),
	PASSWORD2 VARCHAR(100),
	TYPE INT DEFAULT 0,
	ISBAN BIT DEFAULT 0
)
GO
CREATE TABLE BILL
(
	ID_BILL VARCHAR(10) PRIMARY KEY ,
	ID_USER INT FOREIGN KEY REFERENCES dbo.USERAPP(ID),
	ID_CUSTOMER INT FOREIGN KEY REFERENCES dbo.CUSTOMER(ID),
	IDDOG INT FOREIGN KEY REFERENCES dbo.DOG(ID),
	DAY_BILL DATE,
	FINE INT -- TIỀN PHẠT 
)
GO
CREATE TABLE DOG_DESTROY
(
	ID INT PRIMARY KEY IDENTITY,
	IDDOG INT FOREIGN KEY REFERENCES DOG,
	DATE_DESTROY DATE
	
)