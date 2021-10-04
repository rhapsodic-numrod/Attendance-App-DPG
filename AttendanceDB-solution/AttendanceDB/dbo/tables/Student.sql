CREATE TABLE [dbo].[Student]
(
	[studentId] INT NOT NULL PRIMARY KEY, 
    [firstName] VARCHAR(25) NOT NULL, 
    [middleName] VARCHAR(25) NULL, 
    [lastName] VARCHAR(25) NOT NULL, 
    [studentEmail] VARCHAR(50) NOT NULL, 
    [studentPassword] VARCHAR(50) NOT NULL, 
    [studentMobile] CHAR(10) NOT NULL, 
    [role] VARCHAR(10) NOT NULL
)
