using BakeryApp.AbstractFactory.Products;

namespace BakeryApp.AbstractFactory.Bakers
{
    public class ClaraBaker : IFunnyBaker // Одна из конкретных фабрик
    {
        public IButterDough CreateButterDough()
        {
            Console.WriteLine("Клара смешивает продукты и вымешивает сдобное тесто толщиной 2 см.");

            return new ButterDough();
        }

        public IPuffDough CreatePuffDough()
        {
            Console.WriteLine("Клара смешивает продукты и раскатывает слоеное тесто толщиной 3 мм.");

            return new PuffDough();
        }

        public IJam CreateJam()
        {
            Console.WriteLine("Клара открывает банку с апельсиновым вареньем.");

            return new OrangeJam();
        }

        public ICabbage CreateCabbage()
        {
            Console.WriteLine("Клара режет капусту на 4 части и тушит ее на максимальном огне 45 мин.");

            return new Cabbage();
        }

        public IApple CreateApple()
        {
            Console.WriteLine("Клара измельчает блендером яблоки.");

            return new RedApple();
        }
    }
}
