CREATE OR ALTER PROCEDURE dbo.classAvailability
@userID VARCHAR(50),
@classID INT,
@status BIT,
@result VARCHAR(MAX) OUT
AS
BEGIN
    IF @status = 1
        BEGIN
            IF EXISTS(SELECT * FROM classInstructors WHERE empID = @userID AND classID = @classID)
                BEGIN
                    IF NOT EXISTS(SELECT * FROM Class WHERE canAttend = 1 AND classID = @classID)
                        BEGIN
                            UPDATE Class SET canAttend = 1 WHERE classID = @classID
                            SET @result = 'Availability successfully changed to Available'
                        END
                    ELSE
                        SET @result = 'You have already made this class Available for attendance'
                END
            ELSE
                SET @result = 'You do not have access to this class.'
        END
    ELSE IF @status = 0
        BEGIN
            IF EXISTS(SELECT * FROM classInstructors WHERE empID = @userID AND classID = @classID)
                BEGIN
                    IF NOT EXISTS(SELECT * FROM Class WHERE canAttend = 0 AND classID = @classID)
                        BEGIN
                            UPDATE Class SET canAttend = 0 WHERE classID = @classID
                            SET @result = 'Availability successfully changed to Unavailable'
                        END
                    ELSE
                        SET @result = 'You have already made this class Unavailable for attendance'
                END
            ELSE
                SET @result = 'You do not have access to this class.'
        END
END

GO
-- These work
CREATE OR ALTER PROCEDURE dbo.classesTakenByStudent
@studentID VARCHAR(50)
AS
SELECT c.classID, sm.studentID ,m.moduleName, CONCAT(c.className + ' ', ct.className) AS className, c.canAttend
FROM Class AS c
INNER JOIN ClassType AS ct
ON c.classTypeID = ct.typeID
FULL JOIN Student_Module as sm
ON c.moduleID = sm.moduleID
FULL JOIN [Module] AS m
ON c.moduleID = m.moduleID
WHERE sm.studentID = @studentID
GO

CREATE OR ALTER PROCEDURE dbo.classesThatCanBeAttended
@studentID VARCHAR(50),
@moduleID INT
AS
SELECT c.classID, sm.studentID ,m.moduleName, CONCAT(c.className + ' ', ct.className) AS className, c.canAttend
FROM Class AS c
INNER JOIN ClassType AS ct
ON c.classTypeID = ct.typeID
FULL JOIN Student_Module as sm
ON c.moduleID = sm.moduleID
FULL JOIN [Module] AS m
ON c.moduleID = m.moduleID
WHERE sm.studentID = @studentID AND c.canAttend = 1 AND sm.moduleID = @moduleID


GO
CREATE PROCEDURE dbo.viewClassesYouTeach
@userID VARCHAR(50)
AS
BEGIN
SELECT ec.empID, c.classID, CONCAT(c.className + ' ', ct.className) AS ClassName FROM Employee_Class AS ec
Full join Class AS c
ON ec.classID = c.classID
FULL JOIN ClassType AS ct
ON c.classTypeID = ct.typeID
WHERE ec.empID = @userID
END


