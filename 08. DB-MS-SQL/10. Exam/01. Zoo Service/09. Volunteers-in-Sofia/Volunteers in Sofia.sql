SELECT [Name],[PhoneNumber],REPLACE(REPLACE([Address], 'Sofia', ''), ', ', '') AS [Address]
FROM [Volunteers] as [v]
JOIN [VolunteersDepartments] as [d] ON [v].[DepartmentId] = [d].[Id]
WHERE  ([Address] LIKE '%Sofia%') AND ([d].[DepartmentName] = 'Education program assistant' )  
ORDER BY [Name]