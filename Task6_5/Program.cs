using System.Text.RegularExpressions;

namespace Task6_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] test =
            {
                "abc@gmail.com", "abc.gmail.com", "abc@gmail_com", "my email is abc@gmail.com", "test@example..com"
            };
            Regex regex = new Regex(@"^[a-zA-Z0-9._-]+@[a-zA-Z0-9-]+\.[a-zA-Z]{2,}$");
            foreach (string str in test)
                if (regex.IsMatch(str))
                    Console.WriteLine("\"{0}\" - ok", str);
                else
                    Console.WriteLine("\"{0}\" -  не ok", str);
            Console.ReadKey();
        }
    }
}