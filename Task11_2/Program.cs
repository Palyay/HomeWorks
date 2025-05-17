namespace Task11_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                //создание массива, содержащего объекты обоих типов,
                IFlyable[] animals = new IFlyable[]
                           {
                new Bird(),
                new Airplane()
                           };
                // Демонстрация полиморфизма
                foreach (IFlyable animal in animals)
                {
                    animal.Fly();
                }
            }
        }
        public interface IFlyable
        {
            public abstract string Fly();
            public string MaxAltitude { get; }
        }
        public class Bird : IFlyable
        {
            public string Fly() => $"Лечу на высоте {MaxAltitude} метров";
            Bird()
            {
                string мaxAltitude = $"пятнадцать";
            }
        }
        public class Airplane : IFlyable
        {
            public int CountPassengers();
            public string Fly() => $"Лечу на высоте {MaxAltitude} метров. Везу {CountPassengers()} пассажиров");

        }
    }