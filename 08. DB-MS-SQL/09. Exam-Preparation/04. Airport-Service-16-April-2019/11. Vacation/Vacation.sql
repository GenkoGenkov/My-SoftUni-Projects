CREATE FUNCTION udf_CalculateTickets(@origin NVARCHAR(30), @destination NVARCHAR(30), @peopleCount INT) 
RETURNS NVARCHAR(40) 
AS
BEGIN

IF (@peopleCount <= 0) 
	BEGIN
		RETURN 'Invalid people count!'
	END

DECLARE @tripId INT = (SELECT f.Id FROM Flights AS f
					   JOIN Tickets AS t ON t.FlightId = f.Id
					   WHERE @origin = f.Origin AND @destination = f.Destination)
IF (@tripId IS NULL)
	BEGIN
		RETURN 'Invalid flight!'
	END
ELSE
	BEGIN
		DECLARE @TicketPrice DECIMAL(10,2);
		DECLARE @TotalPrice DECIMAL(10,2);
		
		SELECT @TicketPrice = Price FROM Flights AS f
		JOIN Tickets AS t ON t.FlightId = f.Id
		WHERE f.Origin = @origin AND f.Destination = @destination
		
		SET @TotalPrice = @TicketPrice * @peopleCount
		RETURN ('Total price ' + CAST(@TotalPrice AS NVARCHAR(50)))
	END
	RETURN ''
END