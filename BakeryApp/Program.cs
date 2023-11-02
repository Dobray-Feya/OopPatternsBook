using BakeryApp.AbstractFactory;
using BakeryApp.AbstractFactory.Bakers;
using BakeryApp.AbstractFactory.Pies;
using BakeryApp.FactoryMethod.GrannyCookings;
using BakeryApp.SimpleFactory;

namespace BakeryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тестируем простую фабрику.");
            Console.WriteLine("Семья Ивановых пришла в кафе.");

            var bakery = new SimpleBakery();

            var fatherOrder = bakery.OrderPie("папа");
            Console.WriteLine($"Папа заказал {fatherOrder}.");

            var motherOrder = bakery.OrderPie("мама");
            Console.WriteLine($"Мама заказала {motherOrder}.");

            var sonOrder = bakery.OrderPie("сын");
            Console.WriteLine($"Сын заказал {sonOrder}.");

            var daughterOrder = bakery.OrderPie("дочь");
            Console.WriteLine($"Дочка заказала {daughterOrder}.");
            Console.WriteLine();

            Console.WriteLine("Тестируем фабричный метод.");
            Console.WriteLine("Теперь Ивановым печет пирожки бабушка.");
            Console.WriteLine("В понедельник пирожки из сдобного теста.");

            var mondayCooking = new GrannyButterCooking();

            var mondayFatherPie = mondayCooking.OrderPie("папа");
            Console.WriteLine($"Папа заказал {mondayFatherPie}.");

            var mondayMotherPie = mondayCooking.OrderPie("мама");
            Console.WriteLine($"Мама заказала {mondayMotherPie}.");

            var mondaySonPie = mondayCooking.OrderPie("сын");
            Console.WriteLine($"Сын заказал {mondaySonPie}.");

            var mondayDaughterPie = mondayCooking.OrderPie("дочка");
            Console.WriteLine($"Дочка заказала {mondayDaughterPie}.");
            Console.WriteLine();

            Console.WriteLine("Во вторник пирожки из слоеного теста.");
            Console.WriteLine("Мама и папа уехали в гости, поэтому пирожки только для детей..");

            var tuesdayCooking = new GrannyPuffCooking();

            var tuesdaySonPie = tuesdayCooking.OrderPie("сын");
            Console.WriteLine($"Сын заказал {tuesdaySonPie}.");

            var tuesdayDaughterPie = tuesdayCooking.OrderPie("дочка");
            Console.WriteLine($"Дочка заказала {tuesdayDaughterPie}.");
            Console.WriteLine();

            Console.WriteLine("В среду у бабушки испортилось настроение.");
            Console.WriteLine("Поэтому папа остался без пирожка...");

            var wednesdayCooking = new GrannyBadCooking();

            var wednesdayFatherPie = wednesdayCooking.OrderPie("папа");
            Console.WriteLine($"Папа получил {wednesdayFatherPie}.");

            var wednesdayMotherPie = wednesdayCooking.OrderPie("мама");
            Console.WriteLine($"Мама получила {wednesdayMotherPie}.");

            var wednesdaySonPie = wednesdayCooking.OrderPie("сын");
            Console.WriteLine($"Сын получил {wednesdaySonPie}.");

            var wednesdayDaughterPie = wednesdayCooking.OrderPie("дочка");
            Console.WriteLine($"Дочка получила {wednesdayDaughterPie}.");
            Console.WriteLine();

            Console.WriteLine("Через некоторое время Ивановы решили обраться в фирму FunnyBakers, " +
                "выпекающую пирожки по заказу.");
            Console.WriteLine("Каждый день к ним стала приходить представительница фирмы и печь пирожки, " +
                "руководствуясь строгой инструкцией FunnyBakers.");
            Console.WriteLine();

            Console.WriteLine("В понедельник пришла представительница Восточного филиала.");
            var branch1 = new FannyBakersEast();

            var fatherPie = branch1.OrderPie("капуста");
            Console.WriteLine($"Папа заказал {fatherPie}.");
            Console.WriteLine();

            var motherPie = branch1.OrderPie("яблоко");
            Console.WriteLine($"Мама заказала {motherPie}.");
            Console.WriteLine();

            var sonPie = branch1.OrderPie("джем");
            Console.WriteLine($"Сын заказал {sonPie}.");
            Console.WriteLine();

            Console.WriteLine("Во вторник пришла представительница Западного филиала.");
            var branch2 = new FannyBakersWest();

            fatherPie = branch2.OrderPie("капуста");
            Console.WriteLine($"Папа заказал {fatherPie}.");
            Console.WriteLine();

            motherPie = branch2.OrderPie("яблоко");
            Console.WriteLine($"Мама заказала {motherPie}.");
            Console.WriteLine();

            sonPie = branch2.OrderPie("джем");
            Console.WriteLine($"Сын заказал {sonPie}.");
            Console.WriteLine();

            Console.WriteLine("В среду пришла представительница Главного офиса.");
            var branch3 = new FannyBakersMain();

            fatherPie = branch3.OrderPie("капуста");
            Console.WriteLine($"Папа заказал {fatherPie}.");
            Console.WriteLine();

            motherPie = branch3.OrderPie("яблоко");
            Console.WriteLine($"Мама заказала {motherPie}.");
            Console.WriteLine();

            sonPie = branch3.OrderPie("джем");
            Console.WriteLine($"Сын заказал {sonPie}.");
            Console.WriteLine();
        }
    }
}