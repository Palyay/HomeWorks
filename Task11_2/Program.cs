namespace Task11_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                //создание массива, содержащего объекты обоих типов,
                IFlyable[] pilots = new IFlyable[]
                  {
                new Bird($"пятнадцать"),
                new Airplane($"семьсот", 75)
                 };
                // Демонстрация полиморфизма
                foreach (IFlyable pilot in pilots)
                {
                    pilot.Fly();
                }
            }
        }
        public interface IFlyable
        {
            public string Fly();
            public string MaxAltitude { get; }
        }
        public class Bird : IFlyable
        {
            public string MaxAltitude { get; }
            public string Fly() => $"Лечу на высоте {MaxAltitude} метров";
            Bird(string мaxAltitude)
            {
                MaxAltitude = мaxAltitude;
            }
        }
        public class Airplane : IFlyable
        {
            public string MaxAltitude { get; }
            public int CountPassengers { get; }
            Airplane(string мaxAltitude, int countPassengers)
            {
                CountPassengers = countPassengers;
                MaxAltitude = мaxAltitude;
            }
            public string Fly() => $"Лечу на высоте {MaxAltitude} метров. Везу {CountPassengers} пассажиров";
        }
    }
}

