using System.Threading.Channels;

namespace Task13_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public delegate void MyDelegate(string message);

    public class SmartHomeSystem(string Light, string Thermostat, string Door)
    {
        public event MyDelegate MyDelegate;
        string Light = "Light";
        string Thermostat = "Thermostat";
        string Door = "Door";

        public void TurnOnLight();
        

}
}


