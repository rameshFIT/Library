using Library.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Services
{
   public class LibraryDBContext : DbContext
    {
        public DbSet<Book> BookDbSet { get; set; }

        //What this method for? 
        //https://stackoverflow.com/questions/3600175/the-model-backing-the-database-context-has-changed-since-the-database-was-crea
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<LibraryDBContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}
