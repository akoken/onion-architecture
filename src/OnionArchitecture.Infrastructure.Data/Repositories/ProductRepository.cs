using System.Collections.Generic;
using System.Linq;
using OnionArchitecture.Core.Domain;
using OnionArchitecture.Core.DomainService;
using OnionArchitecture.Core.ApplicationService;
using OnionArchitecture.Infrastructure.Data.EntityFramework;

namespace OnionArchitecture.Infrastructure.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreContext _context;
        private readonly ILoggingService _loggingService;

        public ProductRepository(ILoggingService loggingService)
        {
            _context = new StoreContext();
            _loggingService = loggingService;
        }
        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public IEnumerable<Product> GetProductsByCategoryId(int categoryId)
        {
            _loggingService.Information("OnionArchitecture.Infrastructure.Data: ProductRepository.GetProductsByCategoryId");
            return _context.Products.Where(p => p.CategoryId == categoryId);
        }
    }
}
