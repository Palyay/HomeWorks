namespace Task7_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Пример вызова:
            Console.WriteLine(Multiply(2, 3)); // Вывод: 6
            Console.WriteLine(Multiply(2.5, 3.5)); // Вывод: 8.75
            Console.WriteLine(Multiply(5, 3.3));// Вывод: 16.5
        }
         //  Метод для вычисления произведения целых чисел
                static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        //  Метод для вычисления произведения дробных чисел
        static double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }
    }
}