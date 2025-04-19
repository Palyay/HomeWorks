namespace Task8_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine("Начало оперции!");
                int d = a / b;
                Console.WriteLine(d);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.ReadKey();
        }
    }
}
