CREATE PROC usp_GetTownsStartingWith (@firstLetter NVARCHAR(50))
AS
SELECT Name
	FROM Towns
	WHERE Name LIKE @firstLetter + '%'