CREATE PROC usp_EmployeesBySalaryLevel (@levelOfSalary VARCHAR(20))
AS
SELECT FirstName,
	   LastName
	FROM Employees
WHERE dbo.ufn_GetSalaryLevel(Salary) = @levelOfSalary