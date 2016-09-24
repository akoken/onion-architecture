using OnionArchitecture.Core.Domain;
using OnionArchitecture.Infrastructure.Data.EntityFramework;
using System.Collections.Generic;
using System.Linq;
using OnionArchitecture.Core.DomainService.Services;

namespace OnionArchitecture.Infrastructure.Service
{
    public class ProductService : IProductService
    {
        private readonly IStoreContext _storeContext;

        public ProductService(IStoreContext storeContext)
        {
            _storeContext = storeContext;
        }
        public IEnumerable<Category> GetCategories()
        {
            var categories = new List<Category>
            {
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Software Architecture"
                },
                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Mobile Programming"
                },
                new Category
                {
                    CategoryId = 3,
                    CategoryName = "Cloud Computing"
                }
            };

            return categories;
            //return _storeContext.Categories.ToList();
        }

        public IEnumerable<Product> GetProducts(int categoryId)
        {
            return _storeContext.Products.Where(p => p.CategoryId == categoryId).ToList();
        }
    }
}
