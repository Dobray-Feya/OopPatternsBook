using IceCreamApp.IceCreamsTypes;

namespace IceCreamApp.Additives
{
    public class NutsAdditive : Additive
    {
        public NutsAdditive(IceCream iceCream) : base(iceCream)
        {
        }

        protected override string AdditiveName => "орешки";

        protected override int AdditiveCost => 20;
    }
}
