using System;
using System.Collections.Generic;
using System.Text;

namespace _10_GenericTypesCollections
{
   public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public int PageCount { get; set; }

        public Book(int id, string title, string author, int year, int pageCount)
        {
            Id = Id;
            Title = Title;
            Author = Author;
            Year = Year;
            PageCount = PageCount;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Id: {Id}, Basliq: {Title}, Muellif: {Author}, Il: {Year}, Sehife sayi: {PageCount}");
        }
    }
}
