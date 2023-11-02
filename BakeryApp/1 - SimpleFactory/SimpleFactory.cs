using BakeryApp.SimpleFactory.Pies;

namespace BakeryApp.SimpleFactory
{
    internal class SimpleFactory
    {
        public static SimplePie CreatePie(string person)
        {
            SimplePie pie = null;

            switch (person)
            {
                case "папа":
                    pie = new FatherPie();
                    break;
                case "мама":
                    pie = new MotherPie();
                    break;
                default:
                    pie = new ChildPie();
                    break;
            }

            return pie;
        }
    }
}
