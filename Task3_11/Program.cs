namespace Task3_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите участок застройки размером a * b метров");
            int a = Convert.ToInt32(Console.ReadLine());//Можно ли на прямоугольном участке застройки размером a * b метров разместить два дома размером в плане p * q и r * s метров? Дома можно располагать только параллельно сторонам участка. Дома могу стоять «вплотную» друг к другу.
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите первый дом размером в плане p * q метров");
            int p = Convert.ToInt32(Console.ReadLine());
            int q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите второй дом размером в плане r * s метров");
            int r = Convert.ToInt32(Console.ReadLine());
            int s = Convert.ToInt32(Console.ReadLine());
            int conf1 = (p + r);
            int conf2 = (p + s);
            int conf3 = (q + r);
            int conf4 = (q + s);
            if (((a >= conf1 || a >= conf2 || a >= conf3 || a >= conf4)) || ((b >= conf1 || b >= conf2 || b >= conf3 || b >= conf4)))
            {
                Console.WriteLine("можно разместить");
            }
            else
            {
                Console.WriteLine("нельзя разместить");
            }
        }
    }
}



