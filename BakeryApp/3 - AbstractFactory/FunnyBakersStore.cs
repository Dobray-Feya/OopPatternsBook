using BakeryApp.AbstractFactory.Pies;

namespace BakeryApp.AbstractFactory
{
    public abstract class FunnyBakersStore // Здесь, как и раньше, используется Фабричный метод
    {
        public abstract FunnyBakersPie CreatePie(string pieName);

        public FunnyBakersPie OrderPie(string pieName)
        {
            var pie = CreatePie(pieName);

            pie.CreateDough();
            pie.CreateFiller();
            pie.Join();
            pie.Bake();
            pie.PutOnThePlate();

            return pie;
        }
    }
}
