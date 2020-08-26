using IBooks.API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBooks.API.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository repository;

        public BooksController(IBookRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet("GetBooks")]
        public async Task<IActionResult> GetBooks()
        {
            /
            var bookEntities = await this.repository.GetBooksAsync();

            return Ok(bookEntities);
        }

        [HttpGet("GetBook/{id}")]
        public async Task<IActionResult> GetBook(int id)
        {
            var bookEntity = await this.repository.GetBookAsync(id);

            if(bookEntity == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(bookEntity);
            }
        }
    }
}
