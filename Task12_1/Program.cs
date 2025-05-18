using System.Globalization;

namespace Task12_1
{
    internal class Program
    {
        static void Main()
        {
            //  1-й массив книг
            Book<string, int>[] books1 = new Book<string, int>[]
            {
                new Book<string, int>("F-1231", "Война и мир. Том 1", 2005, "Толстой"),
                new Book<string, int>("F-1232", "Война и мир. Том 2", 2005, "Толстой"),
                new Book<string, int>("F-1233", "Война и мир. Том 3", 2005, "Толстой"),
                new Book<string, int>("F-1234", "Война и мир. Том 4", 2005, "Толстой")
            };
            //  2-й массив книг
            Book<int, string>[] books2 = new Book<int, string>[]
            {
                new Book<int, string>(42, "Том 1", "Первобытное общество", "Коровкин") ,
                new Book<int, string>(43, "Том 2", "Древний мир", "Тураев") ,
                new Book<int, string>(44, "Том 3", "Средние века", "Козырева") ,
                new Book<int, string>(45, "Том 4", "Новое время", "Егоров")
            };
            // Найдем информацию о книгах:
            Book<string, int> book1 = FindBook<string, int>(books1, "F-1234");
            Book<int, string> book2 = FindBook<int, string>(books2, 44);
            // Выведем информацию о книгах:
            Console.WriteLine(book1?.ToString() ?? "Не найдено");
            Console.WriteLine(book2?.ToString() ?? "Не найдено");
            Console.ReadKey();
        }
        //  Обобщенный метод FindBook возвращает книгу с указанным кодом или null, если книга не найдена
        static Book<T, U> FindBook<T, U>(Book<T, U>[] books, T code)
        {
            foreach (Book<T, U> book in books)
            {
                if (book.Code.Equals(code))
                    return book;
            }
            return null;
        }
        // Обобщенный класс "Book<T, U>"
        public class Book<T, U>
        {
            //  Свойство уникальный код книги
            public T Code { get; set; }
            //  Свойство название книги
            public string Title { get; set; }
            //  Свойство год публикации
            public U PublicationYear { get; set; }
            //  Свойство автор книги (тип string)
            public string Author { get; set; }
            //  Конструктор, принимающий все параметры
            public Book(T code, string title, U publicationYear, string author)
            {
                Code = code; Title = title; PublicationYear = publicationYear; Author = author;
            }
            //  Переопределенный метод ToString
            public override string ToString()
            {
                return $" Код: {Code} ({typeof(T).Name}), Название: {Title}, Автор: {Author}, Год: {PublicationYear} ({typeof(U).Name})";
            }
        }
    }
}
