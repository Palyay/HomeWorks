namespace Task5_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 10 случайных чисел в диапазоне [-50, 50]. Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию. Вывести отсортированный таким образом массив на экран
            const int n = 10;
            const int m = n / 2;
            int[] array = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < m - 1; i++)
            {
                for (int j = i + 1; j < m; j++)
                {
                    if (array[i] > array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            for (int i = 0; i < m; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.ReadKey();
        }
    }
}