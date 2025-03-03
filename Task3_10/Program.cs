using System.Numerics;

namespace Task3_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());//{Застройщик построил n домов. Вывести фразу «Мы построили n домов» обеспечив правильное согласование числа со словом «дом», например: 20 — «Мы построили 20 домов»,32 — «Мы построили 32 дома», 41 — «Мы построили 41 дом».}
            int n1 = n % 100;
            int n2 = n % 10;
            if (10 < n1 && n1 < 15)
            {
                switch (n1)
                {
                    case 11:
                        Console.WriteLine("Мы построили {0} домов", n);
                        break;
                    case 12:
                        Console.WriteLine("Мы построили {0} домов", n);
                        break;
                    case 13:
                        Console.WriteLine("Мы построили {0} домов", n);
                        break;
                    case 14:
                        Console.WriteLine("Мы построили {0} домов", n);
                        break;
                    default:
                        Console.WriteLine("Ошибка");
                        break;
                }
            }
            else
            {
                switch (n2)
                {
                    case 1:
                        Console.WriteLine("Мы построили {0} дом", n);
                        break;
                    case 2:
                        Console.WriteLine("Мы построили {0} домa", n);
                        break;
                    case 3:
                        Console.WriteLine("Мы построили {0} домa", n);
                        break;
                    case 4:
                        Console.WriteLine("Мы построили {0} домa", n);
                        break;
                    case 5:
                        Console.WriteLine("Мы построили {0} домов", n);
                        break;
                    case 6:
                        Console.WriteLine("Мы построили {0} домов", n);
                        break;
                    case 7:
                        Console.WriteLine("Мы построили {0} домов", n);
                        break;
                    case 8:
                        Console.WriteLine("Мы построили {0} домов", n);
                        break;
                    case 9:
                        Console.WriteLine("Мы построили {0} домов", n);
                        break;
                    case 0:
                        Console.WriteLine("Мы построили {0} домов", n);
                        break;
                    default:
                        Console.WriteLine("Ошибка");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}