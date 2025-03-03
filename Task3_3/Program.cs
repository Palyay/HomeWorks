namespace Task3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int thirdNumber = Convert.ToInt32(Console.ReadLine());
            int fourthNumber = Convert.ToInt32(Console.ReadLine());
            int max = (firstNumber > secondNumber) ? firstNumber : secondNumber;
            int max1 = (max > thirdNumber) ? max : thirdNumber;
            int max2 = (max1 > fourthNumber) ? max1 : fourthNumber;
            Console.WriteLine("max - {0}", max2);
            Console.ReadKey();

        }
    }
}
