using BakeryApp.FactoryMethod.Pies;

namespace BakeryApp.FactoryMethod.GrannyCookings
{
    public class GrannyBadCooking : GrannyCooking
    {
        public override GrannyPie CreatePie(string person)
        {
            GrannyPie pie;

            switch (person)
            {
                case "папа":
                    pie = new BadPie();
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
