using BakeryApp.AbstractFactory.Bakers;
using BakeryApp.AbstractFactory.Pies;

namespace BakeryApp.AbstractFactory
{
    public class FannyBakersEast : FunnyBakersStore
    {
        public override FunnyBakersPie CreatePie(string pieName)
        {
            FunnyBakersPie pie;

            var baker = new AliceBaker(); //В Восточном филиале работает Алиса

            switch (pieName)
            {
                case "капуста":
                    pie = new CabbageFunnyBakersPie(baker);
                    break;
                case "яблоко":
                    pie = new AppleFunnyBakersPie(baker);
                    break;
                default:
                    pie = new JamFunnyBakersPie(baker);
                    break;
            }

            return pie;
        }
    }
}
