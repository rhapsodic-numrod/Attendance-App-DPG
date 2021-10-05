CREATE TABLE [dbo].[Employee] (
    [empID] INT NOT NULL PRIMARY KEY,
    [firstName] VARCHAR(25),
    [middleName] VARCHAR(25),
    [lastName] VARCHAR(25),
    [empEmail] VARCHAR(50),
    [empPassword] VARCHAR(50),
    [empMobile] CHAR(10),
    [role] VARCHAR(10)
)