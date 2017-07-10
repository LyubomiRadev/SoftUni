using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public class AuthorInfo
        {
            public string Name { get; set; }
            public decimal Sales { get; set; }
        }
        static void Main(string[] args)
        {
            

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

            var authors = library.Books.Select(writer => writer.Author).Distinct().ToList();
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

            authorSales = authorSales.OrderByDescending(a => a.Sales).ThenBy(b => b.Name).ToList();

            foreach(var item in authorSales)
            {
                Console.WriteLine($"{item.Name} -> {item.Sales:F2}");
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
