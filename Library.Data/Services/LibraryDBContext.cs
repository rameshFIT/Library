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
        public DbSet BookDbSet { get; set; }
    }
}
