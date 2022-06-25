select top (5) o.Name, count(*)  as CountOfAnimals 
from Animals as a 
join Owners as o on a.OwnerId=o.Id 
group by o.Name 
order by count(*) desc;