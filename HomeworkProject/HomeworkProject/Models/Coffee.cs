using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkProject.Models
{
    public class Coffee
    {
        public CoffeeType CoffeeType { get; set; }
        public int BlackCoffeeShots { get; set; } = 1;
        public MilkType? Milk {  get; set; }
        public List<MilkType> ExtraMilk { get; set; } = new List<MilkType>();
        public int Sugar {  get; set; }

        public override string ToString()
        {
            var description = new List<string>();
            description.Add($"{CoffeeType}");

            if ( BlackCoffeeShots > 0 )
            {
                description.Add($"{BlackCoffeeShots} shot(s) of black coffee");
            }
            if (Milk.HasValue) 
            {
                description.Add($"{Milk.Value} milk");
            }
            if (ExtraMilk.Count > 0)    
            {
                description.Add($"{string.Join(", ", ExtraMilk)} extra milk");
            }
            if (Sugar > 0) 
            {
                description.Add($"{Sugar} sugar(s)");
            }

            return "Recipe: " + string.Join(", ", description);
        }
    }
}
