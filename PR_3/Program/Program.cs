using System;

namespace Classes
{
    class Program
    {
        static void Main()
        {
            Title title = new Title("Будь корисним. Сім життєвих правил");
            Author author = new Author("Арнольд Шварценеґґер");
            Content content = new Content("Історія відомого бодибілдера");

            Book book = new Book(title, author, content);
            book.Show();

            Console.ReadKey();
        }
    }
}