using IBooks.API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBooks.API.Contexts
{
    public class BookContext : DbContext
    {
        public DbSet<Books> Books { get; set; }

        public BookContext(DbContextOptions<BookContext> options) : base (options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Author>().HasData(
                new Author()
                {
                    Id = 1,
                    FirstName = "George",
                    LastName = "RR Martin"
                },
                new Author()
                {
                    Id = 2,
                    FirstName = "Stephen",
                    LastName = "Fry"
                },
                new Author()
                {
                    Id = 3,
                    FirstName = "James",
                    LastName = "Elroy"
                },
                new Author()
                {
                    Id = 4,
                    FirstName = "Douglas",
                    LastName = "Adams"
                }
           );

            modelBuilder.Entity<Books>().HasData(
                new Books()
                {
                    Id = 1,
                    AuthorId = 1,
                    Title = "The Winds of Winter",
                    Description = "The book that seems impossible to write"
                },
                new Books()
                {
                    Id = 2,
                    AuthorId = 1,
                    Title = "A Game of Thrones",
                    Description = "A Game of Thrones is the first novel in A Song of Ice and Fire"
                }, 
                new Books()
                {
                    Id = 3,
                    AuthorId = 2,
                    Title = "Mythos",
                    Description = "The Greek Myths are amongst the best stories ever told"
                }, 
                new Books()
                {
                    Id = 4,
                    AuthorId = 3,
                    Title = "American Tabloid",
                    Description = "American Tabloid is a 1995 novel by James Elroy"
                },
                new Books()
                {
                    Id = 5,
                    AuthorId = 4,
                    Title = "The Hitchhiker's Guid to the Galaxy",
                    Description = "Another book to guide you in the galaxy"
                }
           );

            base.OnModelCreating(modelBuilder);
        }
    }
}
