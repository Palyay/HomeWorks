using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите первое число - ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите сторое число - ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите третье число - ");
            int c = Convert.ToInt32(Console.ReadLine());
            int a1 = c;
            int b1 = a;
            int c1 = b;
            Console.WriteLine("{0} , {1} , {2} ", a1, b1, c1);
            Console.ReadKey();
        }
    }
}
