using System;
using HomeworkProject.Builders;
using HomeworkProject.Models;

namespace HomeworkProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t>>> Barista take your order <<<");
            RunCoffeeDemo();
            Console.WriteLine("\n---------------------------------------------------------------------------------\n");
        }

        private static void RunCoffeeDemo()
        {
            var builder = new CoffeeBuilder();
            var director = new CoffeeDirector(builder);

            var espresso = director.BuildEspresso();
            var cappuccino = director.BuildCappucino();
            var flatWhite = director.BuildFlatWhite();

            Console.WriteLine("Standard Espresso:");
            Console.WriteLine(espresso);
            Console.WriteLine("Standard Cuppucino:");
            Console.WriteLine(cappuccino);
            Console.WriteLine("Flat White:");
            Console.WriteLine(flatWhite);

            Coffee customEspresso = espresso.ToBuilder().AddExtraMilk(MilkType.Soy).AddSugar().Build();
            Console.WriteLine("Custom Espresso:");
            Console.WriteLine(customEspresso);

            Coffee customCappuccino = cappuccino.ToBuilder().AddSugar().AddSugar().Build();
            Console.WriteLine("Custom Cappucino:");
            Console.WriteLine(customCappuccino);

            Coffee customFlatWhite = flatWhite.ToBuilder().AddSugar().Build();
            Console.WriteLine("Custom Flat White:");
            Console.WriteLine(customFlatWhite);
        }
    }
}
