namespace BakeryApp.FactoryMethod
{
    public abstract class GrannyCooking
    {
        public abstract GrannyPie CreatePie(string person);

        public GrannyPie OrderPie(string person)
        {
            var pie = CreatePie(person);

            pie.Bake();

            pie.PutOnThePlate();

            return pie;
        }
    }
}
