USE attendanceDatabase
GO
--############# Fully dependendent #############
--Table for the student roles
CREATE TABLE Student_Role (
	studentID VARCHAR(50) FOREIGN KEY REFERENCES Student(studentID),
	roleID INT FOREIGN KEY REFERENCES Roles(roleID)
)
--Table for the module the student does with their grade for the module
CREATE TABLE Student_Module (
	studentID VARCHAR(50) FOREIGN KEY REFERENCES Student(studentID),
	moduleID INT FOREIGN KEY REFERENCES Module(moduleID),
	caMark FLOAT
)
--Table for the module the exam is for
CREATE TABLE Exam_Module (
	examID INT FOREIGN KEY REFERENCES Exam(examID),
	moduleID INT FOREIGN KEY REFERENCES Module(moduleID)
)
--Table for student attendence to a class
CREATE TABLE Student_Attendance_Class (
	studentID VARCHAR(50) FOREIGN KEY REFERENCES Student(studentID),
	attendanceID INT FOREIGN KEY REFERENCES Attendance(attendanceID),
	classID INT FOREIGN KEY REFERENCES Class(classID),
	attendanceDate DATETIME
)
--Table for the employee roles
CREATE TABLE Employee_Role (
	empID VARCHAR(50) FOREIGN KEY REFERENCES Employee(empID),
	roleID INT FOREIGN KEY REFERENCES Roles(roleID)
)
--Table for classes employees instructors (Class Instructors) 
CREATE TABLE Employee_Class (
	empID VARCHAR(50) FOREIGN KEY REFERENCES Employee(empID),
	classID INT FOREIGN KEY REFERENCES Class(classID)
)
GO
-- Create views for user login information
CREATE VIEW studentLoginDetails AS
SELECT r.roleID, s.studentID, s.studentPassword FROM Student_Role AS r
INNER JOIN Student AS s
ON s.studentID = r.studentID
GO
CREATE VIEW employeeLoginDetails AS
SELECT r.roleID, e.empID, e.empPassword FROM Employee_Role AS r
INNER JOIN Employee AS e
ON e.empID = r.empID

-- View all current classes available for lecturers to choose 
CREATE VIEW classesAvailable AS
SELECT c.classID, CONCAT(c.className + ' ', ct.className) AS ClassName FROM ClassType AS ct
FULL JOIN Class AS c
ON c.classTypeID = ct.typeID
GO

SELECT * FROM [Module]
GO
CREATE VIEW classInstructors AS
SELECT ec.empID, c.classID, CONCAT(c.className + ' ', ct.className) AS ClassName FROM Employee_Class AS ec
Full join Class AS c
ON ec.classID = c.classID
FULL JOIN ClassType AS ct
ON c.classTypeID = ct.typeID
GO
GO
CREATE VIEW dbo.studentModules
AS
SELECT m.moduleID, sm.studentID, m.moduleName FROM Student_Module AS sm
FULL JOIN [Module] AS m
ON sm.moduleID = m.moduleID