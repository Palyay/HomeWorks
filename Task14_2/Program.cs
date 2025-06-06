using System.Collections.Generic;

namespace Task14_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary <string, int > warehouse = new Dictionary<string, int>();
            warehouse.Add("A001", 10);
            warehouse.Add("B205", 25);
            warehouse.Add("C307", 15);

            bool art1 = warehouse.ContainsKey("B205");
            Console.WriteLine($"Есть ли товар с артикулом B205 ? {art1}");





            Console.WriteLine("Hello, World!");
            Console.ReadKey();
        }
    }
}
