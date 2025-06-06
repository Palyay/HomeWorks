﻿using System.ComponentModel.Design;

namespace Task4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 + 1/2 + 1/3 + … + 1/n
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 1;
            for (int i = 2; i <= n; i++)
            {
                sum = sum + (1.0 / i);
            }
            Console.WriteLine(" Сумма 1+1/2+...+1/{0} равна {1}", n, sum);
            Console.ReadKey();
        }
    }
}