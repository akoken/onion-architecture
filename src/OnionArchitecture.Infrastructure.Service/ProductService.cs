using Microsoft.EntityFrameworkCore;
using OnionArchitecture.Core.Domain;
using OnionArchitecture.Core.DomainService;
using OnionArchitecture.Infrastructure.Data.EntityFramework;
using System.Collections.Generic;
using System.Linq;

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
            return ((StoreContext)_context).Categories.ToList();
        }

        public IEnumerable<Product> GetProducts(int categoryId)
        {
            return ((StoreContext)_context).Products.Where(p => p.Category.CategoryId == categoryId).ToList();
        }
    }
}
