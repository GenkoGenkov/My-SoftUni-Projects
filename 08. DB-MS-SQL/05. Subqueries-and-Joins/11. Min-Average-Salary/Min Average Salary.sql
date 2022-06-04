SELECT TOP(1) AVG(Salary) AS AverageSalary
	FROM Employees AS e
	JOIN Departments AS d ON d.DepartmentID = e.DepartmentID
	GROUP BY e.DepartmentID
ORDER BY AverageSalary
	
	
