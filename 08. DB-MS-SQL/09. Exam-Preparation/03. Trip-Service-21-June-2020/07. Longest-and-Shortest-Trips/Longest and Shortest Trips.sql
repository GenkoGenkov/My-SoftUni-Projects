SELECT AccountId, a.FirstName + ' ' + a.LastName AS FullName,
	   MAX(DATEDIFF(DAY, ArrivalDate, ReturnDate)) AS LongestTrip,
	   MIN(DATEDIFF(DAY, ArrivalDate, ReturnDate)) AS ShortestTrip
	FROM AccountsTrips AS at
	JOIN Accounts AS a ON a.Id = at.AccountId
	JOIN Trips AS t ON t.Id = at.TripId
	WHERE MiddleName IS NULL AND CancelDate IS NULL
GROUP BY AccountId, FirstName, LastName
ORDER BY LongestTrip DESC, ShortestTrip ASC
