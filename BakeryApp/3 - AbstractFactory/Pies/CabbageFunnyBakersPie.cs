using BakeryApp.AbstractFactory.Bakers;
using BakeryApp.AbstractFactory.Products;

namespace BakeryApp.AbstractFactory.Pies
{
    public class CabbageFunnyBakersPie : FunnyBakersPie
    {
        private IFunnyBaker _baker;

        public CabbageFunnyBakersPie(IFunnyBaker baker)
        {
            _baker = baker;
        }

        public override string Name => "Пирожок с капустой";

        public override IDough CreateDough()
        {
            Console.WriteLine("Продукты смешиваются, тесто раскатывается 10-12 раз в пласт толщиной 0,7 - 1 см.");

            return _baker.CreatePuffDough();
        }

        public override IFiller CreateFiller()
        {
            Console.WriteLine("Капуста шинкуется и тушится на медленном огне 15 мин.");

            return _baker.CreateCabbage();
        }
    }
}
