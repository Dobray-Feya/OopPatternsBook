using IceCreamApp.IceCreamsTypes;

namespace IceCreamApp.Additives
{
    public class ChocolateAdditive : Additive
    {
        public ChocolateAdditive(IceCream iceCream) : base(iceCream)
        {
        }

        protected override string AdditiveName => "шоколадная крошка";

        protected override int AdditiveCost => 25;
    }
}
