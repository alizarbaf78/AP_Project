using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace tab_menu.Model
{
   public class Context:DbContext
    {

        public DbSet<User>users { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Master> masters { get; set; }
        public DbSet<Chang> changs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFCodeShopping;Trusted_Connection=True;");
        }

    }
}
