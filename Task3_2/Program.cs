namespace Task3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int thirdNumber = Convert.ToInt32(Console.ReadLine());
            int max = (firstNumber > secondNumber) ? firstNumber: secondNumber;
            int max1 = (max > thirdNumber) ? max : thirdNumber;
            Console.WriteLine(max1);
            Console.ReadKey();
        }
    }
}
