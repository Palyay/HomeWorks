using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task7_3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("введите false или true: ");
            bool reverse = Convert.ToBoolean(Console.ReadLine());
            // Пример вызова:
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.Write("Вывод: ");
            PrintNumbers(numbers, reverse);
            Console.ReadKey();
        }
        static void PrintNumbers(int[] numbers, bool reverse= false)
        {
                if (reverse == true)
            {
                for (int i = 0; i < 5 / 2; i++)
                {
                    int t = numbers[i];
                    numbers[i] = numbers[5 - i - 1];
                    numbers[5 - i - 1] = t;
                }
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("{0} ", numbers[i]);                   
                }
            }
        }
    }
}














