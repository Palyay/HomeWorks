namespace Task4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {//a>0, b<0. Найти a^b.
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double st = a;
            double st1 = a;
            if (a > 0 && b < 0)
            {
                for (int i = 1; i <= -b; i++)
                {
                    st = 1.0 / (st1);
                    st1 = st1 * a;
                }
                Console.WriteLine(" {0} в степени {1} равено {2}", a, b, st);
            }
            else
                Console.WriteLine("ошибка");
            Console.ReadKey();
        }
    }
}
