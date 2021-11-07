CREATE procedure [dbo].[LoginUser] 
@userID varchar(50), 
@password varchar(50),
@role INT ,
@result VARCHAR(MAX) OUT 
as 
begin 
	set nocount on 
    IF @role = 1
        BEGIN
            if exists(select studentID, studentPassword from Student where studentID = @userID and studentPassword = @password)   
                begin 
                    SET @result = 'Welcome Back ' + @userID; 
                    SELECT studentID FROM Student WHERE studentID = @userID
                end 
            else  
                SET @result = 'Username or password invalid' 
        END
    ELSE
        BEGIN
            if exists(select empID, empPassword from Employee where empID = @userID and empPassword = @password)   
                begin 
                    SET @result = 'Welcome Back ' + @userID; 
                    SELECT empID FROM Employee WHERE empID = @userID
                end 
            else  
                SET @result = 'Username or password invalid' 
        END
end 