create function udf_GetVolunteersCountFromADepartment (@VolunteersDepartment varchar(30)) 
returns int  
as 

begin
	 DECLARE @result int
		set @result = (select count(*) from Volunteers where DepartmentId in (select id from VolunteersDepartments where DepartmentName=@VolunteersDepartment))
	 return @result 
end

--SELECT dbo.udf_GetVolunteersCountFromADepartment ('Education program assistant')