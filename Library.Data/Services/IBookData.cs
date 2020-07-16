
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Model;

namespace Library.Data.Services
{
    public interface IBookData
    {
        IEnumerable<Book> AddBook(Book objBook);
        IEnumerable<Book> GetBooks();
        Book GetBook(int id);
    }
}
