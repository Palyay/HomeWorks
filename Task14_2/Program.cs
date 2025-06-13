using System.Collections.Generic;

namespace Task14_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> warehouse = new Dictionary<string, int>();
            warehouse.Add("A001", 10);
            warehouse.Add("B205", 25);
            warehouse.Add("C307", 15);

            bool art1 = warehouse.ContainsKey("B205");
            Console.WriteLine($"Есть ли товар с артикулом B205 ? {art1}");

            warehouse["A001"] = 8;

            if (warehouse.TryGetValue("C307", out int n))
            {
                Console.WriteLine($"Количество наушников: {n}");
            }

            warehouse["B205"] += 5;

            warehouse.Remove("C307");

            Console.WriteLine("Текущий инвентарь:");
            foreach (KeyValuePair<string, int> value in warehouse)
            {
                Console.WriteLine($"Артикул: {value.Key}, Количество: {value.Value}");
            }

            string check = warehouse.Count > 0 ? "False" : "True";
            Console.WriteLine($"Инвентарь пуст? {check}");

            warehouse.Clear();
            Console.WriteLine($"Количество товаров после очистки: {warehouse.Count}");

            Console.ReadKey();
        }
    }
}
