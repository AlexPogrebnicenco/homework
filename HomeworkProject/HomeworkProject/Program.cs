using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkProject
{
    //    public class User
    //    {
    //        public int Id { get; set; }
    //        public string Name { get; set; }
    //        public int Age { get; set; }
    //        public string City { get; set; }
    //        public List<string> Skills { get; set; }
    //     }

    internal class Program
    {
        public class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public List<string> Roles { get; set; } // Вложенный список
        }

        public class Order
        {
            public int Id { get; set; }
            public int UserId { get; set; }
            public string Product { get; set; }
            public double Price { get; set; }
        }

        public class Customer
        {
            public int Id { get; set; }
            public string FullName { get; set; }
            public List<string> Tags { get; set; }
        }

        public class Purchase
        {
            public int Id { get; set; }
            public int CustomerId { get; set; }
            public string Item { get; set; }
            public double Cost { get; set; }
        }
        static void Main(string[] args)
        {
            var users = new List<User>
            {
                new User { Id = 1, Name = "Sasha", Roles = new List<string> { "Admin", "Manager" } },
                new User { Id = 2, Name = "Oleg", Roles = new List<string> { "User" } },
                new User { Id = 3, Name = "Maria", Roles = new List<string> { "Manager", "User" } },
                new User { Id = 4, Name = "Max", Roles = new List<string>() }
            };

            var orders = new List<Order>
            {
                new Order { Id = 1, UserId = 1, Product = "Laptop", Price = 1200 },
                new Order { Id = 2, UserId = 1, Product = "Mouse", Price = 25 },
                new Order { Id = 3, UserId = 2, Product = "Chair", Price = 150 },
                new Order { Id = 4, UserId = 3, Product = "Monitor", Price = 300 },
            };



            var noRoles = users.Where(u => u.Roles.Count() == 0).ToList();
            var withOrders = orders.Select(u => u.UserId).Distinct().ToList();
            var noOrders = users
                .Where(u => !withOrders.Contains(u.Id))
                .ToList();

            var all = users
                .Where(u => u.Roles.Count == 0 || !withOrders.Contains(u.Id)) .ToList();

            Console.WriteLine(noRoles);
            Console.ReadLine();

        }
    }
}

//var users = new List<User>
//{
//    new User { Id = 1, Name = "Alex", Age = 25, City = "Chisinau", Skills = new List<string>{ "C#", "SQL" } },
//    new User { Id = 2, Name = "Maria", Age = 31, City = "Balti", Skills = new List<string>{ "JavaScript", "HTML" } },
//    new User { Id = 3, Name = "Oleg", Age = 19, City = "Chisinau", Skills = new List<string>{ "Python" } },
//    new User { Id = 4, Name = "Sasha", Age = 27, City = "Tiraspol", Skills = new List<string>{ "C#", "React" } },
//    new User { Id = 5, Name = "Dima", Age = 22, City = "Chisinau", Skills = new List<string>{ "Java", "C++" } }
//};

//var old = users.Where(u => u.Age > 25).ToList();
//foreach (var user in old)
//{
//    Console.WriteLine($"User:{user.Name}, Age: {user.Age}");
//}

//Console.WriteLine("=================================================");
//var ch = users.Where(u => u.City == "Chisinau").ToList();
//var avg = ch.Average(u => u.Age);

//foreach (var u in ch)
//{
//    Console.WriteLine($"User:{u.Name}, Age: {u.Age}");
//}

//Console.WriteLine($"average : {avg}");
//Console.WriteLine("=================================================");

//var csharp = users.Where(u => u.Skills.Contains("C#")).ToList();
//foreach (var u in csharp)
//{
//    Console.WriteLine(u.Name);
//}

//var csharp = users.OrderByDescending(u => u.Age);
//foreach (var u in csharp)
//{
//    Console.WriteLine($"Name: {u.Name}, Age: {u.Age}");
//}

//var csharp = users.SelectMany(u => u.Skills).Distinct().ToList();
//Console.WriteLine(csharp);





//var manager = users
//    .Where(u => u.Roles.Contains("Manager"))
//    .Select(u => u.Name)
//    .ToList();
//Console.WriteLine(manager);

//var ord = orders
//    .Join(users,
//            order => order.Id,
//            user => user.Id,
//            (order,user) => new
//            {
//                UserName = user.Name,
//                Roles = string.Join(",", user.Roles),
//                Product = order.Product,
//                Price = order.Price
//            }).ToList();

//foreach (var item in ord)
//{
//    Console.WriteLine($"User: {item.UserName}, Roles: {item.Roles}, Product: {item.Product}, Price: {item.Price}");
//}



//var customers = new List<Customer>
//{
//    new Customer { Id = 1, FullName = "Anna Popescu", Tags = new List<string> { "VIP", "Subscribed" } },
//    new Customer { Id = 2, FullName = "Ion Rusu", Tags = new List<string> { "Guest" } },
//    new Customer { Id = 3, FullName = "Elena Toma", Tags = new List<string> { "Subscribed" } },
//    new Customer { Id = 4, FullName = "Victor Mihai", Tags = new List<string>() }
//};

//var purchases = new List<Purchase>
//{
//    new Purchase { Id = 1, CustomerId = 1, Item = "TV", Cost = 500 },
//    new Purchase { Id = 2, CustomerId = 1, Item = "Soundbar", Cost = 150 },
//    new Purchase { Id = 3, CustomerId = 2, Item = "Toaster", Cost = 40 },
//    new Purchase { Id = 4, CustomerId = 3, Item = "Laptop", Cost = 1000 },
//};


//var smth = customers.Join(
//    purchases,
//    customer => customer.Id,
//    purchase => purchase.CustomerId,
//    (customer, purchase) => new
//    {
//        Name = customer.FullName,
//        Taguri = string.Join(",", customer.Tags),
//        ItemName = purchase.Item,
//        Cost = purchase.Cost
//    }).ToList();

//foreach (var pr in smth)
//{
//    Console.WriteLine($"Name: {pr.Name}, Taguri: {pr.Taguri}, ItemName: {pr.ItemName}, Cost: {pr.Cost} ");
//}








