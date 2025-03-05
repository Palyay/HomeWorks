namespace Task3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());//Вводится число. Вывести «Да», если оно оканчивается на 0, и «Нет» в противном случае.
            a = a % 10;
            if (a == 0)
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
