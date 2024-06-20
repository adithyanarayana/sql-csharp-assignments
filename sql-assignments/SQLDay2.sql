--1. 
SELECT COUNT(ProductID) as 'No of Products'
FROM Production.Product

--2.
SELECT COUNT(ProductSubcategoryID) 
FROM Production.Product

--3. 
SELECT ProductSubcategoryID,COUNT(ProductID) as CountedProducts
FROM Production.Product
Group by ProductSubcategoryID

--4.
SELECT ProductSubcategoryID,COUNT(ProductID) as CountedProducts
FROM Production.Product
WHERE ProductSubcategoryID is NULL
Group by ProductSubcategoryID

--5. 
SELECT SUM(Quantity) as 'SUM of Products Quantity'
FROM Production.ProductInventory

--6.
SELECT ProductID, SUM(Quantity) as 'TheSum'
FROM Production.ProductInventory
Where LocationID = 40 
Group by ProductID
HAVING SUM(Quantity) <100

--7.
SELECT Shelf, ProductID, SUM(Quantity) as 'TheSum'
FROM Production.ProductInventory
Where LocationID = 40 and Shelf <> 'N/A'
Group by shelf,ProductID
HAVING SUM(Quantity) <100

--8.
SELECT AVG(Quantity) as 'TheAvg'
FROM Production.ProductInventory
Where LocationID = 10

--9.
SELECT ProductID, Shelf, AVG(Quantity) as 'TheAvg'
FROM Production.ProductInventory
Group by shelf,ProductID

--10.
SELECT ProductID, Shelf, AVG(Quantity) as 'TheAvg'
FROM Production.ProductInventory
Where Shelf <> 'N/A'
Group by shelf,ProductID

--11.
SELECT color, class, Count(Name) as 'TheCount', Avg(ListPrice) as 'AvgPrice'
FROM Production.Product
WHERE color is not NULL and class is not NULL
Group by Color, class

--12.
 Select CR.Name, SP.Name
 FROM person.CountryRegion CR Join person.StateProvince SP
 on CR.CountryRegionCode = SP.CountryRegionCode

 --13.
 Select CR.Name, SP.Name
 FROM person.CountryRegion CR Join person.StateProvince SP
 on CR.CountryRegionCode = SP.CountryRegionCode
 WHERE CR.Name in ('Germany', 'Canada')

 USE "Northwind"

 --14.
 SELECT DISTINCT p.ProductName
 FROM Orders o join [Order Details] as od on o.OrderID = od.OrderID Join Products p on p.productID = od.ProductID
 where o.OrderDate >= '1997-01-01'

 --15.
 SELECT TOP 5 c.PostalCode, count(orderID) as ProductsSold
 FROM orders o join customers c on o.CustomerID = c.CustomerID 
 where c.PostalCode is not null
 group by c.PostalCode
 Order by ProductsSold DESC

 --16.
 SELECT TOP 5 c.PostalCode, count(orderID) as ProductsSold
 FROM orders o join customers c on o.CustomerID = c.CustomerID 
 where c.PostalCode is not null and o.OrderDate > '1997-01-01'
 group by c.PostalCode
 Order by ProductsSold DESC

 --17.
 SELECT city, Count(CustomerID)
 FROM Customers
 GROUP BY City

--18.
SELECT city, Count(CustomerID)
FROM Customers
GROUP BY City
HAVING Count(CustomerID) > 2

--19.
SELECT DISTINCT  c.ContactName, o.OrderDate
FROM orders o join customers c on o.CustomerID = c.CustomerID
WHERE o.OrderDate > '1998-01-01'

--20.
SELECT DISTINCT  c.ContactName, MAX(o.OrderDate)
FROM orders o join customers c on o.CustomerID = c.CustomerID
group by c.ContactName

--21.
SELECT c.ContactName, COUNT(od.quantity) as 'ProductCount'
FROM orders o join customers c on o.CustomerID = c.CustomerID Join [Order Details] od on o.OrderID = od.OrderID
GROUP BY c.ContactName

--22.
SELECT c.CustomerID, COUNT(od.quantity) as 'ProductCount'
FROM orders o join customers c on o.CustomerID = c.CustomerID Join [Order Details] od on o.OrderID = od.OrderID
GROUP BY c.CustomerID
HAVING COUNT(od.quantity) > 100

--23.
SELECT s.CompanyName as 'Supplier Company Name', sp.CompanyName as 'Shipping Company Name'
FROM Suppliers s join Products p on s.SupplierID = p.SupplierID JOIN [Order Details] od on p.ProductID = od.ProductID JOIN orders o on od.OrderID = o.orderID join shippers sp on o.ShipVia = sp.ShipperID

--24.
SELECT  o.OrderDate, p.ProductName
FROM Orders o join [Order Details] as od on o.OrderID = od.OrderID Join Products p on p.productID = od.ProductID

--25.
SELECT  e1.FirstName + ' ' +e1.Lastname as Emp1, e2.FirstName + ' ' +e2.Lastname as Emp2, e1.Title
FROM Employees e1 join Employees e2 on e1.Title = e2.Title

--26.
--CEO: andre
--Manager: Nancy, Janet, Margaret, Steven, Laura\
--emp: Michael, Robert, Anne

SELECT e1.FirstName + ' ' + e1.LastName as 'Manager', COUNT(e2.reportsto)
FROM Employees e1  join Employees e2 on e1.EmployeeID=e2.ReportsTo
Group by e1.FirstName + ' ' + e1.LastName 
Having COUNT(e2.reportsto) >2


--27.
SELECT city, CompanyName, ContactName, 'customer' as [Type]
FROM Customers
Union ALL 
SELECT city, CompanyName, ContactName, 'Supplier' as [Type]
FROM Suppliers
