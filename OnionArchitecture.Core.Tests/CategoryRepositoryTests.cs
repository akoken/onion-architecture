using System.Collections.Generic;
using Moq;
using OnionArchitecture.Core.Domain;
using OnionArchitecture.Core.DomainService;
using Xunit;

namespace OnionArchitecture.Core.Tests
{
    public class CategoryRepositoryTests
    {
        private readonly Mock<ICategoryRepository> _categoryRepository;
        public CategoryRepositoryTests()
        {
            _categoryRepository = new Mock<ICategoryRepository>();
        }

        [Theory]
        [InlineData(1, "Smart Phone")]        
        public void GetCategoriesListIsNotNull(int categoryId, string categoryName)
        {
            var categoryList = new List<Category>
            {
                new Category
                {
                    CategoryId = categoryId,
                    CategoryName = categoryName,
                    Products = GetProducts()
                }
            };

            _categoryRepository.Setup(p => p.GetCategories())
                .Returns(categoryList);

            var result = _categoryRepository.Object.GetCategories();

            Assert.NotEmpty(result);
        }

        private IList<Product> GetProducts()
        {
            var products = new List<Product>
            {
                new Product {ProductId = 1, CategoryId = 1, ProductName = "Apple iPhone 6S", UnitPrice = 649},
                new Product {ProductId = 2, CategoryId = 1, ProductName = "Apple iPhone 6S Plus", UnitPrice = 749}
            };

            return products;
        }        
    }
}
