USE attendanceDatabase
GO
CREATE OR ALTER PROCEDURE dbo.searchByUserID
@userID VARCHAR(50),
@result VARCHAR(MAX) OUT,
@role INT
AS
BEGIN
    IF @role = 1
        IF EXISTS(SELECT studentID FROM Student WHERE studentID = @userID)
            BEGIN
                SELECT * FROM Student WHERE studentID = @userID
                SET @result = 'Found ' + @userID
            END
        ELSE
            SET @result = 'User does not exist'
    ELSE
        IF EXISTS(SELECT empID FROM Employee WHERE empID = @userID)
            BEGIN
                SELECT * FROM Employee WHERE empID = @userID
                SET @result = 'Found ' + @userID
            END
        ELSE
            SET @result = 'User does not exist'
END
GO
CREATE OR ALTER PROCEDURE dbo.updateUser
@userID VARCHAR(50),
@firstName VARCHAR(50),
@middleName VARCHAR(50),
@lastName VARCHAR(50),
@email VARCHAR(50),
@mobile CHAR(70),
@result VARCHAR(MAX) OUT,
@role INT
AS
BEGIN
    IF @role = 1 
        BEGIN
            IF LEN(@mobile) = 10
               BEGIN
                    UPDATE Student SET
                    firstName = @firstName,
                    middleName = @middleName,
                    lastName = @lastName,
                    studentEmail = @email,
                    studentMobile = @mobile
                    WHERE studentID = @userID
                    SET @result = 'User Updated successfully'
                END
            ELSE
                BEGIN
                    SET @result = 'Phone number must be 10 digits long';
                END
        END
    ELSE
        BEGIN
            IF LEN(@mobile) = 10
                BEGIN
                    UPDATE Employee SET
                    firstName = @firstName,
                    middleName = @middleName,
                    lastName = @lastName,
                    empEmail = @email,
                    empMobile = @mobile
                    WHERE empID = @userID
                    SET @result = 'User Updated successfully'
                END
                
            ELSE
                BEGIN
                    SET @result = 'Phone number must be 10 digits long';
                END
        END
END