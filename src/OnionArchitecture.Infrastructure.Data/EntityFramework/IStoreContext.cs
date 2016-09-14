using OnionArchitecture.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace OnionArchitecture.Infrastructure.Data.EntityFramework
{
    public interface IStoreContext
    {
        DbSet<Product> Products { get; set; }
        DbSet<Category> Categories { get; set; }

        int SaveChanges();
    }
}
