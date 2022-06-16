SELECT 
	ISNULL(e.FirstName + ' ' +  e.LastName, 'None') AS Employee,
	ISNULL(dep.Name,'None') AS Department,
	cat.Name AS Category,
	r.Description, 
	FORMAT(r.OpenDate, 'dd.MM.yyyy') AS OpenDate,
	st.Label AS Status,
	ISNULL(u.Name, 'None') [User]

FROM Reports AS r
LEFT JOIN Employees AS e ON e.Id = r.EmployeeId
LEFT JOIN Categories AS cat ON cat.Id = r.CategoryId
LEFT JOIN Departments AS dep ON dep.Id = e.DepartmentId
LEFT JOIN [Status] AS st ON st.Id = r.StatusId
LEFT JOIN Users AS u ON u.Id = r.UserId
ORDER BY e.FirstName DESC, e.LastName DESC, dep.Name, cat.Name, r.Description, r.OpenDate, st.Label, u.Name