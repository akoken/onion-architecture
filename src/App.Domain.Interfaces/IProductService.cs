using System.Collections.Generic;
using OnionArchitecture.Core.Domain;

namespace OnionArchitecture.Core.DomainServices
{
    public interface IProductService
    {
        IEnumerable<Category> GetCategories();
        IEnumerable<Product> GetProducts(int? categoryId);
    }
}
