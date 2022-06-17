SELECT c.Name AS City, COUNT(*) AS Hotels
	FROM Hotels AS h
	JOIN Cities AS c ON c.Id = h.CityId
	GROUP BY c.Name
ORDER BY Hotels DESC, c.Name ASC