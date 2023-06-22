using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }
        public DbSet<Book> Books {get; set;}
        public DbSet<BookDetail> BookDetail {get; set;}
    }
}