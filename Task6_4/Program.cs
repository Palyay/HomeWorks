using System.Collections.Generic;
using System.Text;

namespace Task6_4
{
    internal class Program
    {
        static void Main(string[] args)
        {//Запросите у пользователя имя, возраст и город. Сформируйте строку в формате: "Имя: [имя], Возраст: [возраст], Город: [город]" с использованием StringBuilder.
            Console.Write("Введите имя: ");
            string nam = Console.ReadLine();
            Console.Write("Введите возраст: ");
            string woz = Console.ReadLine();
            Console.Write("Введите город: ");
            string gor = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            result.Append("имя: ["+char.ToUpper(nam[0]) + nam.Substring(1) + "], " + "возраст: ["+ woz + "], " + "город: ["+char.ToUpper(gor[0]) + gor.Substring(1) +"]");
            Console.WriteLine("Результат:");
            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }
    }
}