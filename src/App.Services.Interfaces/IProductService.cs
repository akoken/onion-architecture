using System.Collections.Generic;
using OnionArchitecture.Core.Domain;

namespace OnionArchitecture.Services.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Category> GetCategories();
        IEnumerable<Product> GetProducts(int? categoryId);
    }
}
