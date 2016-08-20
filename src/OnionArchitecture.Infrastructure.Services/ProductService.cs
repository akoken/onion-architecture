using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using OnionArchitecture.Core.Domain;
using OnionArchitecture.Core.DomainService;
using OnionArchitecture.Infrastructure.Data;

namespace OnionArchitecture.Infrastructure.Service
{
    public class ProductService : IProductService
    {
        private readonly DbContext _context;

        public ProductService(DbContext context)
        {
            _context = context;
        }
        public IEnumerable<Category> GetCategories()
        {
            return ((EntityDatabaseContext) _context).Categories.ToList();
        }

        public IEnumerable<Product> GetProducts(int categoryId)
        {
            return ((EntityDatabaseContext) _context).Products.Where(p => p.Category.CategoryId == categoryId).ToList();
        }
    }
}
