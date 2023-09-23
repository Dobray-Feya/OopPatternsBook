namespace DucksApp.Flying
{
    internal class NoFly : FlyingBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Не умеет летать.");
        }
    }
}
