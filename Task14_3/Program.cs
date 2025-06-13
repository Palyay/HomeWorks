namespace Task14_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> email = new HashSet<string>();
            email.Add("alice@example.com");
            email.Add("bob@example.com");
            email.Add("charlie@example.com");
            //Попытка добавления дубликата с выводом результата операции
            bool emailDublicate = email.Add("charlie@example.com");
            Console.WriteLine($"Добавлен дубликат charlie@example.com? - {emailDublicate}");
            //Проверка наличия подписчиков в системе
            Console.WriteLine($"Есть ли bob@example.com в подписчиках? - {email.Contains("bob@example.com")}");
            Console.WriteLine($"Есть ли dave@example.com в подписчиках? - {email.Contains("dave@example.com")}");
            //Создание второго множества для операций
            HashSet<string> newSubscribers = new HashSet<string>();
            newSubscribers.Add("bob@example.com");
            newSubscribers.Add("dave@example.com");
            newSubscribers.Add("eve@example.com");
            //Объединение множеств
            HashSet<string> allSubscribers = new HashSet<string>(email);
            allSubscribers.UnionWith(newSubscribers);
            Console.WriteLine("\nВсе подписчики после объединения");
            foreach (string id in allSubscribers)
            {
                Console.WriteLine(id);
            }
            // Поиск пересечения (общих подписчиков)
            HashSet<string> commonSubscribers = new HashSet<string>(email);
            commonSubscribers.IntersectWith(newSubscribers);
            Console.WriteLine("\nОбщие подписчики");
            foreach (string id in commonSubscribers)
            {
                Console.WriteLine(id);
            }
            // Удаление 
            bool testGroup1 = allSubscribers.Remove("charlie@example.com");
            Console.WriteLine($"\nУдалили charlie@example.com? {testGroup1}");
            Console.WriteLine($"Всего подписчиков: {allSubscribers.Count}");
            // Проверка на подмножество
            HashSet<string> testGroup = new HashSet<string> { ("bob@example.com"), ("eve@example.com") };
            Console.WriteLine($"\ntestGroup является подмножеством allSubscribers? {testGroup.IsSubsetOf(allSubscribers)}");
            //Очистка всей коллекции
            allSubscribers.Clear();
            Console.WriteLine($"\nПодписчиков после очистки: {allSubscribers.Count}");
            Console.ReadKey();
        }
    }
}
