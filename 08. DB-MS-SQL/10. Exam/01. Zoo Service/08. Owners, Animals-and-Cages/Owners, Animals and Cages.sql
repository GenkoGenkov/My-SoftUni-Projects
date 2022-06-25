select concat(O.Name,'-',a.Name)  as OwnersAnimals, o.PhoneNumber, ac.CageId  
from Animals as a
join AnimalTypes as at on a.AnimalTypeId=at.Id
join Owners  as o on a.OwnerId=o.Id
join AnimalsCages as ac on a.Id=ac.AnimalId
where at.AnimalType='mammals'
order by o.Name, a.Name desc