CREATE PROCEDURE dbo.addStudent
@firstName VARCHAR(50),
@middleName VARCHAR(50),
@lastName VARCHAR(50),
@email VARCHAR(50),
@mobile CHAR(10),
@result VARCHAR(MAX) OUT
AS
BEGIN
    DECLARE 
    @userID VARCHAR(50), 
    @password VARCHAR(50),
    @minInt int = 100000,
    @maxInt int = 999999,
    @randNum int;

    SET @randNum = (rand()*(@maxInt- @minInt + 1) + @minInt) -- create random 
    SET @userID = 'St' + SUBSTRING(@firstName, 1, 3) + SUBSTRING(@lastName, 1, 3) + CAST(@randNum as varchar(10))

    DECLARE @rows INT = (select COUNT(*) from Student WHERE studentID = @userID);
    WHILE(@rows != 0)
        BEGIN
            SET @randNum = (rand()*(@maxInt- @minInt + 1) + @minInt) -- create random 
            SET @userID = 'St' + SUBSTRING(@firstName, 1, 3) + SUBSTRING(@lastName, 1, 3) + @randNum
            SET @rows = (select COUNT(*) from Student WHERE studentID = @userID)
        END
    SET @password = 'NUST@'+@userID
   
    BEGIN TRY
        BEGIN TRANSACTION
            INSERT INTO Student(studentID, firstName, middleName, lastName, studentEmail, studentPassword, studentMobile)
                    VALUES(@userID, @firstName, @middleName, @lastName, @email, @password, @mobile);

            INSERT INTO Student_Role(roleID, studentID)
                        VALUES(1, @userID)
        COMMIT TRANSACTION
        SET @result = 'Added Student Successfuly: ' + @firstName + ' ' + @lastName + ':  ' + @userID;
    END TRY
    BEGIN CATCH
        -- Transaction uncommittable
        IF (XACT_STATE()) = -1
        SET @result = ERROR_MESSAGE()
        ROLLBACK TRANSACTION
    
        -- Transaction committable
        IF (XACT_STATE()) = 1
        COMMIT TRANSACTION
    END CATCH
END

GO
CREATE PROCEDURE dbo.addLecturer
@firstName VARCHAR(50),
@middleName VARCHAR(50),
@lastName VARCHAR(50),
@email VARCHAR(50),
@mobile CHAR(10),
@result VARCHAR(MAX) OUT
AS
BEGIN
    DECLARE 
    @userID VARCHAR(50), 
    @password VARCHAR(50),
    @minInt int = 100000,
    @maxInt int = 999999,
    @randNum int;

    SET @randNum = (rand()*(@maxInt- @minInt + 1) + @minInt) -- create random 
    SET @userID = 'Lec' + SUBSTRING(@firstName, 1, 3) + SUBSTRING(@lastName, 1, 3) + CAST(@randNum as varchar(10))

    DECLARE @rows INT = (select COUNT(empID) from Employee WHERE empID = @userID)
    WHILE(@rows != 0)
        BEGIN
            SET @randNum = (rand()*(@maxInt- @minInt + 1) + @minInt) -- create random 
            SET @userID = 'Lec' + SUBSTRING(@firstName, 1, 3) + SUBSTRING(@lastName, 1, 3) + CAST(@randNum as varchar(10))
            SET @rows = (select COUNT(empID) from Employee WHERE empID = @userID);
        END 
    SET @password = 'NUST@'+@userID
    BEGIN TRY
        BEGIN TRANSACTION
            INSERT INTO Employee(empID, firstName, middleName, lastName, empEmail, empPassword, empMobile)
                    VALUES(@userID, @firstName, @middleName, @lastName, @email, @password, @mobile);

            INSERT INTO Employee_Role(roleID, empID)
                        VALUES(2, @userID)
        COMMIT TRANSACTION
        SET @result = 'Added Employee Successfuly: ' + @firstName + ' ' + @lastName + ':  ' + @userID;
    END TRY
    BEGIN CATCH
        -- Transaction uncommittable
        IF (XACT_STATE()) = -1
        SET @result = ERROR_MESSAGE()
        ROLLBACK TRANSACTION
    
        -- Transaction committable
        IF (XACT_STATE()) = 1
        COMMIT TRANSACTION
    END CATCH
END

GO
CREATE PROCEDURE dbo.addAdmin
@firstName VARCHAR(50),
@middleName VARCHAR(50),
@lastName VARCHAR(50),
@email VARCHAR(50),
@mobile CHAR(10),
@result VARCHAR(MAX) OUT
AS
BEGIN
    DECLARE 
    @userID VARCHAR(50), 
    @password VARCHAR(50),
    @minInt int = 100000,
    @maxInt int = 999999,
    @randNum int;
    SET @randNum = (rand()*(@maxInt- @minInt + 1) + @minInt) -- create random 
    SET @userID = 'Adm' + SUBSTRING(@firstName, 1, 3) + SUBSTRING(@lastName, 1, 3) + CAST(@randNum as varchar(10))
    DECLARE @rows INT = (select COUNT(empID) from Employee WHERE empID = @userID);
    WHILE(@rows != 0)
        BEGIN
            SET @randNum = (rand()*(@maxInt- @minInt + 1) + @minInt) -- create random 
            SET @userID = 'Adm' + SUBSTRING(@firstName, 1, 3) + SUBSTRING(@lastName, 1, 3) + CAST(@randNum as varchar(10))
            SET @rows = (select COUNT(empID) from Employee WHERE empID = @userID);
        END 
    SET @password = 'NUST@'+@userID
    BEGIN TRY
        BEGIN TRANSACTION
            INSERT INTO Employee(empID, firstName, middleName, lastName, empEmail, empPassword, empMobile)
                    VALUES(@userID, @firstName, @middleName, @lastName, @email, @password, @mobile);

            INSERT INTO Employee_Role(roleID, empID)
                        VALUES(3, @userID)
        COMMIT TRANSACTION
        SET @result = 'Added Employee Successfuly: ' + @firstName + ' ' + @lastName + ':  ' + @userID;
    END TRY
    BEGIN CATCH
        -- Transaction uncommittable
        IF (XACT_STATE()) = -1
        SET @result = ERROR_MESSAGE()
        ROLLBACK TRANSACTION
    
        -- Transaction committable
        IF (XACT_STATE()) = 1
        COMMIT TRANSACTION
    END CATCH
END

