namespace Task3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int mediana;
            if (a > b && b > c)
            {
                mediana = b;
                Console.WriteLine("mediana= {0}", mediana);
            }
            if (a < b && b < c)
            {
                mediana = b;
                Console.WriteLine("mediana= {0}", mediana);
            }
            if (a < b && b > c)
            {
                mediana = (a > c) ? a : c;
                Console.WriteLine("mediana= {0}", mediana);
            }
            if (a > b && b < c)
            {
                mediana = (a < c) ? a : c;
                Console.WriteLine("mediana= {0}", mediana);
            }
        }
    }
}



