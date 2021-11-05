USE attendanceDatabase
GO
--############# Fully dependendent #############
--Table for the student roles
CREATE TABLE Student_Role (
	studentID INT FOREIGN KEY REFERENCES Student(studentID),
	roleID INT FOREIGN KEY REFERENCES Roles(roleID)
)
--Table for the module the student does with their grade for the module
CREATE TABLE Student_Module (
	studentID INT FOREIGN KEY REFERENCES Student(studentID),
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
	studentID INT FOREIGN KEY REFERENCES Student(studentID),
	attendanceID INT FOREIGN KEY REFERENCES Attendance(attendanceID),
	classID INT FOREIGN KEY REFERENCES Class(classID),
	attendanceDate DATETIME
)
--Table for the employee roles
CREATE TABLE Employee_Role (
	empID INT FOREIGN KEY REFERENCES Employee(empID),
	roleID INT FOREIGN KEY REFERENCES Roles(roleID)
)
--Table for classes employees instructors (Class Instructors) 
CREATE TABLE Employee_Class (
	empID INT FOREIGN KEY REFERENCES Employee(empID),
	classID INT FOREIGN KEY REFERENCES Class(classID)
)