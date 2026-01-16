using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog
{
    internal class Book
    {
        public string Title;
        public string Author;
        public int Year;

        public bool IsOld => Year < 2006;

        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

        public void DisplayInfo()
        {
            string oldMarker;
            if (IsOld)
            {
                oldMarker = " [Старая]";
            }
            else
            {
                oldMarker = "";
            }

            Console.WriteLine($"«{Title}» — {Author}, {Year}{oldMarker}");
        }
    }
}
