using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());//Вводится четырехзначное число
            int a = n / 1000;
            int b = (n / 100) % 10;
            int c = (n / 10) % 10;
            int d = n % 10;
            int n2 = c * 1000 + b * 100 + a * 10 + d;//Меняем местами 2-ую и 4-ую цифру
            Console.WriteLine(n2);
            Console.ReadKey();
        }
    }
}
