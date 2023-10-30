using BakeryApp.SimpleFactory;

namespace BakeryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тестируем простую фабрику");

            var bakery = new SimpleBakery();

            var fatherOrder = bakery.OrderPie("папа");
            Console.WriteLine($"Папа заказал {fatherOrder}");

            var motherOrder = bakery.OrderPie("мама");
            Console.WriteLine($"Мама заказала {motherOrder}");

            var sonOrder = bakery.OrderPie("сын");
            Console.WriteLine($"Сын заказал {sonOrder}");

            var daughterOrder = bakery.OrderPie("дочь");
            Console.WriteLine($"Дочка заказала {daughterOrder}");
        }
    }
}