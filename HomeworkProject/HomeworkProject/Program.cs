using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using HomeworkProject.Models;
using HomeworkProject.Interfaces;
using HomeworkProject.Repositories;

namespace HomeworkProject
{
    public class Program
    {
        private static IRepository<User> _userRepo = new InMemoryRepository<User>();
        public static void Main(string[] args)
        {
            AddUsers();
            PrintUsers("All users:");

            UpdateUser(1, "Alex - Updated");
            PrintUsers("All users after update:");

            DeleteUser(1);
            PrintUsers("All users after delete: ");
        }

        public static void AddUsers()
        {
            _userRepo.Add(new User { Name = "Alexandru Pogrebnicenco", Email = "alexandru.pogrebnicenco.intern@gmail.com" });
            _userRepo.Add(new User { Name = "Mihail Izmana", Email = "mihail.izmana@amdaris.com" });
        }

        private static void PrintUsers(string title)
        {
            Console.WriteLine(title);
            foreach (var user in _userRepo.FindAll())
            {
                Console.WriteLine($"Id: {user.Id} /  Name: {user.Name} / Email: {user.Email}");
            }
            Console.WriteLine();
        }

        private static void UpdateUser(int id, string newName)
        {
            var user = _userRepo.GetById(id);
            if (user != null) 
            {
                user.Name = newName;
                _userRepo.Update(user);
            }
        }

        private static void DeleteUser(int id)
        {
            var user = _userRepo.GetById(id);
            if (user != null)
            {
                _userRepo.Delete(user);
            }
        }

    }
}
