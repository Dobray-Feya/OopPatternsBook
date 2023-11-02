namespace BakeryApp.FactoryMethod.Pies
{
    public class BadPie : GrannyPie
    {
        public override string Name => "уголёк";

        public override void Bake()
        {
            Console.WriteLine($"Бабушка демонстративно хлопает дверцей духовки и выпекает пирожок при максимальной температуре 50 минут.");
        }
    }
}
