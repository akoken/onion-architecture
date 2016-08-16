using System.Collections.Generic;
using System.Linq;
using App.Domain.Entities;
using App.Domain.Interfaces;
using App.Infrastructure.Data.Helpers;
using App.Infrastructure.Interfaces;

namespace App.Infrastructure.Data.Repositories
{
    public class CategoryRepository : RepositoryBase, ICategoryRepository
    {
        private readonly AppContext _context;
        private readonly ILoggingService _loggingService;

        public CategoryRepository(string connectionString, ILoggingService loggingService) 
            : base(connectionString)
        {
            _context = new AppContext(connectionString);
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
