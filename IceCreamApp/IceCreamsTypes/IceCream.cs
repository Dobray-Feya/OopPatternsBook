namespace IceCreamApp.IceCreamsTypes
{
    public abstract class IceCream
    {
        public int BallsCount { get; }
        public abstract int BallCost { get; }

        public abstract string Name { get; }

        public IceCream(int ballsCount)
        {
            BallsCount = ballsCount;
        }

        public virtual int GetCost()
        {
            return BallCost * BallsCount;
        }
    }
}
