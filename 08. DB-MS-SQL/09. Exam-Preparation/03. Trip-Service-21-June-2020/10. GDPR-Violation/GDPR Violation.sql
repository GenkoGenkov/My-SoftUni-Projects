SELECT 
	TripId AS Id, 
	FirstName + ' ' + ISNULL(MiddleName + ' ', '') + LastName AS [Full Name],
	c.Name AS [From],
	hc.Name AS [To],
	CASE 
		WHEN CancelDate IS NULL THEN CONVERT(NVARCHAR, DATEDIFF(DAY,ArrivalDate, ReturnDate)) + ' ' + 'days'
		ELSE 'Canceled'
	END AS Duration
  FROM AccountsTrips AS at
  JOIN Accounts AS a ON a.Id = at.AccountId
  JOIN Cities AS c ON c.Id = a.CityId
  JOIN Trips AS t ON t.Id = at.TripId
  JOIN Rooms AS r ON r.Id = t.RoomId
  JOIN Hotels AS h ON h.Id = r.HotelId
  JOIN Cities AS hc ON hc.Id = h.CityId
ORDER BY [Full Name], TripId

