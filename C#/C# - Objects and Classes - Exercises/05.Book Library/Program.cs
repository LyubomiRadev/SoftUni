using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _05.Book_Library
{
    public class AuthorInfo
    {
        public string Name { get; set; }

        public double Sales { get; set; }
    }
    class BookLibrary
    {
        public class Book
        {
            public string Title { get; set; }

            public string Author { get; set; }

            public string Publisher { get; set; }

            public DateTime Releasedate { get; set; }

            public int Isbn { get; set; }

            public double Price { get; set; }
        }
        public class Library
        {
            public string Name { get; set; }

            public List<Book> Books { get; set; }
        }

        static void Main(string[] args)
        {
            int numberOfBooks = int.Parse(Console.ReadLine());
            var library = new Library()
            {
                Name = "Prosveta",
                Books = new List<Book>()
            };

            for (int i = 0; i < numberOfBooks; i++)
            {
                library.Books.Add(TakeBook());

            }

            var authors = library.Books.Select(author => author.Author).Distinct().ToArray();
            var authorSales = new List<AuthorInfo>();

            foreach(var author in authors)
            {
                var sales = library.Books.Where(a => a.Author == author).Sum(a => a.Price);

                authorSales.Add(new AuthorInfo
                {
                    Name = author,
                    Sales = sales
                });
            }

            authorSales = authorSales.OrderByDescending(a => a.Sales).ThenBy(a => a.Name).ToList();

            foreach(var item in authorSales)
            {
                Console.WriteLine($"{item.Name} -> {item.Sales:F2}");
            }

        }

        private static Book TakeBook()
        {
            var input = Console.ReadLine().Split().ToList();

            return new Book
            {
                Title = input[0],
                Author = input[1],
                Publisher = input[2],
                Releasedate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                Isbn = int.Parse(input[4]),
                Price = double.Parse(input[5])
            };
        }
    }
}
