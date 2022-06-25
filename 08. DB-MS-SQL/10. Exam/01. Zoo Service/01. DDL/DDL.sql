create table Owners
(
Id int primary key Identity,
Name varchar(50) not null,
PhoneNumber varchar(15) not null,
[Address] varchar(50) 
)

create table AnimalTypes
(
Id int primary key Identity,
AnimalType varchar(30) not null,
)

create table Cages
(
Id int primary key Identity,
AnimalTypeId int NOT NULL FOREIGN KEY REFERENCES AnimalTypes(Id)
)


create table Animals
(
Id int primary key Identity,
Name varchar(30) not null,
BirthDate date not null,
OwnerId int FOREIGN KEY REFERENCES Owners(Id),
AnimalTypeId int NOT NULL FOREIGN KEY REFERENCES AnimalTypes(Id)
)


create table AnimalsCages
(
CageId INT NOT NULL FOREIGN KEY REFERENCES Cages(Id),
AnimalId int NOT NULL FOREIGN KEY REFERENCES Animals(Id),
PRIMARY KEY (CageId, AnimalId)
)

create table VolunteersDepartments
(
Id int primary key Identity,
DepartmentName varchar(30) not null
)

create table Volunteers
(
Id int primary key Identity,
Name varchar(50) not null,
PhoneNumber varchar(15) not null,
[Address] varchar(50),
AnimalId int FOREIGN KEY REFERENCES Animals(Id),
DepartmentId int NOT NULL FOREIGN KEY REFERENCES VolunteersDepartments(Id)
)