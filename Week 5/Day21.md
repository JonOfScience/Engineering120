# Day 21 - 25/07/2022 - SQL and Revision

## Catch-up @1130

##### When should we refactor
- If code is hard to understand then you should refactor
- Don't refactor just before deadline

##### What is a design pattern?
- Reusable solution to a common problem

##### What are the three categories of design patterns
- Creational
- Structural
- Behavioural

##### What is MVC?
- Model - Data
- View - Display
- Controller - Communicates with both Model and View

- Implements SRP

##### Describe to me the format of JSON
- Key : Value pairs

##### What is the purpose of XML and JSON?

- XML - Formatting
- JSON - Data Transmission

##### What is the difference between Asynchronous and Synchronous

- Async is when multiple processes can be used at the same time

##### What does the `using` block do?

- Provides scope and encapsulation for a resource
- Any resources we use implement the ```IDisposable```{.csharp} interface.

##### What are the five aggregate functions?

- `COUNT`, `AVG`, `SUM`, `MAX`, `MIN`

## SQL Queries - @1150

### Wildcards

- Find all customers whose names begin with 's'

```
SP_HELP Customers
```

```sql
SELECT ContactName
, CompanyName
, ContactTitle
FROM Customers
WHERE ContactName LIKE `S%`;

WHERE ContactName LIKE `[AEIOU]%`;
WHERE ContactName LIKE `[A-D]%`;
```

in MySQL would use `WHERE ContactName LIKE REGEXP [%s]`

### Aggregates

To get all units in stock
```sql
SELECT SUM(UnitsInStock) AS "Units in Stock"
FROM Products;
```

To get all units in stock disaggregated by category_id

```sql
SELECT category_id, SUM(UnitsInStock)
FROM Products
GROUP BY category_id;
```

**[LOOK INTO CAST, ROUND]
```sql
SELECT FirstName + ' ' + LastName AS 'Employee Name',
DATEDIFF(dd,BirthDate,GETDATE())/365.25 AS 'Age',
FLOOR(DATEDIFF(dd,BirthDate,GETDATE())/365.25) AS 'FLOOR',
CEILING(DATEDIFF(dd,BirthDate,GETDATE())/365.25) AS 'CEILING',
ROUND((DATEDIFF(dd,BirthDate,GETDATE())/365.25), 0) AS 'ROUND',
CAST((ROUND((DATEDIFF(dd,BirthDate,GETDATE())/365.25),2)) AS FLOAT) AS 'CAST'
FROM Employees
```
**

Must have anything in the `SELECT` also in the `GROUP BY`
```sql
SELECT SUM(UnitsInStock)
, CategoryID
, SupplierID
FROM Products
GROUP BY CategoryId, SupplierId;
```

`JOIN`across tables to get the CustomerID, CustomerName and the total number of orders they have placed
```sql
c.CustomerID
, c.ContactName
, COUNT(*) As "Total Orders"
FROM Customers c
INNER JOIN Orders o
ON c.CustomerId = o.CustomerID
GROUP BY c.CustomerID, c.ContactName
```

