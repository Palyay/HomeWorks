namespace Task14_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> values = new List<string>();
            values.Add("Иванов");
            values.Add("Петров");
            values.Add("Сидоров");

            values.Insert(1, "Козлов");
            Console.WriteLine();

            bool player = values.Contains("Петров");
            Console.WriteLine($"Есть ли игрок 'Петров' в команде? {player}");

            values.Remove("Сидоров");

            int ind1 = values.IndexOf("Козлов");
            Console.WriteLine($"Индекс игрока 'Козлов':{ind1}");

            values.Sort();

            Console.WriteLine("Текущий состав команды:");
            for (int i = 0; i < values.Count; i++)
            {
                Console.WriteLine($"{i} {values[i]}");
            }

            int players = values.Count;
            string count = players > 0 ? "False" : "True";
            {
                Console.WriteLine($"Команда пуста? {count}");
            }

            values.Clear();
            Console.WriteLine($"Количество игроков после очистки: {values.Count}");

            Console.ReadKey();
        }
    }
}
