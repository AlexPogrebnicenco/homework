using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkProject.Models;

namespace HomeworkProject.Builders
{
    public class CoffeeDirector
    {
        private readonly ICoffeeBuilder _builder;

        public CoffeeDirector(ICoffeeBuilder builder)
        {
            _builder = builder;
        }
        public Coffee BuildEspresso() 
        {
            return _builder
                .SetCoffeeType(CoffeeType.Espresso)
                .Build();
        }
        public Coffee BuildCappucino()
        {
            return _builder
                .SetCoffeeType(CoffeeType.Cappuccino)
                .Build();
        }
        public Coffee BuildFlatWhite() 
        {
            return _builder
                .SetCoffeeType(CoffeeType.FlatWhite)
                .Build();
        }
        
    }
}
