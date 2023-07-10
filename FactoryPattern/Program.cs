namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, please order what you would like from our menu.");
            Console.WriteLine("On our menu we have:\n Chocolate chip pancakes\n Meatball sub\n Fillet Mignon.\n");
            string input = Console.ReadLine();

            IFood meal = FoodFactory.GetFood(input);
            meal.Description();
        }
    }
}
