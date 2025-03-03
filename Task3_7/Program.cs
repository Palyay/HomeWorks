namespace Task3_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());//Вводится число. Вывести «Да», если оно двухзначное, и «Нет» в противном случае.
            if (9 < a && a < 100)
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