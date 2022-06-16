SELECT Description, c.Name AS [Category Name] FROM Reports AS r
	JOIN Categories AS c ON r.CategoryId = c.Id
	WHERE CategoryId IS NOT NULL
	ORDER BY Description, c.Name