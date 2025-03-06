namespace Task4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int st = a;
            if (a > 0) ;
            if (b > 0) ;
            {
                for (int i = 2; i <= b; i++)
                {
                    st = st * a;
                }
            }
            Console.WriteLine(" {0} в степени {1} равено {2}", a, b, st);
            Console.ReadKey();
        }
    }
}
