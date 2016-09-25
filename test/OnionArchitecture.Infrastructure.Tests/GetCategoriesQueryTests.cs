using OnionArchitecture.Infrastructure.Data.EntityFramework;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using OnionArchitecture.Core.Domain;
using OnionArchitecture.Infrastructure.Data.Queries;
using Xunit;

namespace OnionArchitecture.Infrastructure.Tests
{
    public class GetCategoriesQueryTests
    {
        private readonly IStoreContext _storeContext;
        public GetCategoriesQueryTests()
        {
            var db = new DbContextOptionsBuilder<StoreContext>();
            db.UseInMemoryDatabase();
            _storeContext = new StoreContext(db.Options);            
        }

        [Fact]
        public void GetCategoriesQueryReturnsAllCategories()
        {
            var categoryList = new List<Category>
            {
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Software Architecture",
                    Products = new List<Product>()
                },
                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Mobile Programming",
                    Products = new List<Product>()
                }
            };

            _storeContext.Categories.AddRange(categoryList);
            _storeContext.SaveChanges();

            var query = new GetCategoriesQuery(_storeContext);
            var categories = query.GetCategories();
            
            Assert.NotNull(categories);
            Assert.True(categories.Count() == 2);
        }
    }
}
