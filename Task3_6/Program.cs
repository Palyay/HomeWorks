namespace Task3_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());//Вводится число. Вывести «Да», если оно четное, и «Нет» в противном случае.
            a = a % 2;
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