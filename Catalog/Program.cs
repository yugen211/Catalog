using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
            {
                new Book("Мастер и Маргарита", "Михаил Булгаков", 1967),
                new Book("1984", "Джордж Оруэлл", 1949),
                new Book("Гарри Поттер и философский камень", "Джоан Роулинг", 1997),
                new Book("Современный C#", "Марк Прайс", 2022),
                new Book("Метро 2033", "Дмитрий Глуховский", 2005),
            };

            foreach (Book book in books)
            {
                book.DisplayInfo();
            }
        }
    }
}
