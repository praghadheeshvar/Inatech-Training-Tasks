use Adventureworks
go

--Query 1
select FirstName,LastName,Title
from Person.Person where Title is not null

--Query 2
select FirstName,LastName
from Person.Person where FirstName like '%a%' and LastName like '%a%'

--Query 3
select scr.CurrencyCode,sc.Name
from Sales.Currency sc,Sales.CountryRegionCurrency scr

--Query 4
select * into hr_dept from HumanResources.Department

--Query 5
create table employee
(
sno int identity(1,1),
Name varchar(20),
Age int,
Gender varchar(1),
city varchar(20)
)
insert into employee values('Praggi',21,'M','Chennai')
insert into employee values('Prathibha',22,'F','Mysore')
insert into employee values('Sakthi',22,'M','Bangalore')
insert into employee values('Vigneshwar',22,'M','Arcot')
insert into employee values('Boomica',22,'F','Vellore')

select * from employee

--Query 6
select BusinessEntityID,AddressID
from HumanResources.Department dept inner join
Person.BusinessEntityAddress bea
on bea.BusinessEntityID=dept.DepartmentID
--select * from Person.Person
--select * from HumanResources.Department

--Query 7
select distinct(GroupName) as GN
from HumanResources.Department

--Query 8
select businessentityid,addresstypeid 
from humanresources.department dept
join Person.BusinessEntityAddress bea
on dept.DepartmentID = bea.AddressID

--Query 9

select DATEDIFF(year,StartDate,EndDate) as years
from HumanResources.EmployeeDepartmentHistory

--Query 10


--Query 11

select max(TaxRate) as Max_TaxRate
from Sales.SalesTaxRate

--Query 12

select dept.DepartmentID,emp.BusinessEntityID,edh.ShiftID,emp.BirthDate,year(getdate())-year(BirthDate) as age
from HumanResources.Employee emp join
HumanResources.Department dept on
emp.BusinessEntityID=dept.DepartmentID
join HumanResources.EmployeeDepartmentHistory edh
on emp.BusinessEntityID=edh.BusinessEntityID

--Query 13

create view Name_Age as
select dept.DepartmentID,emp.BusinessEntityID,edh.ShiftID,emp.BirthDate,year(getdate())-year(BirthDate) as age
from HumanResources.Employee emp join
HumanResources.Department dept on
emp.BusinessEntityID=dept.DepartmentID
join HumanResources.EmployeeDepartmentHistory edh
on emp.BusinessEntityID=edh.BusinessEntityID

select * from Name_Age

--Query 14

--Query 15

select max(Rate) Max_Rate,Name
from HumanResources.EmployeePayHistory pay join
HumanResources.Department dep
on pay.BusinessEntityID = dep.DepartmentID
group by Name

--Query 16

select pp.FirstName,pp.MiddleName,pp.Title,bea.AddressTypeID,bea.BusinessEntityID
from Person.Person pp left join Person.BusinessEntityAddress bea
on pp.BusinessEntityID=bea.BusinessEntityID where Title is not null

--Query 17

select ProductID,LocationID,Shelf
from Production.ProductInventory where ProductID between 300 and 350 
AND (LocationID=50 or Shelf='E')

--Query 18

select ppi.LocationID,ppi.Shelf,pl.Name
from Production.ProductInventory ppi join Production.Location pl
on ppi.LocationID=pl.LocationID

--Query 19

select sp.StateProvinceID,sp.StateProvinceCode,sp.CountryRegionCode,
ad.AddressID,ad.AddressLine1,ad.AddressLine2
from Person.StateProvince sp 
join Person.Address ad 
on sp.StateProvinceID=ad.StateProvinceID

--Query 20

select  CurrencyCode,Sum(SubTotal+TaxAmt) as total
from Sales.SalesOrderHeader so
join Sales.SalesTerritory st
on st.TerritoryID=so.TerritoryID
join Sales.CountryRegionCurrency cr
on cr.CountryRegionCode=st.CountryRegionCode
group by CurrencyCode


