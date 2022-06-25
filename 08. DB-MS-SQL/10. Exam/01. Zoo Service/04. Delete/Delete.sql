update Animals 
set OwnerId=4 
where OwnerId is null;

delete 
from Volunteers 
where DepartmentId in(select id from VolunteersDepartments where DepartmentName= 'Education program assistant');


delete VolunteersDepartments 
where DepartmentName= 'Education program assistant';