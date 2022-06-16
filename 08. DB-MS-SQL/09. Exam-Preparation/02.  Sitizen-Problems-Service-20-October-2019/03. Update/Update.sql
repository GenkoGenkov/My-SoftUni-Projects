UPDATE Reports
SET CloseDate = DATEPART(year, GETDATE())
WHERE CloseDate IS NULL