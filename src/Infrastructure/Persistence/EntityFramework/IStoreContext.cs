using OnionArchitecture.Core.Domain;
using System.Data.Entity;

namespace OnionArchitecture.Infrastructure.Persistence.EntityFramework
{
    public interface IStoreContext
    {
        DbSet<Product> Products { get; set; }
        DbSet<Category> Categories { get; set; }

        int SaveChanges();
    }
}
