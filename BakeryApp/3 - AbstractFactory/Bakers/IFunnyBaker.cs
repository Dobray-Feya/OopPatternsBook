using BakeryApp.AbstractFactory.Products;

namespace BakeryApp.AbstractFactory.Bakers
{
    public interface IFunnyBaker // Это и есть Абстрактная фабрика, "производящая" набор продуктов
    {
        IButterDough CreateButterDough();

        IPuffDough CreatePuffDough();

        IJam CreateJam();

        ICabbage CreateCabbage();

        IApple CreateApple();
    }
}
