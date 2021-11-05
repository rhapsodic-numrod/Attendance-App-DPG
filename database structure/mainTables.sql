USE master
GO
--if the db exist drop it before it is altered
DROP DATABASE IF EXISTS attendanceDatabase
GO
--CREATE DATABASE
CREATE DATABASE attendanceDatabase
GO
USE attendanceDatabase
GO
--CREATE BASE TABLES IN DATABASE
--############# Independendent #############
CREATE TABLE Student(
	studentID INT PRIMARY KEY NOT NULL,
	firstName VARCHAR(50) NOT NULL,
	middleName VARCHAR(50),
	lastName VARCHAR(50) NOT NULL,
	studentEmail VARCHAR(50) NOT NULL,
	studentPassword VARCHAR(50) NOT NULL,
	studentMobile CHAR(10)
)
CREATE TABLE Roles(
	roleID INT PRIMARY KEY NOT NULL,
	roleName VARCHAR(10) NOT NULL
)
CREATE TABLE Module(
	moduleID INT PRIMARY KEY NOT NULL,
	moduleName VARCHAR(10)
)
CREATE TABLE Exam(
	examID INT PRIMARY KEY NOT NULL,
	examName VARCHAR(10)
)
CREATE TABLE ClassType(
	typeID INT PRIMARY KEY NOT NULL,
	className VARCHAR(10)
)
CREATE TABLE Employee(
	empID INT PRIMARY KEY NOT NULL,
	firstName VARCHAR(50) NOT NULL,
	middleName VARCHAR(50),
	lastName VARCHAR(50) NOT NULL,
	empEmail VARCHAR(50) NOT NULL,
	empPassword VARCHAR(50) NOT NULL,
	empMobile CHAR(10)
)
CREATE TABLE Attendance(
	attendanceID INT PRIMARY KEY NOT NULL,
	attendanceStatus BIT
)
--############# Partially dependendent #############
CREATE TABLE Class(
	classID INT PRIMARY KEY NOT NULL,
	moduleID INT FOREIGN KEY REFERENCES Module(moduleID),
	classTypeID INT FOREIGN KEY REFERENCES ClassType(typeID),
	className VARCHAR(10)
)