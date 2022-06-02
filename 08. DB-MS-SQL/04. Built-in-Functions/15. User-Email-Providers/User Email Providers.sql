SELECT UserName, SUBSTRING(Email, CHARINDEX('@', Email) + 1, LEN(Email))
	AS EmailProvider
	FROM Users
ORDER BY EmailProvider, UserName