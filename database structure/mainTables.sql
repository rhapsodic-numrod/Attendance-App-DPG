USE master
GO
-- Uncomment the ALTER DATABASE statement below to set the database to SINGLE_USER mode if the drop database command fails because the database is in use.
ALTER DATABASE attendanceDatabase SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
-- Drop the database if it exists
IF EXISTS (
    SELECT [name]
        FROM sys.databases
        WHERE [name] = N'attendanceDatabase'
)
DROP DATABASE attendanceDatabase
GO
--CREATE DATABASE
CREATE DATABASE attendanceDatabase
GO
USE attendanceDatabase
GO
--CREATE BASE TABLES IN DATABASE
--############# Independendent #############
CREATE TABLE Student(
	studentID VARCHAR(50) PRIMARY KEY NOT NULL,
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
	empID VARCHAR(50) PRIMARY KEY NOT NULL,
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
	className VARCHAR(10),
	canAttend BIT DEFAULT 0
)
-- Adding roles and classtypes to tables
INSERT INTO ClassType(typeID, className) VALUES(1,'Theory'), (2, 'Practival')
INSERT INTO Roles(roleID, roleName) VALUES(1,'Student'), (2, 'Lecturer'), (3, 'Admin')
INSERT INTO Attendance(attendanceID, attendanceStatus) VALUES (1,1), (2,0)
INSERT INTO Class(classID, className, classTypeID,moduleID)
            VALUES(1,'DPG',1,1),
                   (2,'DPG',2,1),
                   (4,'PRG',1,2),
                   (3,'PRG',2,2),
                   (5,'COA',1,5),
                   (6,'COA',2,5),
                   (7,'DSA',1,4),
                   (8,'DSA',2,4),
                   (9,'MCI',1,3),
                   (10,'EPR',1,6)
GO

INSERT INTO [Module](moduleID,moduleName)
            VALUES(1, 'DPG621SS'),
                  (2,'PRG510S'),
                  (3,'MCI521S'),
                  (4,'DSA521S'),
                  (5,'COA511S'),
                  (6,'EPR511S')
GO
CREATE VIEW allUsers AS
SELECT studentID AS userID, firstName, middleName, lastName, studentEmail AS userEmail, studentMobile AS userMobile FROM Student
    UNION
SELECT empID, firstName, middleName, lastName, empEmail, empMobile FROM Employee
GO
CREATE PROCEDURE generalSearch
@searchParam VARCHAR(50)
AS
BEGIN
    SELECT * FROM allUsers WHERE userID LIKE '%'+@searchParam+'%' OR firstName LIKE '%'+@searchParam+'%' OR middleName LIKE '%'+@searchParam+'%' OR lastName LIKE '%'+@searchParam+'%' OR userEmail LIKE '%'+@searchParam+'%' OR userMobile LIKE '%'+@searchParam+'%' 
END