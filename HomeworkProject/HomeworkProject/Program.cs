using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Работа с классом Animal
            Console.WriteLine("Homework 3");
            Console.WriteLine("Main class ---- Animal: ");
            Animal animal = new Animal("Generic Animal");
            Console.WriteLine("The Animal name is: " + animal.Name);
            Console.WriteLine("Animal speaks: ");
            animal.Speak();
            Console.WriteLine("Animal eats: ");
            animal.Eat();

            // Работа с классом Lion
            Console.WriteLine("Class Lion ---- instance of Animal:");
            Lion lion = new Lion("Simba");
            Console.WriteLine($"The Lions name is: {lion.Name}");
            Console.WriteLine("Lion speaks: ");
            lion.Speak();
            Console.WriteLine("Lion eats:");
            lion.Eat();

            // Работа с классом Elephant
            Console.WriteLine("Class Elephant ---- instance of Animal:");
            Elephant elephant = new Elephant("Edward");
            elephant.Speak();
            elephant.Eat();
            elephant.Speak("happy");

            // Работа с классом Zoo
            Console.WriteLine("-----Working with Zoo with IEnumerable -----");
            Zoo zoo = new Zoo();
            zoo.AddAnimal(lion);
            zoo.AddAnimal(elephant);
            zoo.AddAnimal(new Lion("Mufasa"));


            foreach (var animalInZoo in zoo)
            {
                Console.WriteLine($"{animalInZoo.Name} says:");
                animalInZoo.Speak(); 
            }

            // Работа с классом Monkey
            Console.WriteLine("------Work with Monkey with ICloneable:-------");
            Monkey monkey = new Monkey("Alex");
            // Оригинал
            Console.WriteLine("Original Monkey: "); 
            monkey.Speak();
            monkey.Eat(); 
            // Клонирование
            Monkey clonedMonkey = (Monkey)monkey.Clone();
            // Клон
            Console.WriteLine("Cloned Monkey:");
            clonedMonkey.Speak();
            clonedMonkey.Eat();
            




            Console.ReadLine();

        }
    }
}
