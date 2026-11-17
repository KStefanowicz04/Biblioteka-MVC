using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Biblioteka_MVC.Models
{
    public class LibraryDatabaseContext: DbContext
    {
        public LibraryDatabaseContext() : base("LibraryDatabase")
        { }

        // Powiązanie modeli z bazą danych
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}