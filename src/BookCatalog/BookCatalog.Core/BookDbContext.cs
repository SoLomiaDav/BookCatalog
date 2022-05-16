using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCatalog.Core;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookCatalog.Core
{
    public class BookDbContext : IdentityDbContext<User>
    {
        public BookDbContext(DbContextOptions<BookDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {           
            base.OnModelCreating(builder);
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }

    }
}
