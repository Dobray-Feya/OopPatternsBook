using DucksApp.Flying;
using DucksApp.Quacking;

namespace DucksApp
{
    internal abstract class Duck
    {
        public abstract string Name { get; }

          /* Вынесли изменяемую часть поведения в другой объект
           * Сеттер необязателен. Здесь он демонстрирует, что есть возможность переопределить поведение во время исполнения программы.
           * Например, резиновая уточка, не умеющая летать, вдруг возьмет и улетит на ракете */
        public FlyingBehavior FlyingBehavior { get; set; }

        public QuackingBehavior QuackingBehavior { get; set; }

           /* Делегировали реализацию изменяемого поведения другому классу */
        public void PerformFly()
        {
            FlyingBehavior.Fly();
        }

        public void PerformQuack()
        {
            QuackingBehavior.Quack();
        }

        /* Реализовали в самом классе неизменяемую часть поведения */
        public void Display()
        {
            Console.WriteLine("Это утка называется " + Name + ".");
        }

        public void Swim()
        {
            Console.WriteLine("Утка " + Name + " умеет плавать.");
        }
    }
}
