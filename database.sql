USE MASTER
GO
IF EXISTS (SELECT * FROM SYSDATABASES WHERE NAME = 'FAMILY_DOCTOR')
DROP DATABASE FAMILY_DOCTOR
GO 
CREATE DATABASE FAMILY_DOCTOR
GO 
USE FAMILY_DOCTOR 
GO
CREATE TABLE DOCTOR (
	doc_id varchar(12) primary key,
	doc_pwd varchar(20) not null,
	doc_fullname nvarchar(50) not null,
	doc_gender bit not null,
	doc_dob date not null ,
	doc_title nvarchar(30),
	doc_address nvarchar(100) not null,
	doc_phone char(10) not null,
	doc_role int not null
)
GO
CREATE TABLE PATIENT(
	par_id int identity(1000,1) primary key,
	par_fullname nvarchar(50) not null,
	par_gender bit not null,
	par_dob date not null,
	par_phone1 char(10) not null,
	par_phone2 char(10),
	par_anamnesis nvarchar(500)
)
GO
CREATE TABLE EXAM_TYPE(
	exam_type_id int primary key,
	exam_type_text nvarchar(40) not null,
	exam_type_price int not null,
)
GO
CREATE TABLE RECORD( /*Bản ghi hồ sơ khám bệnh*/
	rec_id int identity(100000,1) primary key,
	rec_date datetime not null,
	par_id int foreign key references PATIENT(par_id) not null,
	doc_id varchar(12) foreign key references DOCTOR(doc_id) not null,
	rec_diagnostic nvarchar(100) not null, /*chuẩn đoán*/
	hospital nvarchar(100), /*Bệnh viện được yêu cầu chuyển đến, nếu ko có nội dung là ko chuyển*/
	exam_type_id int foreign key references EXAM_TYPE(exam_type_id) not null,
	rec_note nvarchar(100)
)
GO
CREATE TABLE MEDICINE(
	med_id varchar(50) primary key, /*từ viết tắt*/
	med_name nvarchar(70) not null
)
GO
CREATE TABLE PRESCRIPTION( /*Chi tiết đơn thuốc*/
	rec_id int foreign key references RECORD(rec_id),
	med_id varchar(50) foreign key references MEDICINE(med_id),
	
	pre_morning int,
	pre_middle int,
	pre_afternoon int,

	pre_note nvarchar(100),
	primary key (rec_id,med_id)
)
GO
CREATE TABLE EXAMINATION( /*Xét nghiệm*/
	rec_id int primary key, /*Yêu cầu xét nghiệm đi với record*/
	exa_place nvarchar(50) not null, /*nơi xét nghiệm*/
	exa_content nvarchar(100) not null, /*loại xét nghiệm: máu, tổng quát,...*/
	exa_result nvarchar(500),
	foreign key (rec_id) references RECORD(rec_id)
)
