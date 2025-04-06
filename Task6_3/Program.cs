using System;
using System.Globalization;

namespace Task6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите месяц: ");
            string m = Console.ReadLine();
            m = String.Format("Отчёт о продажах за {0} ", m);
            Console.Write("Введите год: ");
            string g = Console.ReadLine();
            g = String.Format("{0,4:0000}", g);
            Console.Write("Введите общую сумму продаж: ");
            string s = Console.ReadLine();
            string ru_s = s.ToString(CultureInfo.GetCultureInfo("ru-RU"));
            s = String.Format("Общая сумма продаж: {0:,.F2} р.", ru_s);
            Console.Write("Введите количество проданных товаров: ");
            string k = Console.ReadLine();
            k = String.Format("Количество проданных товаров: {0} шт.", k);
            Console.Write("Введите cреднюю стоимость товара: ");
            string sr = Console.ReadLine();
            sr = String.Format("Средняя стоимость товара: {0:,.F2} р.", sr);

            string razdel = new string('-', 20);
            Console.WriteLine(razdel);
            Console.WriteLine("{0}{1}", m, g);
            Console.WriteLine(razdel);
            Console.WriteLine(s);
            Console.WriteLine(k);
            Console.WriteLine(sr);
            Console.ReadKey();

        }
    }
}
