using OnionArchitecture.Core.Domain;
using System.Collections.Generic;
using System.Linq;
using OnionArchitecture.Core.ApplicationService;
using OnionArchitecture.Core.DomainService;

namespace OnionArchitecture.Infrastructure.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly EntityDatabaseContext _context;
        private readonly ILoggingService _loggingService;

        public CategoryRepository(string connectionString, ILoggingService loggingService)           
        {
            _context = new EntityDatabaseContext(connectionString);
            _loggingService = loggingService;
        }

        public IEnumerable<Category> GetCategories()
        {
            var categories = (from c in _context.Categories
                              orderby c.CategoryName
                              select c).ToList();
            
            _loggingService.Trace("App.Infrastructure.Data: CategoryRepository.GetCategories");

            return categories;
        }
    }
}
