using System;
using HomeworkProject.Interfaces;

namespace HomeworkProject.Models
{
    public class Customer : IObserver
    {
        public string Name { get; }
        public Customer(string name)
        {
            Name = name;
        }
        public void Update(string message)
        {
            Console.WriteLine($"[Email to {Name}] : {message}");
        }
    }
}
