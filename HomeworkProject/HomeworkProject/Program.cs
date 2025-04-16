using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkProject
{
    public class Program
    {
        static void Main(string[] args)
        {
           Plant grass = new Plant { Name = "Grass"};
            Herbivore antelope = new Herbivore();
            Predator<Herbivore> lion = new Predator<Herbivore>();

            antelope.Eat(grass);
            //antelope.Eat(lion);
            lion.Eat(antelope);

            Farmer farmer = new Farmer();
            farmer.Feed(lion, antelope);
            farmer.Feed(antelope, grass);

            farmer.Feed<Herbivore, Plant>(antelope);

            Mouse mouse = new Mouse();
            //farmer.Feed<Mouse, Cheese>(mouse);
            farmer.Feed<Mouse, Cheese>(mouse, new Cheese(""));


            Console.ReadLine();
            
        }

        public interface ILivingBeing
        {
            string Name { get; set; }
        }

        public class Cheese
        {
            public string Kind { get;}
            public Cheese(string kind)
            {
                Kind = kind;
            } 
        }

        public class Mouse : Animal<Cheese>
        {
        }

        public class Plant : ILivingBeing
        {
            public string Name { get; set; }
            public int Height { get; private set; }
            public void Grow()
            {
                Console.WriteLine("Growing");
                Height++;
            }

            public override string ToString()
            {
                return Name ?? "Unknown plant";
            }
        }

        public class Animal<K> : ILivingBeing where K : class
        {
            public string Name { get; set;}
            public int Weight { get; set; }
            public void Eat(K food)
            {
                Console.WriteLine($"Eating {food}");
            }
        }

        public class Herbivore : Animal<Plant>
        {
        }

        public class Predator<K> : Animal<K> where K : Herbivore
        { 
        }

        public class Farmer
        {
            public void Feed<T, K>(T animal, K food) where T : Animal<K> where K: class
            {
                Console.WriteLine($"Feeding {animal} with {food}");
            }

            public void Feed<T, K>(T animal) where T : Animal<K> where K : class, new()
            {
                Console.WriteLine("Preparing the food");
                K food = new K();
                Console.WriteLine($"Feeding {animal} with {food}");

            }
        }
    }
}
