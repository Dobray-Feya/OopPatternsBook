using BakeryApp.AbstractFactory.Bakers;
using BakeryApp.AbstractFactory.Products;

namespace BakeryApp.AbstractFactory.Pies
{
    public class AppleFunnyBakersPie : FunnyBakersPie
    {
        private IFunnyBaker _baker;

        public AppleFunnyBakersPie(IFunnyBaker baker)
        {
            _baker = baker;
        }

        public override string Name => "Пирожок с яблоком";

        public override IDough CreateDough()
        {
            Console.WriteLine("Продукты смешиваются, тесто вымешивается и раскатывается в пласт толщиной 0,7 - 1 см.");

            return _baker.CreateButterDough();
        }

        public override IFiller CreateFiller()
        {
            Console.WriteLine("Яблоки очищаются от кожуры и режутся мелкими кусочками.");

            var apple = _baker.CreateApple();

            Console.WriteLine($"Начинка {apple.Name} готова.");

            return apple;
        }
    }
}
