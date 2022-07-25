-- Exercise 1

-- 1.1
/*
SELECT CustomerID, CompanyName, Address, City, Region, PostalCode, Country
FROM Customers
WHERE City IN ('Paris', 'London');
*/

-- 1.2
/*
SELECT ProductName
FROM Products
WHERE QuantityPerUnit LIKE '%bottles%';
*/

-- 1.3
/*
SELECT pr.ProductName, su.CompanyName, su.Country
FROM Products pr
JOIN Suppliers su
	ON pr.SupplierID = su.SupplierID
WHERE QuantityPerUnit LIKE '%bottles%';
*/

-- 1.4
/*
SELECT CategoryName, COUNT(CategoryName)
FROM Categories ca
JOIN Products pro
	ON pro.CategoryID = ca.CategoryID
GROUP BY CategoryName
ORDER BY COUNT(CategoryName) DESC
*/

-- 1.5
/*
SELECT 
	TitleOfCourtesy + ' ' + FirstName + ' ' + LastName AS 'Full Name', 
	City
FROM Employees
WHERE Country = 'UK';
*/

-- 1.6
/*
SELECT COUNT(OrderID) AS "Heavy UK and US Orders"
FROM Orders
WHERE Freight > 100.00 AND ShipCountry IN ('USA', 'UK');
*/

-- 1.7
/*
SELECT *, (UnitPrice * Quantity) * Discount
FROM [Order Details]
WHERE (UnitPrice * Quantity) * Discount = (
SELECT MAX((UnitPrice * Quantity) * Discount)
FROM [Order Details]
)
*/

-- 1.8
SELECT 
	m.TitleOfCourtesy + ' ' + m.FirstName + ' ' + m.LastName AS 'Employee Name',
	e.TitleOfCourtesy + ' ' + e.FirstName + ' ' + e.LastName AS 'Reports To'
FROM Employees e
INNER JOIN Employees m ON m.ReportsTo = e.EmployeeID;