using System;
using HomeworkProject.Interfaces;

namespace HomeworkProject.Models
{
    public class Staff : IObserver 
    {
        public string Name { get; }
        public Staff(string name)
        {
            Name = name;
        }
        public void Update(string message)
        {
            Console.WriteLine($"[SMS to staff]: {message}");
        }
    }
}
