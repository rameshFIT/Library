using Library.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Services
{
    public class InmemoryBookData : IBookData
    {
        List<Book> books;
        public IEnumerable<Book>  AddBook(Book objBook)
        {
            if(books.Count >0)
            objBook.Id = books.Max(m => m.Id) + 1;
            objBook.Id = 1;
            books.Add(objBook);
            return books;
        }

        public Book GetBook(int id)
        {
            return books.Find(b => b.Id == id);
        }

       public IEnumerable<Book> GetBooks()
       {
            return books.OrderBy(c=>c.Name);
       }

        public InmemoryBookData()
        {
            books = new List<Book>()
            {
                new Book {Id = 123, Name = "C# Basics", WeekDays = WeekDaysList.Friday, Language = "English", State="Virginia", City="Falls Church"},
                new Book {Id = 125, Name = "C# Introduction", WeekDays = WeekDaysList.Tuesday, Language = "Non-English", State="Maryland", City="Rockville"}
            };
        }
        
    }
}
