using Microsoft.EntityFrameworkCore;
using OnionArchitecture.Core.Domain;

namespace OnionArchitecture.Infrastructure.Data.EntityFramework
{
    public class ProductStoreContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
