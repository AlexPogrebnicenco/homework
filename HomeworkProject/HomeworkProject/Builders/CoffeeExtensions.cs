using HomeworkProject.Models;

namespace HomeworkProject.Builders
{
    public static class CoffeeExtensions
    {
        public static CoffeeBuilder ToBuilder(this Coffee coffee)
        {
            return new CoffeeBuilder(coffee);
        }
    }
}
