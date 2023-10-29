using IceCreamApp.IceCreamsTypes;
using IceCreamApp.Additives;

namespace IceCreamApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var order1 = new ChocolateIceCream(2);
            Console.WriteLine($"Маша заказала: {order1.Name} (порций: {order1.BallsCount}) за {order1.GetCost()} руб.");

            IceCream order2 = new ChocolateIceCream(1);
            order2 = new JamAdditive(order2);
            Console.WriteLine($"Лена заказала: {order2.Name} (порций: {order2.BallsCount}) за {order2.GetCost()} руб.");

            IceCream order3 = new CreamyIceCream(2);
            order3 = new NutsAdditive(order3);
            Console.WriteLine($"Варя заказала: {order3.Name} (порций: {order3.BallsCount}) за {order3.GetCost()} руб.");

            IceCream order4 = new CreamyIceCream(2);
            order4 = new NutsAdditive(order4);
            order4 = new ChocolateAdditive(order4);
            Console.WriteLine($"Женя заказала: {order4.Name} (порций: {order4.BallsCount}) за {order4.GetCost()} руб.");
        }
    }
}