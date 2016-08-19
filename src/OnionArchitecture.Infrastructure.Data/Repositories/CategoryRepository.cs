using OnionArchitecture.Core.ApplicationServices;
using OnionArchitecture.Core.Domain;
using OnionArchitecture.Core.DomainServices;
using System.Collections.Generic;
using System.Linq;

namespace OnionArchitecture.Infrastructure.Data.Repositories
{
    public class CategoryRepository : RepositoryBase, ICategoryRepository
    {
        private readonly EntityDatabaseContext _context;
        private readonly ILoggingService _loggingService;

        public CategoryRepository(string connectionString, ILoggingService loggingService) 
            : base(connectionString)
        {
            _context = new EntityDatabaseContext(connectionString);
            _loggingService = loggingService;
        }

        public IEnumerable<Category> GetCategories()
        {
            var categories = (from c in _context.Categories
                              orderby c.CategoryName
                              select c).ToList();

            // Log call
            _loggingService.Trace("App.Infrastructure.Data: CategoryRepository.GetCategories");

            return categories;
        }
    }
}
