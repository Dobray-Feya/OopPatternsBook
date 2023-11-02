using BakeryApp.AbstractFactory.Bakers;
using BakeryApp.AbstractFactory.Products;

namespace BakeryApp.AbstractFactory.Pies
{
    public class JamFunnyBakersPie : FunnyBakersPie
    {
        private IFunnyBaker _baker;

        public JamFunnyBakersPie(IFunnyBaker baker)
        {
            _baker = baker;
        }

        public override string Name => "Пирожок с вареньем";

        public override IDough CreateDough()
        {
            Console.WriteLine("Продукты смешиваются, тесто раскатывается 10-12 раз в пласт толщиной 0,7 - 1 см.");

            return _baker.CreatePuffDough();
        }

        public override IFiller CreateFiller()
        {
            var jam = _baker.CreateJam();

            Console.WriteLine($"Подготовлена начинка {jam.Name}.");

            return jam;
        }
    }
}
