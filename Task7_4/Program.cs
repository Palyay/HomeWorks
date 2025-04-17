using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task7_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Пример вызова:
            int maxNumber = FindMax(10, 25, 5, 30, 15);
            Console.WriteLine($"Max number: {maxNumber}");// Вывод: Max number
            int maxNumber1 = FindMax(10, 25, 5, 30, 15, 25, 48);
            Console.WriteLine($"Max number1: {maxNumber1}"); // Вывод: Max number1
        }
        // Метод который возвращает максимальное значение
        static int FindMax(params int[] numbers)
        {
            int max = 0;
            foreach (int n in numbers)
            {
                max = n > max ? n : max;
            }
            return max;
        }
    }
}