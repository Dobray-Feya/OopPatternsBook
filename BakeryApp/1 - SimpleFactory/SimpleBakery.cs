namespace BakeryApp.SimpleFactory
{
    internal class SimpleBakery
    {
        public SimplePie OrderPie(string person)
        {
            var pie = SimpleFactory.CreatePie(person);

            pie.Bake();

            pie.Box();

            return pie;
        }
    }
}
