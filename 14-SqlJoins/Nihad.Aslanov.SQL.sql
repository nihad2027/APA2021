create database Company

use Company

create table Countries(
Id int primary key identity,
Name nvarchar(20) not null
)

create table Cities(
Id int primary key identity,
Name nvarchar(50),
CountryId int foreign key references Countries(Id)
)

create table Employees(
Id int primary key identity,
[Name] nvarchar(25) not null,
Surname nvarchar(50) not null,
Age int,
Salary decimal(18,2),
Position nvarchar(50),
IsDeleted bit default 0,
CityId int foreign key references Cities(Id)
)

insert into Employees (Name,Surname,Age,Salary,Position,IsDeleted,CityId)
values
('Nihad','Aslanov',20,2500,'Developer',0,7),
('Eli','Quliyev',19,2000,'Reseption',0,8),
('Terlan','Veliyev',23,2200,'Manager',1,9)

select * from Employees
select e.Name ,e.Surname , city.Name as City , c.Name as Country from Employees e
Join Cities city 
on e.CityId = city.Id
Join Countries c 
on city.CountryId = c.Id

insert into Countries
values
('Azerbaijan'),
('Turkey'),
('USA')

select * from Employees
select e.Name ,c.Name as Country from Employees e
Join Cities city 
on e.CityId = city.Id
Join Countries c 
on city.CountryId = c.Id Where e.Salary > 2000

insert into Cities(Name,CountryId)
values
('Baku',1),
('Ganja',1),
('Istanbul',2),
('New York',3)

select * from Cities
select city.Name as City ,c.Name as Country from Cities city 
Join Countries c 
on city.CountryId = c.Id

select * from Employees
select e.Name ,e.Surname, e.Age, e.Salary, e.Position,e.IsDeleted, city.Name as City from Employees e
Join Cities city
on e.CityId = city.Id Where e.Position = 'Reseption'

select * from Employees 
select e.Name , e.Surname , city.Name as City , c.Name as City , c.Name as Country from Employees e
Join Cities city 
on e.CityId = city.Id
Join Countries c 
on city.CountryId = c.Id Where e.IsDeleted = 1