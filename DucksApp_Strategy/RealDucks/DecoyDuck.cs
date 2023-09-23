using DucksApp.Flying;
using DucksApp.Quacking;

namespace DucksApp.RealDucks
{
    internal class DecoyDuck : Duck
    {
        public override string Name => "охотничий манок";

        public DecoyDuck()
        {
            FlyingBehavior = new NoFly();

            QuackingBehavior = new NormalQuack(); // пусть тоже крякает
        }
    }
}