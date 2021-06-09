CREATE DATABASE HR_Calculator
ON
(
	NAME=HRCalculator,
	FILENAME='D:\HRCalculator.mdf'
)

use HR_Calculator;

CREATE TABLE Workers		
(
	idWorker	int identity(1, 1)		
 	 			PRIMARY KEY,
	PIB	TEXT NOT NULL,
	seriesAndNumber	varchar(20) NOT NULL UNIQUE CHECK(LEN(seriesAndNumber)>7),
	dateOfIssue	DATE NOT NULL CHECK(GETDATE() >= dateOfIssue),
	issuingAuthority	TEXT NOT NULL
)

CREATE TABLE Department	
(
	idDepartment int identity(1, 1) PRIMARY KEY,
	DepartmentName	TEXT NOT NULL,
	Division	TEXT NOT NULL
)

CREATE TABLE Post
(
	idPost	int identity(1, 1) PRIMARY KEY,
	PostName	TEXT NOT NULL
)

CREATE TABLE HeldPosts		
(
	idHeldPost int identity(1, 1) PRIMARY KEY,
	idPost	int FOREIGN KEY REFERENCES Post(idPost),
	idWorker int FOREIGN KEY REFERENCES Workers(idWorker),
	dateOfAppointment DATE NOT NULL CHECK(GETDATE() > dateOfAppointment),
	Department int FOREIGN KEY REFERENCES Department (idDepartment)
)
