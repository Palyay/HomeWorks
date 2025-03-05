namespace Task4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1*2*3*4*...*n
            int n = Convert.ToInt32(Console.ReadLine());
            int s = 1;

            for (int i = 1; i <= n; i++)
            {
                s = i*s;
            }
            Console.WriteLine("Факториал {0} равен {1}", n, s);
            Console.ReadKey();
        }
    }
}
