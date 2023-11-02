namespace BakeryApp.FactoryMethod
{
    public abstract class GrannyPie
    {
        public abstract string Name { get; }

        public virtual void Bake()  // Здесь реализация по умолчанию,
                                    // но для каких-то пирожков может быть собственная технология
        {
            Console.WriteLine($"Бабушка выпекает {Name} при температуре 200 градусов 30 минут.");
        }

        public void PutOnThePlate()
        {
            Console.WriteLine($"Бабушка кладет {Name} на тарелку.");
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
