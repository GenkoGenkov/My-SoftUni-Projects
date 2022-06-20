SELECT p.FullName, COUNT(a.Id) AS CountOfAircraft, SUM(fd.TicketPrice) AS TotalPayed
	FROM Passengers AS p
	LEFT JOIN FlightDestinations AS fd ON fd.PassengerId = p.Id
	JOIN Aircraft AS a ON a.Id = fd.AircraftId
	GROUP BY p.FullName
	HAVING p.FullName LIKE '_a%' AND COUNT(a.Id) > 1
ORDER BY p.FullName
	