namespace Task5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 10 случайных чисел из диапазона [-20, 20]. Определить количество положительных, отрицательных и равных нулю элементов
            const int n = 10;
            int[] array = new int[n];
            Random rnd = new Random();
            int poz = 0;
            int neg = 0;
            int nol = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(-20, 21);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            foreach (int a in array)
            {
                if (a == 0)
                {
                    nol = nol + 1;
                }
                else
                {
                    if (a < 0)
                        neg = neg + 1;
                    else
                    {
                        poz = poz + 1;
                    }
                }
            }
            Console.WriteLine("количество положительных {0}, количество отрицательных {1}, равных нулю элементов {2}", poz, neg, nol);
            Console.ReadKey();
        }
    }
}
