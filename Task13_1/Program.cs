using System.Diagnostics;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task13_1
{
    internal class Program
    {
        //  Делегат для преобразования элементов массива
        public delegate int Transformer(int number);// работает по типу делегата Func
        // Метод для возвращения преобразованого массива
        public static int[] Transform(int[] numbers, Transformer transformnumbers)
        {
            // Создаем массив нужного размера (например, длиной в 5 элементов)
            int[] result = new int[5];
            int i = 0;
            // Заполняем массив
            foreach (int number in numbers)
            {
                result[i] = transformnumbers(number);
                i++;
            }
            return result;
        }
        static void Main(string[] args)
        {
            // Использование на примере массива
            int[] numbers = new int[] { -1, 2, 3, -4, 5 };
            // Преобразование 1. Удвоение всех чисел
            int[] doublingNumbers = Transform(numbers, n => n * 2);
            Console.WriteLine(string.Join(", ", doublingNumbers));
            // Преобразование 2. Возведение в квадрат
            int[] squareNumbers = Transform(numbers, n => n * n);
            Console.WriteLine(string.Join(", ", squareNumbers));
            // Преобразование 3.Замена чисел на их модули
            int[] modulesNumbers = Transform(numbers, n => Math.Abs(n));
            Console.WriteLine(string.Join(", ", modulesNumbers));
            Console.ReadKey();
        }
    }
}