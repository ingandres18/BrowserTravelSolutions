using Domain.Authors;
using Domain.Books;
using Domain.Editorials;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

           
        }

        public DbSet<Author> Authores { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Editorial> Editorials { get; set; }
    }
}
