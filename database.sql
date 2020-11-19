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
CREATE TABLE RECORD( 
	rec_id int identity(100000,1) primary key,
	rec_date datetime not null,
	par_id int foreign key references PATIENT(par_id) not null,
	doc_id varchar(12) foreign key references DOCTOR(doc_id) not null,
	rec_diagnostic nvarchar(100) not null,
	hospital nvarchar(100),
	exam_type_id int foreign key references EXAM_TYPE(exam_type_id) not null,
	rec_note nvarchar(100)
)
GO
CREATE TABLE MEDICINE(
	med_id varchar(50) primary key,
	med_name nvarchar(70) not null
)
GO
CREATE TABLE PRESCRIPTION(
	rec_id int foreign key references RECORD(rec_id),
	med_id varchar(50) foreign key references MEDICINE(med_id),
	
	pre_morning int,
	pre_middle int,
	pre_afternoon int,

	pre_note nvarchar(100),
	primary key (rec_id,med_id)
)
GO
CREATE TABLE EXAMINATION(
	rec_id int primary key,
	exa_place nvarchar(50) not null,
	exa_content nvarchar(100) not null,
	exa_result nvarchar(500),
	foreign key (rec_id) references RECORD(rec_id)
)
GO

INSERT INTO DOCTOR VALUES
('dqlai','dqlai',N'Đặng Quốc Lai',1,'12/22/2000',N'BS. Chuyên khoa II',N'Quốc lộ 13, Thủ Đức, TP.HCM','0772470922',1),
('nkuyen','nkuyen',N'Nguyễn Kiều Uyên',0,'12/12/2000',N'BS. Chuyên khoa I',N'Hậu Giang, Q.6, TP.HCM','0123456789',1)

GO

INSERT INTO PATIENT(par_fullname, par_gender, par_dob, par_phone1, par_phone2, par_anamnesis) VALUES
(N'Nguyễn Thị Thập',0,'11/11/1960','0468512167','0684235972',N'Viêm ruột thừa'),
(N'Trần Văn Hòa',1,'10/09/1980','0992457859','0145012359',N'Sỏi thận'),
(N'Phạm Quốc Tuấn',1,'12/08/1990','0881535859','0453823893',N'Tăng huyết áp')

GO

INSERT INTO EXAM_TYPE VALUES
(1,N'Khám có kê toa',150000),
(2,N'Khám không kê toa',100000),
(3,N'Tư vấn sức khỏe',80000)

GO
/* todo
	Thêm 1 bệnh có yêu cầu xét nghiệm
	Thêm vào bảng xét nghiệm
*/
INSERT INTO RECORD(rec_date,par_id,doc_id,rec_diagnostic, hospital,exam_type_id,rec_note) VALUES
('18:45:00 11/19/2020',1000,'dqlai',N'Viêm ruột thừa tái phát gây đau nhứt',null,1,N'Ăn uống đúng bữa, kiêng dầu mỡ'),
('8:40:00 12/19/2020',1001,'nkuyen',N'Viêm ruột thừa tái phát gây đau nhứt',null,1,N'Ăn uống đúng bữa, kiêng dầu mỡ')

GO 
INSERT INTO MEDICINE VALUES
('hapacolc500',N'Hapacol Caplet Acetaminophen 500mg'),
('hapacola500',N'Hapacol Ace Acetaminophen 500mg Capsules Dhg'),
('quazimin',N'Quazimin Arginine Aspartate 1000mg Opv'),
('bedexlor',N'Bedexlor Dexchlorpheniramin Chunggei Pharm Co'),
('volexin250',N'Volexin Levofloxacin 250mg Boston'),
('dalekine200',N'Dalekine Natri Valproat 200mg Danapha'),
('prega150',N'Pendo - Pregabalin 150mg Domesco'),
('betahistin16',N'Betahistin 16mg An Thiên'),
('gaberon300',N'Gaberon Gabapentin 300mg Domesco'),
('pendo50',N'Pendo - Pregabalin 50mg Domesco'),
('docorrimin125',N'Docorrimin 125mg/1500mg Domesco'),
('dococetam',N'Dorocetam Piracetam 800mg Domesco'),
('phenytoin100',N'Phenytoin 100mg Danapha '),
('olanxol',N'Olanxol Olanzapin 10mg Danapha'),
('sakuzyal',N'Sakuzyal Oxcarbazepin 300mg Davipharm'),
('maleutyl',N'Maleutyl 500mg Hasan ')

GO
INSERT INTO PRESCRIPTION VALUES
(100003,'hapacolc500',1,1,1,N'Uống trước khi ăn'),
(100004,'quazimin',1,0,1,N'Uống san khi ăn no')

GO

SELECT * FROM DOCTOR