using System.Collections.Generic;
using OnionArchitecture.Core.Domain;
using Xunit;
using OnionArchitecture.Infrastructure.Persistence.EntityFramework;
using Moq;
using OnionArchitecture.Infrastructure.Persistence.Queries;
using System.Linq;
using System.Data.Entity;

namespace OnionArchitecture.Infrastructure.Tests
{
    public class GetCategoriesQueryTests
    {
        private Mock<IStoreContext> _mockContext;
        private Mock<DbSet<Category>> _mockCategorySet;
        private Mock<DbSet<Product>> _mockProductSet;
        public GetCategoriesQueryTests()
        {
            _mockContext = new Mock<IStoreContext>();
            _mockCategorySet = new Mock<DbSet<Category>>();
            _mockProductSet = new Mock<DbSet<Product>>();
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

            _mockCategorySet.Setup(m => m.AddRange(It.IsAny<IList<Category>>())).Returns(categoryList);
            _mockContext.Setup(x => x.Categories).Returns(_mockCategorySet.Object);
            var query = new GetCategoriesQuery(_mockContext.Object);
            var categories = query.GetCategories();

            Assert.NotNull(categories);
            Assert.True(categories.Count() == 2);
        }
    }
}
