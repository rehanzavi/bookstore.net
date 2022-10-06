using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    internal interface IBookRepository
    {
        List<Book> GetAllBook();
        Book GetBookByID(int id);
        Book AddBook(Book book);
        void DeleteBook(int id);
        void UpdateBook(Book book);
    }
}
