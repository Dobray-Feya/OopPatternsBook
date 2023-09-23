using DucksApp.Flying;
using DucksApp.Quacking;

namespace DucksApp.RealDucks
{
    internal class RedHeadDuck : Duck
    {
        public override string Name => "красноголовка";

        public RedHeadDuck()
        {
            FlyingBehavior = new FlyWithWings();

            QuackingBehavior = new NormalQuack();
        }

    }
}