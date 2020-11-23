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
	doc_usr varchar(12) primary key,
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
	pat_id int identity(1000,1) primary key,
	pat_fullname nvarchar(50) not null,
	pat_gender bit not null,
	pat_dob date not null,
	pat_address nvarchar(100),
	pat_phone1 char(10) not null,
	pat_phone2 char(10),
	pat_anamnesis nvarchar(500)
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
	pat_id int foreign key references PATIENT(pat_id) not null,
	doc_usr varchar(12) foreign key references DOCTOR(doc_usr) not null,
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

INSERT INTO PATIENT(pat_fullname, pat_gender, pat_dob, pat_address, pat_phone1, pat_phone2, pat_anamnesis) VALUES
(N'Nguyễn Thị Thập',0,'11/11/1960',N'123 Quốc Hương, P. Thảo Điền, Q.2','0468512167','0684235972',N'Viêm ruột thừa'),
(N'Trần Văn Hòa',1,'10/09/1980',N'43 Trần Não, P. Bình An, Q.2','0992457859','0145012359',N'Sỏi thận'),
(N'Phạm Quốc Tuấn',1,'12/08/1990',N'456 Lương Định Của, P. An Phú, Q.2','0881535859','0453823893',N'Tăng huyết áp')

GO

INSERT INTO EXAM_TYPE VALUES
(0,N'Có kê toa',150000),
(1,N'Không kê toa',100000),
(2,N'Tư vấn sức khỏe',80000)

GO 
INSERT INTO MEDICINE VALUES
('hapacolc500',N'Hapacol Caplet Acetaminophen 500mg'),
('hapacola500',N'Hapacol Ace Acetaminophen 500mg Capsules Dhg'),
('quazimin',N'Quazimin Arginine Aspartate 1000mg Opv'),
('dotoux25',N'Dotoux Plus Domesco (h/25)'),
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
('maleutyl',N'Maleutyl 500mg Hasan '),
('alzental400',N'Alzental 400mg'),
('albendazol400',N'Albendazol STELLA 400 mg'),
('acemuc200',N'Acemuc 200mg')
GO
/* todo
	Thêm 1 bệnh có yêu cầu xét nghiệm
	Thêm vào bảng xét nghiệm
*/
INSERT INTO RECORD(rec_date,pat_id,doc_usr,rec_diagnostic, hospital,exam_type_id,rec_note) VALUES
('18:45:00 11/19/2020',1000,'dqlai',N'Viêm ruột thừa tái phát gây đau nhứt',null,1,N'Ăn uống đúng bữa, kiêng dầu mỡ'),
('8:40:00 12/19/2020',1001,'nkuyen',N'Viêm ruột thừa tái phát gây đau nhứt',null,1,N'Ăn uống đúng bữa, kiêng dầu mỡ')

GO
INSERT INTO PRESCRIPTION VALUES
(100000,'hapacolc500',1,1,1,N'Uống trước khi ăn'),
(100001,'quazimin',1,0,1,N'Uống san khi ăn no')

GO

/*

CREATE PROCEDURE CREATEMODEL  
(  
     @TableName SYSNAME 
)  
AS  
BEGIN  
    DECLARE @Result VARCHAR(MAX)  
    SET @Result = 'public class ' + upper(left(@TableName,1)) + substring(@TableName,2,len(@TableName))+ '_DTO
{'  
SELECT @Result = @Result + '  
    public ' + ColumnType + NullableSign + ' ' + ColumnName + ' { get; set; }'  
FROM  
(  
    SELECT
		upper(left(col.NAME,1)) + substring(col.NAME,2,len(col.NAME)) ColumnName,  
        column_id ColumnId,  
        CASE typ.NAME   
            WHEN 'bigint' THEN 'long'  
            WHEN 'binary' THEN 'byte[]'  
            WHEN 'bit' THEN 'bool'  
            WHEN 'char' THEN 'string'  
            WHEN 'date' THEN 'DateTime'  
            WHEN 'datetime' THEN 'DateTime'  
            WHEN 'datetime2' then 'DateTime'  
            WHEN 'datetimeoffset' THEN 'DateTimeOffset'  
            WHEN 'decimal' THEN 'decimal'  
            WHEN 'float' THEN 'float'  
            WHEN 'image' THEN 'byte[]'  
            WHEN 'int' THEN 'int'  
            WHEN 'money' THEN 'decimal'  
            WHEN 'nchar' THEN 'char'  
            WHEN 'ntext' THEN 'string'  
            WHEN 'numeric' THEN 'decimal'  
            WHEN 'nvarchar' THEN 'string'  
            WHEN 'real' THEN 'double'  
            WHEN 'smalldatetime' THEN 'DateTime'  
            WHEN 'smallint' THEN 'short'  
            WHEN 'smallmoney' THEN 'decimal'  
            WHEN 'text' THEN 'string'  
            WHEN 'time' THEN 'TimeSpan'  
            WHEN 'timestamp' THEN 'DateTime'  
            WHEN 'tinyint' THEN 'byte'  
            WHEN 'uniqueidentifier' THEN 'Guid'  
            WHEN 'varbinary' THEN 'byte[]'  
            WHEN 'varchar' THEN 'string'  
            ELSE 'UNKNOWN_' + typ.NAME  
        END ColumnType,  
        CASE   
            WHEN col.is_nullable = 1 and typ.NAME in ('bigint', 'bit', 'date', 'datetime', 'datetime2', 'datetimeoffset', 'decimal', 'float', 'int', 'money', 'numeric', 'real', 'smalldatetime', 'smallint', 'smallmoney', 'time', 'tinyint', 'uniqueidentifier')   
            THEN '?'   
            ELSE ''   
        END NullableSign  
    FROM SYS.COLUMNS col join sys.types typ on col.system_type_id = typ.system_type_id AND col.user_type_id = typ.user_type_id  
    where object_id = object_id(@TableName)  
) t  
ORDER BY ColumnId  
SET @Result = @Result  + '  
}'  
print @Result  
END

exec CREATEMODEL 'exam_type'
*/
