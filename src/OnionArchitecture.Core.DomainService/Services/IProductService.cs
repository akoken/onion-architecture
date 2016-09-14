using System.Collections.Generic;
using OnionArchitecture.Core.Domain;

namespace OnionArchitecture.Core.DomainService.Services
{
    public interface IProductService
    {
        IEnumerable<Category> GetCategories();
        IEnumerable<Product> GetProducts(int categoryId);
    }
}
