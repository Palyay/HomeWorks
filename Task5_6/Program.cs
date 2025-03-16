namespace Task5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {//Сформировать двумерный массив вида
         //1 0 1 0 1
         //0 1 0 1 0
         //1 0 1 0 1
         //0 1 0 1 0
         //1 0 1 0 1
            const int n = 5;
            int[,] array = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = i == j ? 1 : 0;
                    Console.Write("{0} ", array[i, j]);
                }
                              Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}