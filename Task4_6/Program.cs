namespace Task4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится n. Определить, является ли оно степенью 2-ки?
            int n = Convert.ToInt32(Console.ReadLine());
            int x = n;
            int i = 2;

            while (x == 2) ;
            {
                x = x / 2;
                i = ++i;
                Console.WriteLine(" 2^{0}={1}", i, n);
            }

            Console.ReadKey();
        }
    }
}