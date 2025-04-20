using System.Linq.Expressions;
using System.Reflection.Metadata;

namespace Task8_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите два целых числа");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите код оперции (1,2,3 или 4)");
                int c = Convert.ToInt32(Console.ReadLine());
                if (c < 1 || c > 4)
                {
                    Console.WriteLine("Ошибка оперции - неверный код оперции");
                    Console.ReadKey();
                }
                string itog = "Ошибка";
                Console.WriteLine("начало оперции");
                if (c == 1)
                {
                    itog = (a + b).ToString();
                }
                if (c == 2)
                {
                    itog = (a - b).ToString();
                }
                if (c == 3)
                {
                    itog = (a * b).ToString();
                }
                if (c == 4)
                {
                    try
                    {
                        itog = (a / b).ToString(); ;
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Ошибка оперции - деление на ноль");
                        Console.ReadKey();
                    }
                }
                Console.WriteLine($"итог: {itog}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка оперции - введено не числовое значение");
            }
        }
    }
}
