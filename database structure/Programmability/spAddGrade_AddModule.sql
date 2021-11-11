CREATE PROCEDURE dbo.StudentAddModule
@userID VARCHAR(50),
@moduleID INT,
@result VARCHAR(MAX) OUT
AS
BEGIN
    IF EXISTS(SELECT moduleID FROM [Module] WHERE moduleID = @moduleID)
        BEGIN
            IF NOT EXISTS(SELECT studentID, moduleID FROM Student_Module WHERE studentID = @userID AND moduleID = @moduleID)
                BEGIN
                    INSERT INTO Student_Module(moduleID, studentID)
                                    VALUES(@moduleID,@userID)
                    
                    SET @result = 'Module successfully added'
                END
            ELSE
                SET @result = 'You have already added this module'
        END
    ELSE
        SET @result = 'Module does not exist'
END

SELECT * from Student_Module
SELECT * FROM Employee_Class

GO

CREATE PROCEDURE dbo.LecturerChooseClass
@userID VARCHAR(50),
@classID INT,
@result VARCHAR(MAX) OUT
AS
BEGIN
    IF EXISTS(SELECT classID FROM Class WHERE classID = @classID)
        BEGIN
            IF NOT EXISTS(SELECT empID, classID FROM Employee_Class WHERE empID = @userID AND classID = @classID)    
                BEGIN
                    INSERT INTO Employee_Class(classID, empID)
                                    VALUES(@classID, @userID)
                    SET @result = 'Class Successfully Added'
                END
            ELSE
                SET @result = 'You already teach this class' 
        END
    ELSE
        SET @result = 'Class does not exist'
END

GO

CREATE PROCEDURE dbo.LecturerAddStudentGrade
@studentID VARCHAR(50),
@classID VARCHAR(50),
@mark INT,
@result VARCHAR(MAX) OUT
AS
BEGIN
    DECLARE @classModuleID INT;
    DECLARE @grade INT;
    SELECT @classModuleID = moduleID FROM Student_Module WHERE studentID = @studentID
    -- IF NOT EXISTS(SELECT caMark FROM Student_Module WHERE moduleID = @classModuleID AND studentID = @studentID)
    IF @grade < 0
        BEGIN
            SET @result = 'Grade cannot be a negative number'
        END
    ELSE IF @grade > 100
        BEGIN
            SET @result = 'Grade cannot be greater than 100'
        END
    ELSE
        BEGIN
            INSERT INTO Student_Module(studentID, moduleID, caMark) VALUES(@studentID, @classModuleID, @mark)
            SET @result = 'Added grade successfully'
        END
        
END

