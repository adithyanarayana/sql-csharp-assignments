--1.
 SELECT City
 FROM Employees
 Where City in (SELECT CITY
 FROM Customers)

 --2.
 --a/ 
 SELECT DISTINCT City
 FROM Customers
 Where City not in (SELECT CITY
 FROM Employees)
 --b/
 SELECT DISTINCT c.City
 FROM Customers c  Join Orders o on c.CustomerID = o.CustomerID JOIN Employees e on o.EmployeeID=e.EmployeeID
 WHERE c.city <> e.City

 --3.
 SELECT p.ProductName, od.Quantity, od.OrderID
 FROM Products p JOIN [Order Details] od on p.ProductID = od.ProductID
order by p.ProductName, od.Quantity

--4.
 SELECT c.City, COUNT(o.orderID)
 FROM Customers c  Join Orders o on c.CustomerID = o.CustomerID
 GROUP BY C.city

 --5.
 --a/
SELECT City
FROM Customers
GROUP BY City
HAVING COUNT(*) >= 2

--b/
SELECT DISTINCT CITY 
 FROM Customers
 Where CITY in (
 SELECT City
 from customers 
 GROUP BY City
HAVING COUNT(*) >= 2
)



 --6.
SELECT c.city
FROM Customers c join orders o on c.CustomerID = o.CustomerID join [Order Details] od on od.OrderID = o.OrderID
GROUP BY c.city
HAVING COUNT(od.productID) >= 2   


--7.
SELECT distinct c.ContactName, c.City ,o.ShipCity
FROM Customers c FULL JOIN orders o on c.CustomerID = o.CustomerID
Where c.city <> o.shipcity

--8.
SELECT TOP 5 p.ProductName, AVG(p.UnitPrice) as 'AvgPrice', od.Quantity, c.city
FROM Products p JOIN [Order Details] od on p.ProductID = od.ProductID join orders o on o.OrderID = od.OrderID join customers c on c.CustomerID  = o.CustomerID
GROUP BY p.ProductName, c.city, od.Quantity
Order by od.Quantity DESC

--9.
--a/
SELECT e.City
from employees e
Where e.city not in(
select c.city
from customers c join orders o on c.CustomerID = o.CustomerID 
)

--b/
SELECT e.City
FROM Employees e LEFT JOIN Customers c ON e.City=c.City LEFT JOIN Orders o ON c.CustomerID=o.CustomerID
WHERE o.OrderID IS NULL
ORDER BY e.City


--10. List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, and also the city of most total quantity of products ordered from. (tip: join  sub-query)

--EMP sold most orders
WITH EmpOrders AS (
	SELECT e.city as 'Employeecity', COUNT(O.orderID) as 'OrdCount'
	FROM Employees e JOIN Orders o on e.EmployeeID = o.EmployeeID
	GROUP by e.city
	
),
--city w/ highest total quantity of products ordered
CityPQ AS (
	SELECT c.city as 'Customercity', SUM(od.quantity) as 'TotalQuantity'
	FROM Customers c join orders o on c.CustomerID = o.CustomerID join [Order Details] od on od.OrderID = o.OrderID 
	GROUP by c.City
	
)
SELECT TOP 1 eo.Employeecity
FROM EmpOrders eo JOIN CityPQ pq on eo.Employeecity = pq.Customercity
ORDER BY OrdCount DESC, TotalQuantity DESC


--11.
--1. using DISTINCT keyword 
--2. using ROW_NUMBER method 
--3. Passing Constraints like Primary key or UNIQUE while Table creation

