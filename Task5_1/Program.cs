namespace Task5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 100]. Определить, каких чисел больше – четных или нечетных
            const int n = 10;
            int[] array = new int[n];
            Random rnd = new Random();
            int s1 = 0;
            int s2 = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(0, 101);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            foreach (int a in array)
            {
                if (a % 2 == 0)
                {
                    s2 = s2 + 1;
                }
                else
                {
                    s1 = s1 + 1;
                }
            }
            if (s1 == s2)
                Console.WriteLine("50 / 50");
            else
            {
                {
                    if (s1 < s2)
                        Console.WriteLine("больше  четных");

                    else
                        Console.WriteLine("больше  нечетных");
                }

            }
            Console.ReadKey();
        }
    }
}
