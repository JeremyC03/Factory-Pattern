using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class FoodFactory
    {
        public static IFood GetFood(string choice)
        {
            switch (choice.ToLower())
            {
                case "pancakes":
                case "chocolate chip pancakes":
                    return new ChocolateChipPancakes();
                case "sandwich":
                case "meatball sub":
                case "sub":
                    return new MeatballSubSandwich();
                case "steak":
                case "fillet mignon":
                    return new FilletMignonSteak();
                default:
                    return new MeatballSubSandwich();
            }
        }
    }
}
