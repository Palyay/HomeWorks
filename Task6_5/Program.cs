using System.Text.RegularExpressions;

namespace Task6_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"{0:#(###)###-##-##}"
            string[] test =
            {
                "+7(987)654-32-10", "abc.gmail.com", "+70006543210", "+7(987)654-321-054", "+7(000)000-00-00" ,"8(958)746-58-69", "+7(275)358-85-74"
            };
            Regex regex = new Regex(@"^\+7+\(+[0-9]{3}\)+[0-9]{3}\-+[0-9]{2}\-[0-9]{2}$");
            foreach (string str in test)
                if (regex.IsMatch(str))
                    Console.WriteLine("\"{0}\" - ok", str);
                else
                    Console.WriteLine("\"{0}\" -  no", str);
            Console.ReadKey();
        }
    }
}