CREATE PROCEDURE dbo.changePassword
@userID VARCHAR(50),
@currentPassword VARCHAR(50),
@newPassword VARCHAR(50),
@result VARCHAR(MAX) OUT,
@role INT
AS
BEGIN
     IF @role = 1
        IF EXISTS(SELECT studentID, studentPassword FROM Student WHERE studentID = @userID AND studentPassword = @currentPassword)
            BEGIN
                IF LEN(@newPassword) > 8
                    BEGIN
                        UPDATE Student SET studentPassword = @newPassword WHERE studentID = @userID
                        SET @result = 'Password successfully Changed'
                    END
                ELSE
                    SET @result = 'Password is too short. It should be longer than 8 characters'
            END
        ELSE
            SET @result = 'Incorrect password entered'
        
    ELSE
        IF EXISTS(SELECT empID, empPassword FROM Employee WHERE empID = @userID AND empPassword = @currentPassword)
            BEGIN
                IF LEN(@newPassword) > 8
                    BEGIN
                        UPDATE Employee SET empPassword = @newPassword WHERE empID = @userID
                        SET @result = 'Password successfully Changed'
                    END
                ELSE
                    SET @result = 'Password is too short. It should be longer than 8 characters'
            END
        ELSE
            SET @result = 'Incorrect password entered'
END
GO
CREATE OR ALTER PROCEDURE dbo.updateMobileNo
@userID VARCHAR(50),
@newMobile VARCHAR(70),
@result VARCHAR(MAX) OUT,
@role INT
AS
BEGIN
    IF @role = 1
        BEGIN
            IF LEN(@newMobile) = 10
                BEGIN
                    UPDATE Student SET studentMobile = @newMobile WHERE studentID = @userID
                    SET @result = 'Mobile number successfully Changed';
                END
            ELSE
                BEGIN
                    SET @result = 'Phone number must be 10 digits long'
                END
        END
    ELSE
        BEGIN
            IF LEN(@newMobile) = 10
                BEGIN
                    UPDATE Employee SET empMobile = @newMobile WHERE empID = @userID
                    SET @result = 'Mobile number successfully Changed';
                END
            ELSE
                BEGIN
                    SET @result = 'Phone number must be 10 digits long'
                END
        END
END