namespace Task8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите возраст ");
            short a = Convert.ToByte(Console.ReadLine());
            ushort b = Convert.ToUInt16(Console.ReadLine());
            ValidateAge(a); 
            ValidateAge(b);                       
        }
        static void ValidateAge(short a)
        {
            try
            {
                if (a < 0)
                {
                    Console.WriteLine(a);
                }
            }

            //< 0 - выбросить ArgumentException("Возраст не может быть отрицательным"),
        }
        static void ValidateAge(ushort a)
        {
            if (a >150)
            {
                Console.WriteLine(a);
            }
            //> 150 - выбросить ArgumentOutOfRangeException("Слишком большой возраст").
        }
    }
}
