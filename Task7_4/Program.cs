using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task7_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Пример вызова:
            int maxNumber = FindMax(10, 25, 5, 30, 15);
            Console.WriteLine($"Max number: {maxNumber}"); // Вывод: Max number: 30
        }
        // Метод который возвращает максимальное значение
        static int FindMax(params int[] numbers)
        {
            foreach (int a in numbers)
            {
                int max = 0;
                if (a > max)
                {
                    max = a;

                }
            }
        }
    }
}