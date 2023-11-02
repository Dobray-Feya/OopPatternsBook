using BakeryApp.AbstractFactory.Products;

namespace BakeryApp.AbstractFactory.Bakers
{
    public class AliceBaker : IFunnyBaker // Одна из конкретных фабрик
    {
        public IButterDough CreateButterDough()
        {
            Console.WriteLine("Алиса старательно смешивает продукты и вымешивает сладкое сдобное тесто.");

            return new ButterDough();
        }

        public IPuffDough CreatePuffDough()
        {
            Console.WriteLine("Алиса старательно смешивает продукты и раскатывает слоеное тесто.");

            return new PuffDough();
        }

        public IJam CreateJam()
        {
            Console.WriteLine("Алиса открывает банку с малиновым вареньем.");

            return new PaspberryJam();
        }

        public ICabbage CreateCabbage()
        {
            Console.WriteLine("Алиса аккуратно режет капусту и тушит ее на медленном огне 15 мин.");

            return new Cabbage();
        }

        public IApple CreateApple()
        {
            Console.WriteLine("Алиса моет, очищает от кожуры и аккуратно режет яблоки.");

            return new GreenApple();
        }
    }
}
