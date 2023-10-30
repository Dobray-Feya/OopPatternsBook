namespace BakeryApp.SimpleFactory
{
    public abstract class SimplePie
    {
        public abstract string Name { get; }

        public void Bake()
        {
            Console.WriteLine($"{Name} выпекается при температуре 200 градусов 30 минут.");
        }

        public void Box()
        {
            Console.WriteLine($"{Name} кладется в фирменный бумажный пакет.");
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
