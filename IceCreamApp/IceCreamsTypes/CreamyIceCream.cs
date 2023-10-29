namespace IceCreamApp.IceCreamsTypes
{
    internal class CreamyIceCream : IceCream
    {
        public CreamyIceCream(int ballsCount) : base(ballsCount)
        {
        }

        public override int BallCost => 100;

        public override string Name => "Сливочное мороженое";
    }
}
