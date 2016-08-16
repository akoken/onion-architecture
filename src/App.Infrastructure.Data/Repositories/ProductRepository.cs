using App.Domain.Entities;
using App.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;
using App.Infrastructure.Data.Helpers;

namespace App.Infrastructure.Data.Repositories
{
    public class ProductRepository : RepositoryBase, IProductRepository
    {
        private readonly AppContext _context;

        public ProductRepository(string connectionString)
            : base(connectionString)
        {
            _context = new AppContext(connectionString);
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
