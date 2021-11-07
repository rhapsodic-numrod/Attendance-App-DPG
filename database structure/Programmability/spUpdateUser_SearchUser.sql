USE attendanceDatabase
GO
CREATE PROCEDURE dbo.searchByUserID
@userID VARCHAR(50),
@result VARCHAR(MAX) OUT,
@role INT
AS
BEGIN
    IF @role = 1
        IF EXISTS(SELECT studentID FROM Student WHERE studentID = @userID)
            SELECT * FROM Student WHERE studentID = @userID
        ELSE
            SET @result = 'User does not exist'
    ELSE
        IF EXISTS(SELECT empID FROM Employee WHERE empID = @userID)
            SELECT * FROM Employee WHERE empID = @userID
        ELSE
            SET @result = 'User does not exist'
END
GO
CREATE PROCEDURE dbo.updateUser
@userID VARCHAR(50),
@firstName VARCHAR(50),
@middleName VARCHAR(50),
@lastName VARCHAR(50),
@email VARCHAR(50),
@mobile CHAR(10),
@error VARCHAR(MAX),
@role INT
AS
BEGIN
    IF @role = 1 
        IF EXISTS(SELECT studentID FROM Student WHERE studentID = @userID)
            BEGIN TRY
                UPDATE Student SET
                firstName = @firstName,
                middleName = @middleName,
                lastName = @lastName,
                studentEmail = @email,
                studentMobile = @mobile
                WHERE studentID = @userID
            END TRY
            BEGIN CATCH
                SET @error = ERROR_MESSAGE();
            END CATCH
    ELSE
        IF EXISTS(SELECT empID FROM Employee WHERE empID = @userID)
            BEGIN TRY
                UPDATE Employee SET
                firstName = @firstName,
                middleName = @middleName,
                lastName = @lastName,
                empEmail = @email,
                empMobile = @mobile
                WHERE empID = @userID
            END TRY
            BEGIN CATCH
                SET @error = ERROR_MESSAGE();
            END CATCH
END