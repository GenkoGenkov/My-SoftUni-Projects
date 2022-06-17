SELECT AccountId AS Id, Email, ac.Name AS City, COUNT(*) AS Trips
	FROM AccountsTrips AS at
	JOIN Accounts AS a ON a.Id = at.AccountId
	JOIN Cities AS ac ON ac.Id = a.CityId
	JOIN Trips AS t ON t.Id = at.TripId
	JOIN Rooms AS r ON r.Id = t.RoomId
	JOIN Hotels AS h ON h.Id = r.HotelId
	JOIN Cities hc ON hc.Id = h.CityId
WHERE hc.Id = ac.Id
GROUP BY AccountId, Email, ac.Name
ORDER BY Trips DESC, AccountId ASC

