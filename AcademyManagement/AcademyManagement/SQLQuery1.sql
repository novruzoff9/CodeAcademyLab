use master

create database academy

use academy

CREATE TABLE Students (
Id INT IDENTITY(1,1) PRIMARY KEY,
FirstName NVARCHAR(50) NOT NULL,
LastName NVARCHAR(50) NOT NULL,
Username NVARCHAR(50) NOT NULL UNIQUE,
Password NVARCHAR(50) NOT NULL
);

select * from Students