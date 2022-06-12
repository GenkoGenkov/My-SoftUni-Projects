SELECT c.FirstName + ' ' + c.LastName,
	   DATEDIFF(DAY, j.IssueDate, '04/24/2017') AS DaysGoing,
	   j.Status
	FROM Clients AS c
	JOIN Jobs AS j ON j.ClientId = c.ClientId
WHERE j.Status != 'Finished'
ORDER BY DaysGoing DESC, j.ClientId