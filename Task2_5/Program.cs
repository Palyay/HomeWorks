using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double l = Convert.ToDouble(Console.ReadLine());
            double d = Math.Floor (l);
            Console.WriteLine("Длина с округлением - {0}", d);
            Console.ReadKey();
        }
    }
}
