using DucksApp.Flying;
using DucksApp.RealDucks;

namespace DucksApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var duck1 = new RedHeadDuck();
            duck1.Display();
            duck1.Swim();
            duck1.PerformQuack();
            duck1.PerformFly();
            Console.WriteLine();

            var duck2 = new DecoyDuck();
            duck2.Display();
            duck2.Swim();
            duck2.PerformQuack();
            duck2.PerformFly();
            Console.WriteLine();

            var duck3 = new RubberDuck();
            duck3.Display();
            duck3.Swim();
            duck3.PerformQuack();
            duck3.PerformFly();
            Console.WriteLine("Сменили поведение полета:");
            duck3.FlyingBehavior = new FlyRocketPowered();
            duck3.PerformFly();
        }
    }
}