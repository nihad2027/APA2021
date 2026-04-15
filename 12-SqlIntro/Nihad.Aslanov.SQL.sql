CREATE DATABASE Company

use Company

create table Employees(
  EmployeeID int,
  FirstName nvarchar(50),
  LastName nvarchar(50),
  Email varchar(255),
  PhoneNumber varchar (20),
  HireDate DATE,
  JobTitle nvarchar (100),
  Salary decimal(18 , 2),
  Department nvarchar(50)
 )

  insert into Employees(EmployeeId,FirstName,LastName,Email,PhoneNumber,HireDate,JobTitle,Salary,Department)
  values 
  (1,'Leyla','Hesenova','leylahesenova21@gmail.com','0507658240','2019-05-15','Junior Developer',2000,'IT'),
  (2,'Eli','Babayev','elibabayev23@gmail.com','0556787623','2008-12-23','System Admin',1200,'IT'),
  (3,'Aydan','Ceferova','aydanceferova5@gmail.com','0709880912','2007-08-07','Teacher',900,'Education'),
  (4,'Murad','Quliyev','murad@gmail.az','0504456765','2020-11-12','Accountant',2500,'Maliyye'),
  (5,'Vuqar','Eliyev','vuqareliyev35@gmail.com','0102345902','2023-06-01','IT Director',4500,'IT')

  --select * from Employees

  --select * from Employees Where Salary > 2000
  --select * from Employees Where Department = 'IT'
  --select * from Employees Order By Salary desc
  --select FirstName , Salary from Employees
  --select * from Employees Where HireDate > '2020-12-31'
  --select * from Employees Where Email Like '%gmail.az%'

  --select Max(Salary) as MaxSalary from Employees
  --select Min(Salary) as MinSalary from Employees
  --select Avg(Salary) as AvgSalary from Employees
  --select Count(*) as TotalEmployees from Employees
  --select Sum(Salary) as TotalSalarySum from Employees

  --select Department , Count(*) as EmployeeCount from Employees Group By Department
  --select Department , Avg(Salary) as AvgSalary from Employees Group By Department
  --select Department, Max(Salary) as MaxSalary from Employees Group By Department

  --update Employees Set Salary = 2800 Where EmployeeID = 1
  --update Employees Set Salary = Salary * 1.10 Where Department = 'IT'
  --update Employees Set JobTitle = 'HR Meneceri' Where FirstName = 'Leyla' and LastName = 'Hesenova'

  --Delete from Employees Where EmployeeID = 5
  --Delete from Employees Where Salary < 1500

  --select * from Employees Where FirstName Like '%a%'
  --select * from Employees Where Salary Between 2000 and 2500
  --select * from Employees Where Department In ('Maliyye', 'IT')


