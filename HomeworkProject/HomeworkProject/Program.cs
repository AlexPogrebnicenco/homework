using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkProject.Models;
using HomeworkProject.Delegates;
using HomeworkProject.Extensions;

namespace HomeworkProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            var users = GetUsers();
            ShowFiltredUsers(users);
        }

        static List<User> GetUsers() 
        {
            return new List<User>()
            {
                new User { Name = "Alex", Age = 27},
                new User { Name = "Dima", Age = 17},
                new User { Name = "Olga", Age = 43},
                new User { Name = "Stanislav", Age = 13}
            };
        }
        static bool IsAdult(User user) => user.Age > 18;

        static void ShowFiltredUsers(List<User> users)
        {
            var adultByDelegate = users.CustomFilter(IsAdult);
            var adultByAnonymous = users.CustomFilter(delegate(User u) { return u.Age > 18;});
            var adultByLambda = users.CustomFilter(u => u.Age > 18);
            var adultByLinq = users.Where(u => u.Age >18).ToList();
            var names = users.Select(u => u.Name).ToList();

            Console.WriteLine("Adult users:");
            foreach (var user in adultByLinq)
            {
                Console.WriteLine($"Name: {user.Name} / Age: {user.Age}");
            }

            Console.WriteLine($"All names: {string.Join(", ", names)}");
        }
    }
}
