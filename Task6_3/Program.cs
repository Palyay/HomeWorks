using System.Collections.Generic;
using System.Text;

namespace Task6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Отчет
            Console.Write("Введите месяц: ");
            string m = Console.ReadLine();
            m = string.Format("Отчёт о продажах за {0} ", m);
            Console.Write("Введите год: ");
            int g = Convert.ToInt32(Console.ReadLine());
            string g1 = string.Format("{0}", g);
            Console.Write("Введите общую сумму продаж: ");
            //  здесь заменить точку на запятую в разделителе я так и не смог,
            //  в данном типе разрешает только запятую, а если задавать строкой,
            //  то не вычислить результат
            double s = Convert.ToDouble(Console.ReadLine());
            string s1 = string.Format("{0,12:N}", s);
            Console.Write("Введите количество проданных товаров: ");
            int k = Convert.ToInt32(Console.ReadLine());
            string k1 = string.Format("{0,5}", k);
            //Вычислим cреднюю стоимость товара
            double sr = s / k;
            string sr1 = string.Format("{0,8:N}", sr);
            //Выведем сам отчет
            string razdel = new string('-', 20);
            Console.WriteLine(razdel);
            Console.WriteLine("{0}{1}", m, g1);
            Console.WriteLine(razdel);
            Console.WriteLine("Общая сумма продаж: {0} р.", s1);
            Console.WriteLine("Количество проданных товаров: {0} шт.", k1);
            Console.WriteLine("Средняя стоимость товара: {0} р.", sr1);
            Console.WriteLine(razdel);
            Console.ReadKey();

        }
    }
}

