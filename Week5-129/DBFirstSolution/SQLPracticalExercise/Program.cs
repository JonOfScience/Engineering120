using Microsoft.EntityFrameworkCore;
using NorthwindData;

namespace SQLPracticalExercise;

internal class Program
{
    static void Main(string[] args)
    {
        // Exercise 1 - Northwind Queries
        using (var db = new NorthwindContext())
        {
            // 1.1
            //var customersInCityOO = db.Customers.Where(x => (x.City == "Paris" || x.City == "London"));
            //foreach (var c in customersInCityOO)
            //    Console.WriteLine($"{c.CustomerId} {c.CompanyName} {c.Address} {c.City} {c.Country} {c.PostalCode}");

            //var customersInCityR =
            //   from customer in db.Customers
            //   where customer.City == "Paris" || customer.City == "London"
            //   select new
            //   {
            //       CustomerId = customer.CustomerId,
            //       CompanyName = customer.CompanyName,
            //       Address = customer.Address,
            //       City = customer.City,
            //       Country = customer.Country,
            //       PostalCode = customer.PostalCode,
            //   };

            //foreach (var idNameAndAddress in customersInCityR)
            //    Console.WriteLine($"{idNameAndAddress.CustomerId} {idNameAndAddress.CompanyName} {idNameAndAddress.Address} {idNameAndAddress.City} {idNameAndAddress.Country} {idNameAndAddress.PostalCode}");

            //1.2
            /*
            SELECT ProductName
            FROM Products
            WHERE QuantityPerUnit LIKE '%bottles%';
            */

            //var productsInBottlesOO = db.Products.Where(x => x.QuantityPerUnit.Contains("bottle"));
            //foreach (var p in productsInBottlesOO)
            //    Console.WriteLine($"{p.ProductName}");

            //var productsInBottlesR =
            //    from product in db.Products
            //    where product.QuantityPerUnit.Contains("bottle")
            //    select product;
            //productsInBottlesR.ToList().ForEach(p => Console.WriteLine(p.ProductName));


            // 1.3
            /*
            SELECT pr.ProductName, su.CompanyName, su.Country
            FROM Products pr
            JOIN Suppliers su
            ON pr.SupplierID = su.SupplierID
            WHERE QuantityPerUnit LIKE '%bottles%';
            */

            //var productsInBottlesOO = db.Products.Where(x => x.QuantityPerUnit.Contains("bottle")).Include(s => s.Supplier);
            //foreach (var p in productsInBottlesOO)
            //    Console.WriteLine($"{p.ProductName}, supplied by {p.Supplier.CompanyName} in {p.Supplier.Country}");

            //var productsInBottlesR =
            //    from product in db.Products
            //    join sup in db.Suppliers on product.SupplierId equals sup.SupplierId
            //    where product.QuantityPerUnit.Contains("bottles")
            //    select new
            //    {
            //        ProductName = product.ProductName,
            //        CompanyName = sup.CompanyName,
            //        Country = sup.Country
            //    };
            //productsInBottlesR.ToList().ForEach(p => Console.WriteLine($"{p.ProductName} {p.CompanyName} {p.Country}"));


            // 1.4
            /*
            SELECT CategoryName, COUNT(CategoryName)
            FROM Categories ca
            JOIN Products pro
                ON pro.CategoryID = ca.CategoryID
            GROUP BY CategoryName
            ORDER BY COUNT(CategoryName) DESC
            */

            //var productsInCategory00 = db.Products.Include(c => c.Category)
            //    .GroupBy(x => x.Category.CategoryName)
            //    .Select(x => new { CatName = x.Key, TotalItems = x.Count() })
            //    .OrderByDescending(x => x.TotalItems);
            //foreach (var pic in productsInCategory00)
            //{
            //    Console.WriteLine($"{pic.CatName} with {pic.TotalItems} products");
            //}

            var productsInCategoryR =
                from ca in db.Categories
                join pro in db.Products on ca.CategoryId equals pro.CategoryId
                group ca by ca.CategoryName into CategoryGroup
                orderby CategoryGroup.


            // 1.5
            /*
            SELECT 
                TitleOfCourtesy + ' ' + FirstName + ' ' + LastName AS 'Full Name', 
                City
            FROM Employees
            WHERE Country = 'UK';
            */

            //var allUKEmployees = db.Employees.Where(x => x.Country == "UK");
            //foreach (var aue in allUKEmployees)
            //{
            //    Console.WriteLine($"{aue.TitleOfCourtesy} {aue.FirstName} {aue.LastName} residing in {aue.City}");
            //}


            // 1.6
            /*
            SELECT COUNT(OrderID) AS "Heavy UK and US Orders"
            FROM Orders
            WHERE Freight > 100.00 AND ShipCountry IN ('USA', 'UK');
            */
            //var shippingLocs = new string[] { "UK", "USA" };
            //var heavyUSAndUKOrders = db.Orders.Where(x => (x.Freight > (decimal)100.00 && shippingLocs.Contains(x.ShipCountry))).Count();
            //Console.WriteLine( heavyUSAndUKOrders );


            // 1.7
            /*
            SELECT *, (UnitPrice * Quantity) * Discount
            FROM [Order Details]
            WHERE (UnitPrice * Quantity) * Discount = (
            SELECT MAX((UnitPrice * Quantity) * Discount)
            FROM [Order Details]
            )
            */


            // 1.8
            /*
                * SELECT 
            m.TitleOfCourtesy + ' ' + m.FirstName + ' ' + m.LastName AS 'Employee Name',
            e.TitleOfCourtesy + ' ' + e.FirstName + ' ' + e.LastName AS 'Reports To'
            FROM Employees e
            INNER JOIN Employees m ON m.ReportsTo = e.EmployeeID;
            */

            //var employeesAndBosses = db.Employees.AsQueryable().Join(db.Employees,
            //    employee => employee.ReportsTo,
            //    manager => manager.EmployeeId,
            //    (employee, manager) => new 
            //    { 
            //        EmployeeName = employee.TitleOfCourtesy + ' ' + employee.FirstName + ' ' + employee.LastName, ManagerName = manager.TitleOfCourtesy + ' ' + manager.FirstName + ' ' + manager.LastName
            //    }); 
            //foreach (var eab in employeesAndBosses)
            //{
            //    Console.WriteLine($"{eab.EmployeeName} reports to {eab.ManagerName}");
            //}
        }
    }
}