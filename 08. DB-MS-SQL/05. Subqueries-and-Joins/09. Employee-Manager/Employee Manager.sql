SELECT emp.EmployeeID, emp.FirstName, mng.EmployeeID, mng.FirstName
	FROM Employees AS emp
	JOIN Employees AS mng ON mng.EmployeeID = emp.ManagerID
	WHERE mng.EmployeeID IN (3, 7)
ORDER BY emp.EmployeeID
	
	
