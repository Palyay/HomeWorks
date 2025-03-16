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
                double s = 0;
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = random.Next(0, 11);
                    s += array[i, j];
                    Console.Write("{0,4}", array[i, j]);
                }
                Console.WriteLine("{0,6:f2}", s / m);
            }
            Console.ReadKey();
        }
    }
}