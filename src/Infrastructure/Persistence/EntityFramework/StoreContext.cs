using OnionArchitecture.Core.Domain;
using System.Data.Entity;

namespace OnionArchitecture.Infrastructure.Persistence.EntityFramework
{
    public sealed class StoreContext : DbContext, IStoreContext
    {
        public StoreContext() : base("Name=StoreConnection")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var initializer = new CreateDatabaseIfNotExists<StoreContext>();
            Database.SetInitializer(initializer);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public int SaveChanges()
        {
            return SaveChanges();
        }
    }
}
