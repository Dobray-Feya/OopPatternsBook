using BakeryApp.AbstractFactory.Products;

namespace BakeryApp.AbstractFactory.Bakers
{
    public class BettyBaker : IFunnyBaker // Одна из конкретных фабрик
    {
        public IButterDough CreateButterDough()
        {
            Console.WriteLine("Лиза смешивает продукты и вымешивает сдобное тесто.");

            return new ButterDough();
        }

        public IPuffDough CreatePuffDough()
        {
            Console.WriteLine("Лиза смешивает продукты и раскатывает слоеное тесто.");

            return new PuffDough();
        }

        public IJam CreateJam()
        {
            Console.WriteLine("Лиза открывает банку с вишневым вареньем.");

            return new CherryJam();
        }

        public ICabbage CreateCabbage()
        {
            Console.WriteLine("Лиза режет капусту и тушит ее на медленном огне 15 мин.");

            return new Cabbage();
        }

        public IApple CreateApple()
        {
            Console.WriteLine("Лиза моет и режет яблоки.");

            return new RedApple();
        }
    }
}
