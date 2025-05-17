namespace Task11_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //создание массива, содержащего объекты обоих типов,
            IFlyable[] pilots = new IFlyable[]
            {
                    new Bird($"пятнадцать"),
                    new Bird($"тридцать пять"),
                    new Airplane($"семьсот", 75),
                    new Airplane($"тысяча сто", 219)
            };
            // Демонстрация полиморфизма
            foreach (IFlyable pilot in pilots)
            {
                Console.WriteLine(pilot.Fly());
            }
            Console.ReadKey();
        }
        public interface IFlyable
        {
            string Fly();
            string MaxAltitude { get; }
        }
        public class Bird : IFlyable
        {
            public string MaxAltitude { get; }
            public string Fly()
            {
                return $"Лечу на высоте {MaxAltitude} метров";
            }

            public Bird(string мaxAltitude)
            {
                MaxAltitude = мaxAltitude;
            }
        }
        public class Airplane : IFlyable
        {
            public string MaxAltitude { get; }
            public int CountPassengers { get; }
            public Airplane(string мaxAltitude, int countPassengers)
            {
                CountPassengers = countPassengers;
                MaxAltitude = мaxAltitude;
            }
            public string Fly()
            {
                return $"Лечу на высоте {MaxAltitude} метров, везу {CountPassengers} пассажиров";
            }
        }
    }
}

