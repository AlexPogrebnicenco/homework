using System;
using HomeworkProject.Models;

namespace HomeworkProject.Builders
{
    public interface ICoffeeBuilder
    {
        ICoffeeBuilder SetCoffeeType(CoffeeType coffeeType);
        ICoffeeBuilder AddMilk(MilkType milkType);
        ICoffeeBuilder AddExtraMilk(MilkType milkType);
        ICoffeeBuilder AddSugar();
        Coffee Build();
    }
}
