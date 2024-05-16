namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our sandwich shop!");
            Console.WriteLine("Would you like a club sandwich or grilled cheese?");
            var userOrder = Console.ReadLine();

            IOrderable sandwich = SandwichFactory.MakeSandwiches(userOrder);
            sandwich.Description();
        }
    }
}
