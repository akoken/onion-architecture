using System.Collections.Generic;
using System.Linq;
using OnionArchitecture.Core.Domain;
using OnionArchitecture.Core.DomainService;

namespace OnionArchitecture.Infrastructure.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly EntityDatabaseContext _context;

        public ProductRepository(string connectionString)
        {
            _context = new EntityDatabaseContext(connectionString);
        }

        public IEnumerable<Product> GetProducts()
        {
            var products = (from p in _context.Products
                orderby p
                select p).ToList();
            return products;
        }

        public IEnumerable<Product> GetProductsByCategoryId(int categoryId)
        {
            var products = (from p in _context.Products
                where p.Category.CategoryId == categoryId
                orderby p
                select p).ToList();

            return products;
        }
    }
}
