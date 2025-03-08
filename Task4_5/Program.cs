namespace Task4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());

            while
                (a < 20 || a > 60)
            {
                Console.WriteLine("введите число из диапазона [20; 60]");
                Console.ReadKey();
            }
            
            Console.ReadKey();
        }
    }
}
