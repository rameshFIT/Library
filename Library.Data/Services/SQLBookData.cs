using Library.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Services
{
    public class SQLBookData : IBookData
    {
        LibraryDBContext bookDBContext;
        public IEnumerable<Book> AddBook(Book objBook)
        {
            bookDBContext.BookDbSet.Add(objBook);
            bookDBContext.SaveChanges();
            return new  List<Book>();
        }

        public SQLBookData(LibraryDBContext bookDBContext)
        {
            this.bookDBContext = bookDBContext;
        }

        public Book GetBook(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetBooks()
        {
            throw new NotImplementedException();
        }
    }
}
