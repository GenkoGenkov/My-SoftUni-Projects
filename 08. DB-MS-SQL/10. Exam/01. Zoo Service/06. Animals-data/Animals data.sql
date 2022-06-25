select a.Name, at.AnimalType,FORMAT(a.BirthDate,'dd.MM.yyyy') as BirthDate 
from Animals as a
join AnimalTypes as at on a.AnimalTypeId=at.Id 
order by 1;