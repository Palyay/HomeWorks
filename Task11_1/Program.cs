using System.Drawing;

namespace Task11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //создание массива, содержащего объекты обоих типов,
            Animal[] animals = new Animal[]
                       {
                new Dog(),
                new Cat()
                       };
            // Демонстрация полиморфизма
            foreach (Animal animal in animals)
            {
                animal.ShowInfo();
            }
        }
    }
    public abstract class Animal
    {
        public abstract string Name();
        public abstract string Say();
        public void ShowInfo()
        {
            Console.WriteLine($"Животное: {Name()}, Издает звук: {Say()}");
            Console.WriteLine();
        }
    }
    public class Dog : Animal
    {
        public override string Name() => "собака";
        public override string Say() => "Гав!";
    }
    public class Cat : Animal
    {
        public override string Name() => "кошка";
        public override string Say() => "Мяу!";
    }
}

