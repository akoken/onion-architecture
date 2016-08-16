using System.Data.Entity;
using App.Domain.Entities;

namespace App.Infrastructure.Data.Helpers
{
    public class AppContext : DbContext
    {
        public AppContext(string connectionString) 
            : base(connectionString)
        {            
        }

        public DbSet<Product> Products{ get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
