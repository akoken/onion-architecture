using Microsoft.EntityFrameworkCore;
using OnionArchitecture.Core.Domain;

namespace OnionArchitecture.Infrastructure.Data.EntityFramework
{
    public sealed class StoreContext : DbContext, IStoreContext
    {     
        public StoreContext(DbContextOptions options) : base(options)
        {            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }     
    }
}
