namespace Task3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            if (firstNumber > secondNumber)
            { Console.WriteLine(" {0} > {1}", firstNumber, secondNumber); }
            else
            {
                if (firstNumber < secondNumber)
                {
                    Console.WriteLine(" {0} < {1}", firstNumber, secondNumber);
                }
                else
                {
                    Console.WriteLine(" {0} = {1}", firstNumber, secondNumber);
                }
            }
        }
    }
}



