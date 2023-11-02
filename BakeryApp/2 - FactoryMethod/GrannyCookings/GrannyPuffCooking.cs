using BakeryApp.FactoryMethod.Pies;

namespace BakeryApp.FactoryMethod.GrannyCookings
{
    public class GrannyPuffCooking : GrannyCooking
    {
        public override GrannyPie CreatePie(string person)
        {
            GrannyPie pie;

            switch (person)
            {
                case "папа":
                    pie = new CabbagePuffPie();
                    break;
                case "мама":
                    pie = new ApplePuffPie();
                    break;
                default:
                    pie = new CherryPuffPie();
                    break;
            }

            return pie;
        }
    }
}
