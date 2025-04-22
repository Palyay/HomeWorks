namespace Task9_1
{
    internal class Program
    {
        static void Main()
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
            Book cat = new Book("Война и мир", "Л. Толстой", 1869, 1225);
            cat.GetInfo();
            Console.ReadKey();
        }
    }
    class Book
    {
        string title;
        string author;
        public int Year { get; set; }
        public int Pages { get; set; }

        public Book(string title, string author, int year, int pages)
        {
            this.title = title;
            this.author = author;
            Year = year;
            Pages = pages;
        }

        public void GetInfo()
        {
            Console.WriteLine($"{title}, {author}, {Year}, {Pages} стр.,");
        }
    }
}
