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

            // Work with Animal 
            WorkWithAnimal();

            // Work with Lion
            var lion = WorkWirhLion();

            // Work with Elephant
            var elephant = WorkWithElephant();
  

            // Work with Zoo сделать Zoo1 который не наслед от IENumber
            var zoo = WorkWithZoo(lion, elephant);

            // Work with Monkey
            var monkey = WorkWithMonkey();

            // Work with Zoo1
            var zoo1 = WorkWithZoo1(lion, elephant);

            Console.ReadLine();

        }

        public static void WorkWithAnimal()
        {
            Console.WriteLine("Homework 3");
            Console.WriteLine("Main class ---- Animal: ");
            Animal animal = new Animal("Generic Animal");
            Console.WriteLine("The Animal name is: " + animal.Name);
            Console.WriteLine("Animal speaks: ");
            animal.Speak();
            Console.WriteLine("Animal eats: ");
            animal.Eat();
        }

        public static Elephant WorkWithElephant()
        {
            Console.WriteLine("Class Elephant ---- instance of Animal:");
            Elephant elephant = new Elephant("Edward");
            elephant.Speak();
            elephant.Eat();
            elephant.Speak("happy");

            return elephant;
        }

        public static Lion WorkWirhLion()
        {
            Console.WriteLine("Class Lion ---- instance of Animal:");
            Lion lion = new Lion("Simba");
            Console.WriteLine($"The Lions name is: {lion.Name}");
            Console.WriteLine("Lion speaks: ");
            lion.Speak();
            Console.WriteLine("Lion eats:");
            lion.Eat();

            return lion;
        }

        public static Zoo WorkWithZoo(Lion lion, Elephant elephant)
        {
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

            return zoo;
        }

        public static Monkey WorkWithMonkey() 
        {
            Console.WriteLine("------Work with Monkey with ICloneable:-------");
            Monkey monkey = new Monkey("Alex");

            Monkey ttMon = monkey;
            ttMon.Name = "first";
           
            Console.WriteLine("Original Monkey: ");
            monkey.Speak();
            monkey.Eat();
       
            Monkey clonedMonkey = (Monkey)monkey.Clone();
          
            Console.WriteLine("Cloned Monkey:");
            clonedMonkey.Name = "something";
            clonedMonkey.Speak();
            clonedMonkey.Eat();

            return monkey;
        }

        public static Zoo1 WorkWithZoo1(Lion lion, Elephant elephant)
        {
            Console.WriteLine("-----Working with Zoo1 with IEnumerable -----");
            Zoo1 zoo1 = new Zoo1();

            zoo1.AddAnimal(lion);
            zoo1.AddAnimal(elephant);
            zoo1.AddAnimal(new Lion("John"));

            foreach (var animalInZoo in zoo1)
            {
                Console.WriteLine($"{animalInZoo.Name} says:");
                animalInZoo.Speak();
            }

            return zoo1;
        }

    }
}
