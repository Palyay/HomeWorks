namespace Task4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 + 1/2 + 1/3 + … + 1/n
            int n = Convert.ToInt32(Console.ReadLine());
            double s = 1;

            for (int i = 1; i <= n; i++)
            {
                s = s + (1.0 / (i+1));
            }
            Console.WriteLine(" Сумма 1+1/2+...+1/{0} равна {1}", n, s);
            Console.ReadKey();
        }
    }
}
