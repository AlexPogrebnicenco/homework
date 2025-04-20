using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Xml.Linq;

namespace HomeworkProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var users = GetUsers();
            var orders = GetOrders();

            RunSequenceToSequence(users, orders);
            RunSequenceToScalar(users, orders);
            RunGeneration(users, orders);
        }

        static List<User> GetUsers() 
        {
            return new List<User> 
            {
                new User { Id = 1, Name = "Alex", Age = 27},
                new User { Id = 2, Name = "Oleg", Age = 45},
                new User { Id = 3, Name = "Maxim", Age = 15},
                new User { Id = 4, Name = "Dima", Age = 19},
                new User {Id = 5, Name = "Nikita", Age = 27}
            };
        }

        static List<Order> GetOrders() 
        {
            return new List<Order>
            {
                new Order { Id = 1, UserId = 1, Product = "BMW X6", ProductType = "auto" },
                new Order { Id = 2, UserId = 2, Product = "Audi A4", ProductType = "auto" },
                new Order { Id = 3, UserId = 1, Product = "Skoda Octavia", ProductType = "auto"},
                new Order { Id = 4, UserId = 3, Product = "Skoda Superb", ProductType = "auto"},
                new Order { Id = 5, UserId = 2, Product = "Lexus NX", ProductType = "auto"},
                new Order { Id = 6, UserId = 1, Product = "Ducati Monster", ProductType = "moto"}
            };
        }

        public static void RunSequenceToSequence(List<User> users, List<Order> orders)
        {
            Console.WriteLine("=== Sequence-to-Sequence ===");

            // 1. Where
            var adults = users.Where(u => u.Age > 18);
            Console.WriteLine("Users older than 18(Where):");
            foreach (var user in adults)
            {
                Console.WriteLine($" - Name: {user.Name}, Age: {user.Age}");
            }

            //2. Select
            var userNames = users.Select(u => u.Name);
            Console.WriteLine("User names(Select):");
            foreach (var nm in userNames)
            {
                Console.WriteLine($" - {nm}");
            }

            //3. Join
            var userOrders = users.Join(
                orders,
                user => user.Id,
                order => order.UserId,
                (user, order) => new { user.Name, order.Product });
            Console.WriteLine("Orders(Join):");
            foreach (var item in userOrders)
            {
                Console.WriteLine($" - {item.Name} ordered - {item.Product}");
            }

            //4. GroupBy
            // ===Query Syntax===
            //var grouped =
            //    from u in users
            //    group u by u.Age into ageGroup
            //    select ageGroup;

            //foreach ( var group in grouped)
            //{
            //    var names = string.Join(", ", group.Select(u => u.Name));
            //    Console.WriteLine($"Age {group.Key} : {names}");
            //}

            // Method Syntax 1
            //var grouped = users.GroupBy(u => u.Age);
            //Console.WriteLine("Grouped by Age(GroupBy):");
            //foreach (var group in grouped) 
            //{
            //    Console.WriteLine($"Age - {group.Key} : " + string.Join(", ", group.Select(u => u.Name)));
            //}

            // Method Syntax 2
            var grouped = users.GroupBy(u => u.Age)
                .Select(x => new {
                    Age = x.Key,
                    Count = x.Count(),
                    Name = x.Select(p => p.Name)
                }).ToList();
            Console.WriteLine("Grouped by Age(GroupBy):");
            foreach (var group in grouped)
            {
                Console.WriteLine($" - Age: {group.Age}, Count: {group.Count}: " + string.Join(", ", group.Name));
            }

            //5 Zip
            var indexed = users.Zip(
                Enumerable.Range(1, users.Count),
                (user, index) => new { user.Name, index, user.Age });
            Console.WriteLine("Zipped:");
            foreach (var item in indexed)
            {
                Console.WriteLine($" - {item.index}. {item.Name} (age {item.Age})");
            }

            //6 Skip + Take
            var middleUsers = users.Skip(1).Take(2);
            Console.WriteLine("Skip 1, Take 2:");
            foreach (var user in middleUsers)
            {
                Console.WriteLine($" - {user.Name}");
            }

            //7 SelectMany
            var allChars = users.SelectMany(u => u.Name.ToLower().ToCharArray());
            Console.WriteLine("Character frequencies in user names:");

            var charGroups = allChars.GroupBy(c => c).OrderBy(g => g.Key);
            foreach ( var group in charGroups)
            {
                Console.WriteLine($"'{group.Key}' appears {group.Count()} {(group.Count() > 1 ? "times" : "time")}");
            }

            //8 Distinct
            var uniqueAges = users.Select(u => u.Age).Distinct().ToList();
            Console.WriteLine("Unique ages(Distinct):" + string.Join(", ", uniqueAges));
        }

        public static void RunSequenceToScalar(List<User> users, List<Order> orders)
        {
            Console.WriteLine("=== Sequence-to-Scalar ===");

            var count = users.Count();
            Console.WriteLine($"Count of users: {count}");
            var maxAge = users.Max(u => u.Age);
            Console.WriteLine($"The oldest user: {maxAge}");
            var minAge = users.Min(u => u.Age);
            Console.WriteLine($"The youngest user: {minAge}");
            var totalAge = users.Sum(u => u.Age);
            Console.WriteLine($"Total age of all users: {totalAge}");
            var averAge = users.Average(u => u.Age);
            Console.WriteLine($"Users average age: {averAge}");

            var contain = users.Any(u => u.Name == "Maxim");
            Console.WriteLine($"Is there any user named Maxim in the users list? - {contain}");
            var all = users.All(u => u.Age < 100);
            Console.WriteLine($"Are all users younger than 100 years old? - {all}");

            var list1 = new List<int> { 1, 2, 3};
            var list2 = new List<int> { 1, 2, 3 };
            var sEqual = list1.SequenceEqual(list2);
            Console.WriteLine($"Is list1 equal to list2 ? - {sEqual}");

            var first = orders.FirstOrDefault();
            Console.WriteLine($"First order: {first.Product}");
            var last = orders.LastOrDefault();
            Console.WriteLine($"Last order: {last.Product}");
            var bmwx6 = orders.SingleOrDefault(o => o.Product == "BMW X6");
            Console.WriteLine($"Who ordered BMWX6 - UserId:{bmwx6.UserId}");
            var thirdOrder = orders.ElementAtOrDefault(3);
            Console.WriteLine($"Third order is: {thirdOrder.Product}");
        }    
        
        public static void RunGeneration(List<User> users, List<Order> orders)
        {
            Console.WriteLine("=== Generation Methods ===");

            var range = Enumerable.Range(1, 10);
            Console.WriteLine("Range (1-10):" + string.Join(", ", range));

            var repeated = Enumerable.Repeat("Hello", 3);
            Console.WriteLine("Repeat 'Hello': " + string.Join(" | ", repeated));

            var empty = Enumerable.Empty<string>();
            Console.WriteLine("Empty<string> has elements? - " + empty.Any());
        }       
    }
}
