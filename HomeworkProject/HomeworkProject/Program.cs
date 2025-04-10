using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Homework 3");

            Animal animal = new Animal("Generic Animal");
            animal.Speak();
            animal.Eat();

            Console.ReadLine();

        }
    }
}
