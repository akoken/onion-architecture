﻿using OnionArchitecture.Core.Domain;
using System.Collections.Generic;
using System.Linq;
using OnionArchitecture.Infrastructure.Data.EntityFramework;
using OnionArchitecture.Core.DomainService;
using OnionArchitecture.Core.ApplicationService;

namespace OnionArchitecture.Infrastructure.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly StoreContext _context;
        private readonly ILoggingService _loggingService;

        public CategoryRepository(ILoggingService loggingService)
        {
            _context = new StoreContext();
            _loggingService = loggingService;
        }

        public IEnumerable<Category> GetCategories()
        {
            var categories = (from c in _context.Categories
                              orderby c.CategoryName
                              select c).ToList();

            _loggingService.Information("OnionArchitecture.Infrastructure.Data: CategoryRepository.GetCategories");

            return categories;
        }
    }
}
