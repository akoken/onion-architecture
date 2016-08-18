using App.Domain.Entities;
using System.Collections.Generic;

namespace App.Services.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Category> GetCategories();
        IEnumerable<Product> GetProducts(int? categoryId);
    }
}
