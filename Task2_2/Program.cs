using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите градусы - ");
            int gr = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите минуты - ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите секунды - ");
            int sec = Convert.ToInt32(Console.ReadLine());
            double vrad = (gr * Math.PI / 180) + (min * Math.PI / 180/60) + (sec * Math.PI / 180/60/60);
            Console.WriteLine("{0} рад,", vrad);
            Console.ReadKey();
        }
    }
}
