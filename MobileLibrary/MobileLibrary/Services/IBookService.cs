using System;
using System.Collections.Generic;
using System.Text;
using MobileLibrary.Models;
using System.Threading.Tasks;

namespace MobileLibrary.Services
{
    interface IBookService
    {
        Task<IEnumerable<Book>> GetBooks();
        Task<Book> GetBook(int id);
        Task AddBook(Book book);
        Task SaveBook(Book book);
        Task DeleteBook(Book book);
    }
}
