namespace Task7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите длину ребра куба");
            double a = Convert.ToDouble(Console.ReadLine());
            // Переменные для хранения результатов
            double area;
            double vol;
            // Вызов метода
            CalcCube(a, out vol, out area);
            // Вывод результатов
            Console.WriteLine($"Объем куба: {vol}");
            Console.WriteLine($"Площадь поверхности куба: {area}");
        }
        //  Метод для вычисления объема и площади куба
        static void CalcCube(double a, out double v, out double s)
        {
            v = a * a * a; // Вычисляем объем
            s = a * a; // Вычисляем площадь
        }
    }
}
