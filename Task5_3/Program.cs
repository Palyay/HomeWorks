using System;

namespace Task5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 50]. Найти и вывести значение максимального, минимального элементов и их индексы
            const int n = 10;
            int[] array = new int[n];
            Random rnd = new Random();
            int max = 0;
            int min = 50;
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(0, 51);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            foreach (int a in array)
            {
                if (a > max)
                {
                    max = a;
                }
                if (a < min)
                {
                    min = a;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (array[i] == max)
                {
                    Console.WriteLine(" макс - {0}, индекс - {1} ", max, i);
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (array[i] == min)
                {
                    Console.WriteLine(" мин {0} - индекс - {1}", min, i);
                }
            }
            Console.ReadKey();
        }
    }
}