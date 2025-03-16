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
            int indMax = 0;
            int indMin = 0;
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
                    indMax = indMax + 1;                   
                }
                else
                {
                    indMax = indMax + 1;
                }
                Console.WriteLine(" макс {0}- индекс {1}", max, indMax);
            }
            
            foreach (int a in array)
            {
                if (a < min)
                {
                    min = a;
                    indMin = indMin + 1;                    
                }
                else
                {
                    indMin = indMin + 1;
                }
                Console.WriteLine(" мин {0} - индекс {1},", min, indMin);
            }
                       Console.ReadKey();
        }
    }
}