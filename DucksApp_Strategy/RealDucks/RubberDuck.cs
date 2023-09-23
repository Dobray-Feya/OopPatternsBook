using DucksApp.Flying;
using DucksApp.Quacking;

namespace DucksApp.RealDucks
{
    internal class RubberDuck : Duck
    {
        public override string Name => "резиновая уточка";

        public RubberDuck()
        {
            FlyingBehavior = new NoFly();

            QuackingBehavior = new Squeak();
        }
    }
}
