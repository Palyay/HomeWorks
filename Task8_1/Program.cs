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
                int s, r, p, d;
                int itog = CalculatePro(a, b, c);
                Console.WriteLine($"итог: {itog}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка оперции - введено не числовое значение");
            }
            Console.WriteLine("начало оперции");
        }

        static int CalculatePro(int a, int b, int c)
        {
            if (c == 1)
            {
                return a + b;
            }
            if (c == 2)
            {
                return a - b;
            }
            if (c == 3)
            {
                return a * b;
            }
            try
            {
                if (c == 4)
                {
                    return a / b;
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка оперции - деление на ноль");
            }
        }
    }
}

