namespace Task7_1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("введите стороны 1-го тр.-ка");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            string warn = a > b + c ? "сторона 1-го тр.-ка должна быть меньше суммы двух других сторон" : b > a + c ? "сторона 1-го тр.-ка должна быть меньше суммы двух других сторон" : c > a + b ? "сторона 1-го тр.-ка должна быть меньше суммы двух других сторон" : "введите стороны 2-го тр.-ка";
            Console.WriteLine($"{warn}");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int c1 = Convert.ToInt32(Console.ReadLine());
            string warn1 = a1 > b1 + c1 ? "сторона 2-го тр.-ка должна быть меньше суммы двух других сторон" : b1 > a1 + c1 ? "сторона 2-го тр.-ка должна быть меньше суммы двух других сторон" : c1 > a1 + b1 ? "сторона 2-го тр.-ка должна быть меньше суммы двух других сторон" : " ";
            if (warn1 != " ")
            {
                Console.WriteLine($"{warn1}");
                Console.ReadKey();
            }
            else
            {
                double pltr = Square(a, b, c); // Вызов метода Square для 1-го тр.ка
                double pltr1 = Square(a1, b1, c1); // Вызов метода Square для 2-го тр.ка
                string result = pltr > pltr1 ? "площадь 1-го больше" : "площадь 2-го больше";
                Console.WriteLine($"площадь 1-го: {pltr:F}, площадь 2-го: {pltr1:F}, {result}");
            }

            //  Метод Герона для вычисления площади тр.-ка
            static double Square(int number1, int number2, int number3)
            {
                return Math.Sqrt(((number1 + number2 + number3) / 2) * (((number1 + number2 + number3) / 2) - number1) * (((number1 + number2 + number3) / 2) - number2) * (((number1 + number2 + number3) / 2) - number3));
            }
        }
    }
}