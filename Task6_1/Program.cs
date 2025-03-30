using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;

namespace Task6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            string[] words = str.Split(' ');
            int maxWord = 0;
            foreach (string word in words)
            {
               if ( word.Length > maxWord);
                maxWord = word.Length;
                 Console.WriteLine(word);
            }
            Console.WriteLine(maxWord);
        }
    }
}