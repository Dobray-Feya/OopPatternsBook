using BakeryApp.AbstractFactory.Products;

namespace BakeryApp.AbstractFactory.Pies
{
    public abstract class FunnyBakersPie
    {
        public abstract string Name { get; }

        public abstract IDough CreateDough();

        public abstract IFiller CreateFiller();

        public void Join()
        {
            Console.WriteLine("Начинка кладется внутрь пирога.");
        }

        public void Bake()
        {
            Console.WriteLine($"{Name} выпекается при температуре 200 градусов 30 минут.");
        }

        public void PutOnThePlate()
        {
            Console.WriteLine($"{Name} кладется на тарелку.");
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
