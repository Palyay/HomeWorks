using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task7_3
{
    internal class Program
    {
        static void Main()
        {
            // Используется значение по умолчаниюдля массива
            PrintNumbers(numbers);
            // Передается массив в обратном порядке
            PrintNumbers(numbers, true);

            const int n = 10;
            int[] numbers = new int[n];
            int[] reversNumbers = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                numbers[i] = rnd.Next(0, n + 1);
                Console.Write("{0} ", numbers[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < n / 2; i++)
            {
                int t = reversNumbers[i];
                reversNumbers[i] = reversNumbers[n - i - 1];
                reversNumbers[n - i - 1] = t;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", reversNumbers[i]);
            }

            //  Метод для вывода массива
            static void PrintNumbers(string[] reversNumbers, string[] numbers);
            {
                Console.WriteLine($"{numbers}, {reversNumbers}");
            }
                        Console.ReadKey();
        }
    }
}













