using BakeryApp.FactoryMethod.Pies;

namespace BakeryApp.FactoryMethod.GrannyCookings
{
    public class GrannyButterCooking : GrannyCooking
    {
        public override GrannyPie CreatePie(string person)
        {
            GrannyPie pie;

            switch (person)
            {
                case "папа":
                    pie = new CabbageButterPie();
                    break;
                case "мама":
                    pie = new AppleButterPie();
                    break;
                default:
                    pie = new CherryButterPie();
                    break;
            }

            return pie;
        }
    }
}
