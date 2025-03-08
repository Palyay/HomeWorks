namespace Task4_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится n. Определить количество цифр в числе
            int n = Convert.ToInt32(Console.ReadLine());
            int x = n;
            int i = 0;

            do
            {
                x = x / 10;
                i = ++i;

            }
            while (x > 0);
            {
                Console.WriteLine(" количество цифр в числе {0}", i);
            }
            Console.ReadKey();
        }
    }
}
