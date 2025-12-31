using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2OOPLibrary
{
    public class EBook : Book
    {
        public double FileSizeMB { get; set; }

        public EBook(string title, string author, string isbn, double fileSize)
            : base(title, author, isbn)
        {
            FileSizeMB = fileSize;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[E-Book] Title: {Title}, Author: {Author}, ISBN: {ISBN}, File Size: {FileSizeMB} MB");
        }
    }
}
