CREATE OR ALTER procedure [dbo].[LoginUser] 
@userID varchar(50), 
@password varchar(50),
@role INT ,
@result VARCHAR(MAX) OUT 
as 
begin 
	set nocount on 
    IF @role = 1
        BEGIN
            IF EXISTS(SELECT * FROM studentLoginDetails WHERE studentID = @userID AND roleID = @role)
                BEGIN
                    if exists(select studentID, studentPassword from studentLoginDetails where studentID = @userID and studentPassword = @password)   
                        begin 
                            SET @result = 'Welcome Back ' + @userID; 
                            SELECT studentID FROM Student WHERE studentID = @userID
                        end 
                    else  
                        SET @result = 'Username or password invalid' 
                END
            ELSE
                SET @result = 'User does not exist'

        END
    ELSE
        BEGIN
            IF EXISTS(SELECT * FROM employeeLoginDetails WHERE empID = @userID AND roleID = @role)
                BEGIN
                    if exists(select empID, empPassword from employeeLoginDetails where empID = @userID and empPassword = @password)   
                        begin 
                            SET @result = 'Welcome Back ' + @userID; 
                            SELECT empID FROM Employee WHERE empID = @userID
                        end 
                    else  
                        SET @result = 'Username or password invalid' 
                END
            ELSE
                SET @result = 'User does not exist'

        END
end 