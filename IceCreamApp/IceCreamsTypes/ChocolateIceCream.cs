namespace IceCreamApp.IceCreamsTypes
{
    internal class ChocolateIceCream : IceCream
    {
        public ChocolateIceCream(int ballsCount) : base(ballsCount)
        {
        }

        public override int BallCost => 120;

        public override string Name => "Шоколадное мороженое";
    }
}
