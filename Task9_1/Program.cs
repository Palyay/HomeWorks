namespace Task9_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Создайте класс Book, который содержит:
            //  Поля:
            //   _title(название книги, private)
            //   _author(автор, private)
            //   Автосвойства:
            //   Year(год издания, public геттер, public сеттер)
            //   Pages(количество страниц, public геттер, public сеттер)
            //   Конструктор:
            //   Инициализирует все поля и свойства
            //   Метод:
            //   GetInfo() – возвращает строку с информацией о книге(например: "Война и мир, Л. Толстой, 1869, 1225 стр.")

            Cat cat = new Cat();
            Cat cat1 = new Cat();
            Cat cat2 = new Cat();





        }
    }
    class Cat
    {
        string name;
        string color;
        int age;

        //public Cat(string n, string c, int a)
        //{
        //    name = n;
        //    color = c;
        //    age = a;
        //}Cat(string n)
        //{
        //    name = n;
        //    color = "Мульти";
        //    age = 1;
        //}

        void Sey()
        {
            Console.WriteLine("Мяу");
        }
    }
}
