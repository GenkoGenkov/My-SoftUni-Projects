SELECT m.FirstName + ' ' + m.LastName,
	   AVG(DATEDIFF(DAY, IssueDate, FinishDate))
	FROM Mechanics AS m
	JOIN Jobs AS j ON j.MechanicId = m.MechanicId
	GROUP BY j.MechanicId, (m.FirstName + ' ' + m.LastName)
ORDER BY j.MechanicId