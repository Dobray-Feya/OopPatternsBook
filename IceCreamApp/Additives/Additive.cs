using IceCreamApp.IceCreamsTypes;

namespace IceCreamApp.Additives
{
    public abstract class Additive : IceCream
    {
        protected IceCream _iceCream;

        protected abstract string AdditiveName { get; }

        protected abstract int AdditiveCost { get; }

        public override int BallCost => _iceCream.BallCost; // Далее этот параметр не нужен, но его надо задать, т.к. исходный класс требует, чтобы он был задан

        protected Additive(IceCream iceCream) : base(iceCream.BallsCount)
        {
            _iceCream = iceCream;
        }

        public override string Name => _iceCream.Name + " + " + AdditiveName;

        public override int GetCost()
        {
            return _iceCream.GetCost() + AdditiveCost * BallsCount;
        }
    }
}
