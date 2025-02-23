using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d = Convert.ToInt32(Console.ReadLine());
            double m = Math.Floor( d * 2.54*0.01);
            double cm = Math.Floor(d * 2.54*1);
            double mm = Math.Floor(d * 2.54*10);
            Console.WriteLine("{0}m, {1}cm, {2}mm", m, cm, mm);
            Console.ReadKey();
        }
    }
}
