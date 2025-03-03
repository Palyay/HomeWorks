namespace Task3_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());//Вводится число. Вывести «Да», если оно попадает в диапазон ( до -10, от 10), и «Нет» в противном случае.
            if (!(-10 <= a && a <= 10))
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Нет");
            }
        }
    }
}