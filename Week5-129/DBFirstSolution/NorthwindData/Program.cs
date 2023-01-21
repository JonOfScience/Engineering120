using Microsoft.EntityFrameworkCore;
namespace NorthwindData;

internal class Program
{
    static void Main(string[] args)
    {
        // ** NuGet Packages Required **
        // Microsoft.EntityFrameworkCore
        // Microsoft.EntityFrameworkCore.SqlServer(Allows Entity Framework Core to be used with Microsoft SQL Server(including Azure SQL Database).
        // Microsoft.EntityFrameworkCore.Tools            

        // in PMC
        // Scaffold-DbContext 'Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False' Microsoft.EntityFrameworkCore.SqlServer

        // == null! the ! will disappear at compile time. The compiler just accepts null! to mean that it *won't* actually be null after instantiation

        // Scaffolding from a database using Entity Framework
        // https://docs.microsoft.com/en-us/ef/core/managing-schemas/scaffolding?tabs=vs

        // Partial classes can be defined across multiple files

        // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/nullable-value-types

        // Context class sits between the program and the DataBase - Represents an EndPoint for the DataBase
        //  Builds the relationships between the Tables so that we can use them.
        //  Uses DbSets https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbset-1?view=efcore-6.0

        // Add vs AsyncAdd? Use Cases

        using (var db = new NorthwindContext())
        {
            #region CRUD Functionality
            //// READ
            //foreach (var c in db.Customers)
            //{
            //    Console.WriteLine(c);
            //}
            //db.Customers.ToList().ForEach(c => Console.WriteLine(c));

            ////CREATE
            //var newCustomer = new Customer()
            //{
            //    CustomerId = "MAKSY",
            //    ContactName = "Maksym Lyskov",
            //    CompanyName = "SpartaGlobal"
            //};
            //db.Customers.Add(newCustomer);
            //db.SaveChanges();
            // https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.savechanges?view=efcore-6.0#microsoft-entityframeworkcore-dbcontext-savechanges

            ////UPDATE
            //var selectedCustomer = db.Customers.Find("MAKSY");
            //selectedCustomer.City = "Kyiv";
            //db.SaveChanges();

            // Generally, no database interaction will be performed until SaveChanges() is called.
            // 

            ////DELETE
            //var customerToDelete = db.Customers.Find("MAKSY");
            //db.Customers.Remove(customerToDelete);
            //db.SaveChanges();
            #endregion

            #region LINQ Queries and Lambda Lab
            // 1 Find the customers whose city is Paris or Tokyo.
            //var custList = db.Customers.Where(x => x.City == "Paris" || x.City == "Tokyo");
            //foreach (var c in custList)
            //{
            //    Console.WriteLine(c);
            //}

            // 2 Group UnitsInStock by SupplierId
            //var productsList = db.Products.GroupBy(x => x.SupplierId)
            //    .Select(x => new {SupplierID = x.Key, TotalUnits = x.Sum(p => p.UnitsInStock)});
            //foreach (var sid in productsList)
            //    Console.WriteLine($"{sid.SupplierID} {sid.TotalUnits}");

            // 3 Order Products by QuantityPerUnit (which by default will be in ascending order), then in descending order of ReorderLevel
            //var productsList = db.Products.OrderBy(x => x.QuantityPerUnit).ThenByDescending(x => x.ReorderLevel);
            //foreach (var product in productsList)
            //{
            //    Console.WriteLine($"{product.QuantityPerUnit} - {product.ReorderLevel}");
            //}
            #endregion


            // EAGER Loading without call
            //var ordersQuery =
            //    from order in db.Orders
            //    where order.Freight > 750
            //    select order;

            //// Without JOINing the tables objects will not be loaded into the model
            //// (e.g. Order has a Customer property, but it isn't populated with an actual object until it is JOINed)
            //// EAGER - You have to tell it to eagerly load the information, otherwise it is null
            //// LAZY - It knows when you are trying to load an object in and will make it available when you try to use it
            //// https://www.learnentityframeworkcore.com/lazy-loading

            //foreach (var order in ordersQuery)
            //{
            //    if(order.Customer != null)
            //    {
            //        Console.WriteLine($"{order.Customer.ContactName} from {order.Customer.City} paid {order.Freight} for shipping");
            //    }
            //}

            // EAGER Loading WITH call
            //var ordersQuery =
            //    from order in db.Orders.Include(o => o.Customer)
            //    where order.Freight > 750
            //    select order;

            //// Without JOINing the tables objects will not be loaded into the model
            //// (e.g. Order has a Customer property, but it isn't populated with an actual object until it is JOINed)
            //// EAGER - You have to tell it to eagerly load the information, otherwise it is null
            //// LAZY - It knows when you are trying to load an object in and will make it available when you try to use it
            //// https://docs.microsoft.com/en-us/ef/core/querying/related-data/eager

            //foreach (var order in ordersQuery)
            //{
            //    if (order.Customer != null)
            //    {
            //        Console.WriteLine($"{order.Customer.ContactName} from {order.Customer.City} paid {order.Freight} for shipping");
            //    }
            //}

            //var ordersMethod = db.Orders.Where(x => x.Freight > 750).Include(o => o.Customer);
            //foreach (var order in ordersQuery)
            //    Console.WriteLine($"{order.Customer.ContactName} from {order.Customer.City} paid {order.Freight} for shipping");

            //var ordersQuery2 = db.Orders
            //    .Include(o => o.Customer)
            //    .Include(o => o.OrderDetails)
            //    .ThenInclude(od => od.Product)
            //    .Where(o => o.Freight > 750);

            //foreach (var o in ordersQuery2)
            //{
            //    Console.WriteLine($"Order {o.OrderId} was made by {o.Customer.CompanyName}");
            //    foreach (var od in o.OrderDetails)
            //    {
            //        // Console.WriteLine($"\tProductID: {od.ProductId}");
            //        Console.WriteLine($"\tProduct Name: {od.Product.ProductName}");
            //    }
            //}

            //Two Approachs
            //Object Orented Approach - Using Classes (as above)
            
            //Relational Approach - Making tailored queries that return the information you want
            var ordersQueryRelational =
               from order in db.Orders
               join customer in db.Customers on order.CustomerId equals customer.CustomerId
               where order.Freight > 750
               // To use the information we create an anonymous object that includes the information we want (in a SELECT statament)
               select new
               {
                   OrderID = order.OrderId,
                   CustomerCompany = customer.CompanyName
               };

            foreach (var orderIDandCompanyName in ordersQueryRelational)
            {
                Console.WriteLine($"Order {orderIDandCompanyName.OrderID} was made by {orderIDandCompanyName.CustomerCompany}");
            }
        }
    }
}