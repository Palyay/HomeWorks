﻿namespace Task4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a>0, b>0. Найти a^b
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int st = a;

            for (int i = 2; i <= b; i++)
            {
                st = st * a;
            

            if (a <= 0) ;
            if (b <= 0) ;
            {
                break;
                Console.WriteLine(" Ошибка");
            }}
            Console.WriteLine(" {0} в степени {1} равено {2}", a, b, st);
            Console.ReadKey();
        }
    }
}
