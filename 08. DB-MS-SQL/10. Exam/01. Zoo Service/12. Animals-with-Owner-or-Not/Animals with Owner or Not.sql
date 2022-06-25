create procedure usp_AnimalsWithOwnersOrNot @AnimalName varchar(30)
as 
begin
	select a.Name, case when OwnerId is null then 'For adoption' else o.Name end as OwnersName from Animals a left join Owners o on a.OwnerId=o.Id where a.Name=@AnimalName
end 

--EXEC usp_AnimalsWithOwnersOrNot 'Pumpkinseed Sunfish'
--EXEC usp_AnimalsWithOwnersOrNot 'Hippo'