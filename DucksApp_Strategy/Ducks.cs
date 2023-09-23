using DucksApp.Flying;
using DucksApp.Quacking;

namespace DucksApp
{
    internal abstract class Duck
    {
        public abstract string Name { get; }

        public FlyingBehavior FlyingBehavior { get; set; }        //   Вынесли изменяемую часть поведения в другой объект

        public QuackingBehavior QuackingBehavior { get; set; }     // Сеттер необязателен. Здесь он демонстрирует, что есть возможность
                                                                   // переопределить поведение во время исполнения программы.
                                                                   // Например, резиновая уточка, не умеющая летать, вдруг возьмет и улетит на ракете

        public void Display()                                      // Реализовали в самом классе неизменяемую часть поведения
        {
            Console.WriteLine("Это утка называется " + Name + ".");
        }

        public void Swim()
        {
            Console.WriteLine("Утка " + Name + " умеет плавать.");
        }

        public void PerformFly()                                   // Делегировали реализацию изменяемого поведения другому классу
        {
            FlyingBehavior.Fly();
        }

        public void PerformQuack()
        {
            QuackingBehavior.Quack();
        }

        public void SetFlyBehavior(FlyingBehavior flyingBehavior)
        {
            FlyingBehavior = flyingBehavior;
        }
    }
}
