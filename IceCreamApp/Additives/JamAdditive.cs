using IceCreamApp.IceCreamsTypes;

namespace IceCreamApp.Additives
{
    public class JamAdditive : Additive
    {
        public JamAdditive(IceCream iceCream) : base(iceCream)
        {
        }

        protected override string AdditiveName => "варенье"; 
        
        protected override int AdditiveCost => 15;
    }
}
