select Name, BirthYear,AnimalType
from (select Name, format(BirthDate,'yyyy') as BirthYear, at.AnimalType,DATEDIFF(YEAR, BirthDate,'2022-01-01') v from Animals a,AnimalTypes at  
where a.AnimalTypeId=at.Id 
and OwnerId is null 
and at.AnimalType not in ('Birds'))a
where a.v<5
order by 1;