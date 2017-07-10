using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.IO;


namespace _07.Books_Library
{
    class Program
    {
        public class Library
        {
            public string Name { get; set; }

            public new List<Book> Books { get; set; }
        }
        public class Book
        {
            public string Title { get; set; }

            public string Author { get; set; }

            public string Publisher { get; set; }

            public DateTime ReleaseDate { get; set; }

            public int Isbn { get; set; }

            public decimal Price { get; set; }
        }
        public class BookInfo
        {
            public string Name { get; set; }
            public DateTime ReleaseDate { get; set; }
        }
        static void Main(string[] args)
        {

            var input = File.ReadAllLines("input.txt");
            var booksToAdd = int.Parse(Console.ReadLine());
            var library = new Library
            {
                Name = "Letera",
                Books = new List<Book>()
            };

            for (int i = 0; i < booksToAdd; i++)
            {
                library.Books.Add(GetBook());
            }

            var dateFilter = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InstalledUICulture);

            var filteredBooks = library.Books.Where(book => book.ReleaseDate > dateFilter).OrderBy(book => book.ReleaseDate).ThenBy(book => book.Title);
            File.Create("output.txt");
            var addText = File.AppendText("output.txt");
            foreach(var item in filteredBooks)
            {
                var title = item.Title;
                var date = item.ReleaseDate;

                addText.WriteLine($"{title} -> {date:dd.MM.yyyy}");
            }
        }

        private static Book GetBook()
        {
            var input = Console.ReadLine().Split().ToList();
            return new Book
            {
                Title = input[0],
                Author = input[1],
                Publisher = input[2],
                ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                Isbn = int.Parse(input[4]),
                Price = decimal.Parse(input[5])
            };
        }
    }
}
