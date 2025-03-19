namespace Task5_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сформировать двумерный массив из 10 строк и 5 столбцов. Заполнить его случайными числами в диапазоне [0, 10]. Определить максимальный элемент в каждой строке
            const int n = 10;
            const int m = 5;
                        int[,] array = new int[n, m];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                int a = 0;
                int b = 0;
                int max = 0;
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = random.Next(0, 11);
                    a = array[i, j];
                    b = array[i++, j];
                    max = (a > b) ? max = a : max=b;
                    Console.Write("{0,4}", array[i, j]);
                }
                Console.WriteLine("{0,6}", max / m);
            }
            Console.ReadKey();
        }
    }
}