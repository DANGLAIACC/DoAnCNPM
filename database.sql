CREATE DATABASE MANAGE_CLINIC /*Quản lý phòng khám*/
GO 
USE MANAGE_CLINIC
GO
CREATE TABLE DOCTOR (
	doctor_id varchar(12) primary key,
	password varchar(20) not null,
	fullname nvarchar(50) not null,
	gender bit not null,
	dob date not null ,
	title nvarchar(30),
	address nvarchar(100) not null,
	phone char(10) not null,
	roles int not null
)
GO
CREATE TABLE PATIENT(
	partient_id char(10) primary key,
	fullname nvarchar(50) not null,
	gender bit not null,
	dob date not null,
	phone1 char(10) not null,
	phone2 char(10),

)