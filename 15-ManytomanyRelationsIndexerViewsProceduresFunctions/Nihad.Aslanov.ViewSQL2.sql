create database CompanyMM

use CompanyMM

create table Employees(
EmployeeId int primary key identity,
FirstName nvarchar(50) not null,
LastName nvarchar(50) not null,
BirthDate date,
Email nvarchar(100) unique,
constraint chk_BirthDate check (BirthDate > '1960 -07-17')
) 

create table Projects(
ProjectId int primary key identity,
ProjectName nvarchar(100) not null,
StartDate date not null,
EndDate date,
constraint chk_ProjectDates check (EndDate is null or EndDate >= StartDate)
)

create table EmployeeProjects(
EmployeeId int ,
ProjectId int ,
AssignedDate date default GetDate(),
primary key (EmployeeId,ProjectId),
foreign key (EmployeeId) references Employees(EmployeeId) on delete cascade,
foreign key (ProjectId) references Projects(ProjectId) on delete cascade
)

insert into Employees(FirstName,LastName,BirthDate,Email)
values
('Anar','Memmedov','1995-05-10','anar@gmail.com'),
('Leyla','Eliyeva','1998-03-22','leyla45@gmail.com'),
('Resad','Huseynov','1992-11-15','resad@company.com'),
('Fidan','Qasimova','2000-01-30','fidan123@gmail.com'),
('Emin','Sadiqov','1997-07-12','emin@company.com')

insert into Projects(ProjectName,StartDate,EndDate)
values
('E-Commerce Site','2024-01-01','2024-12-31'),
('Mobile App','2024-02-15',null),
('Database Migration','2024-03-01','2024-06-01')

insert into EmployeeProjects(EmployeeId,ProjectId) 
values
(1,1),(1,2),(1,3),
(2,1),
(3,2),
(4,3),
(5,3)

select e.FirstName,e.LastName,p.ProjectName from Employees as e
Join EmployeeProjects as ep on e.EmployeeId = ep.EmployeeId
Join Projects as p on ep.ProjectId = p.ProjectId 

select e.FirstName,e.LastName,
Count(ep.ProjectId) as ProjectCount from Employees as e
Join EmployeeProjects as ep on e.EmployeeId = ep.EmployeeId
Group By e.EmployeeId ,e.FirstName ,e.LastName 
Having Count(ProjectId) > 2

create view EmployeeProjectView
as 
select e.EmployeeId,
e.FirstName + ' ' + e.LastName as FullName,
p.ProjectId,p.ProjectName,ep.AssignedDate from Employees as e
Join EmployeeProjects as ep on e.EmployeeId = ep.EmployeeId
Join Projects as p on ep.ProjectId = p.ProjectId 

select * from EmployeeProjects Where EmployeeId = 1

create procedure sp_AssignEmployeeToProject 
@empId int,
@projId int 
as
begin
 if not exists (select 1 from EmployeeProjects Where EmployeeId = @empId and ProjectId = @projId)
   begin
     insert into EmployeeProjects (EmployeeId,ProjectId)
     values (@empId,@projId)
   end
end

create function fn_GetProjectCount(@empId int) 
returns int as
begin
   declare @p_count int
   select @p_count = Count(*) from EmployeeProjects Where EmployeeId = @empId
   return @p_count
end

select FirstName,LastName, dbo.fn_GetProjectCount(EmployeeId) as TotalProjects from Employees

exec sp_AssignEmployeeToProject @empId = 5, @projId = 1

delete from EmployeeProjects Where EmployeeId = 3

select * from EmployeeProjectView