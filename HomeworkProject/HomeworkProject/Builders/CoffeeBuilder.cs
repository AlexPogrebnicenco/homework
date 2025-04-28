using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkProject.Models;

namespace HomeworkProject.Builders
{
    public class CoffeeBuilder : ICoffeeBuilder
    {
        private Coffee _coffee;

        public CoffeeBuilder()
        {
            _coffee = new Coffee();
        }

        public CoffeeBuilder(Coffee coffee)
        {
            _coffee = coffee;
        }

        public ICoffeeBuilder SetCoffeeType(CoffeeType coffeeType)
        {
            _coffee.CoffeeType = coffeeType;
            switch (coffeeType)
            {
                case CoffeeType.Espresso:
                    _coffee.BlackCoffeeShots = 1;
                    break;
                case CoffeeType.Cappuccino:
                    _coffee.BlackCoffeeShots = 1;
                    _coffee.Milk = MilkType.Regular;
                    break;
                case CoffeeType.FlatWhite:
                    _coffee.BlackCoffeeShots = 2;
                    _coffee.Milk = MilkType.Regular;
                    break;
            }
            return this;
        }
        public ICoffeeBuilder AddMilk(MilkType milkType)
        {
            if (!_coffee.Milk.HasValue)
            {
                _coffee.Milk = milkType;
            }
            else
            {
                _coffee.ExtraMilk.Add(milkType);
            }
            return this;
        }
        public ICoffeeBuilder AddExtraMilk(MilkType milkType)
        {
            _coffee.ExtraMilk.Add(milkType);
            return this;
        }
        public ICoffeeBuilder AddSugar()
        {
            _coffee.Sugar++;
            return this;
        }

        public Coffee Build()
        {
            var coffee = _coffee;
            _coffee = new Coffee();
            return coffee;
        }
    }
}
