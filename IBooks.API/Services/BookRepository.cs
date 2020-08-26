using IBooks.API.Contexts;
using IBooks.API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBooks.API.Services
{
    public class BookRepository : IBookRepository, IDisposable
    {
        private BookContext context;

        public BookRepository(BookContext context)
        {
            this.context = context;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if(disposing)
            {
                if(this.context != null)
                {
                    this.context.Dispose();
                    this.context = null;
                }
            }
        }

        public async Task<Books> GetBookAsync(int id)
        {
            return await this.context.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<IEnumerable<Books>> GetBooksAsync()
        {
            return await this.context.Books.Include(b => b.Author).ToListAsync();
        }
    }
}
