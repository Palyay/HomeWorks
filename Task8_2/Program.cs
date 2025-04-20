namespace Task8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите возраст ");
                short a = Convert.ToInt16(Console.ReadLine());
                ValidateAge(a);
                Console.WriteLine($"{a} - Возраст введен корректно");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Ошибка: Слишком большой возраст");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Ошибка: Возраст не может быть отрицательным");
            }
            static void ValidateAge(short a)
            {
                if (a > 150)
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (a < 0)
                {
                    throw new ArgumentException();
                }
            }
        }
    }
}
