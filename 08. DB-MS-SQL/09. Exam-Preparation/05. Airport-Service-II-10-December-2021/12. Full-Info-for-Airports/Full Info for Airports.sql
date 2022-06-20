CREATE PROC usp_SearchByAirportName(@airportName NVARCHAR(70))
AS
BEGIN
	SELECT a.AirportName, 
	p.FullName, 
	(CASE
		WHEN fd.TicketPrice < 400 THEN 'Low'
		WHEN fd.TicketPrice BETWEEN 401 AND 1500 THEN 'Medium'
		ELSE 'High'
		END) AS LevelOfTickerPrice,
	ac.Manufacturer, 
	ac.Condition, 
	at.TypeName 
	FROM Airports AS a
	JOIN FlightDestinations AS fd ON fd.AirportId = a.Id
	JOIN Passengers AS p ON fd.PassengerId = p.Id
	JOIN Aircraft AS ac ON ac.Id = fd.AircraftId
	JOIN AircraftTypes AS at ON at.Id = ac.TypeId
	WHERE a.AirportName LIKE @airportName
	ORDER BY ac.Manufacturer, p.FullName
END