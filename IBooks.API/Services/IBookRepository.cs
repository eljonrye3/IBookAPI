using IBooks.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBooks.API.Services
{
    public interface IBookRepository
    {
        //IEnumerable<Books> GetBooks();

        //Entities.Books GetBook(int id);

        Task<IEnumerable<Books>> GetBooksAsync();

        Task<Books> GetBookAsync(int id);
    }
}
