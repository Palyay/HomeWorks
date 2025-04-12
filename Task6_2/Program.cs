using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace Task6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //«А роза упала на лапу Азора»
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            string str1 = str.ToLower();
            while (str1.Contains("  "))
            {
                str1 = str1.Replace("  ", " ");
            }
            while (str1.Contains(" "))
            {
                str1 = str1.Replace(" ", "");
            }
            string reversedStr = "";
            for (int i = str1.Length - 1; i >= 0; i--)
            {
                reversedStr = reversedStr + str1[i];
            }
            if (str1 == reversedStr)
            {
                Console.WriteLine("является палиндромом");
            }
            else
            {
                Console.WriteLine(" не является палиндромом");
            }
            Console.ReadKey();
        }
    }
}