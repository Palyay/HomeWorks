using System.Threading.Tasks;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task16_1
{
    internal class Program
    {
        static int[] GenerateArrayTask(int size)
        {
            Console.WriteLine("Генерация массива...");
            var random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 10);
                Console.Write($"{array[i]} ");
                Thread.Sleep(100);
            }
            Console.WriteLine("\nМассив сгенерирован!");
            return array;
        }
        static double CalculateSumTask(int[] array)
        {
            Console.WriteLine("Вычисление среднего арифметического...");
            double sum = 0;
            foreach (int num in array)
            {
                sum += num;
                Thread.Sleep(300);
            }
            double srAr = sum / array.Length;
            return srAr;
        }
        static async Task Main(string[] args)
        {
            //Проверка методов работы используя задачи продолжения
            Task<int[]> task1 = Task.Run(() => GenerateArrayTask(10));
            Task<double> task2 = task1.ContinueWith(t =>
            {
                int[] array = t.Result;
                return CalculateSumTask(array);
            });
            Console.WriteLine(task2.Result);

            //Проверка методов работы с помощью async/await
            int[] task3 = await GenerateArrayTaskAsync();
            double task4 = await CalculateSumTaskAsync(task3);
            Console.WriteLine(task4);//не успеваю поправить, чтоб правильный результат показал, (скорее всего в этой строке проблема CalculateSumTask([])))

            Console.WriteLine("Main завершен");
            Console.ReadKey();
        }
        static async Task<int[]> GenerateArrayTaskAsync()
        {
            Console.WriteLine("GenerateArrayTaskAsync запущен");
            int[] result = await Task.Run(() => GenerateArrayTask(10));
            Console.WriteLine("GenerateArrayTaskAsync завершен");
            return result;
        }
        static async Task<double> CalculateSumTaskAsync(int[] array)
        {
            Console.WriteLine("CalculateSumTaskAsync запущен");
            double result = await Task.Run(() => CalculateSumTask([]));
            Console.WriteLine("CalculateSumTaskAsync завершен");
            return result;
        }
    }
}

