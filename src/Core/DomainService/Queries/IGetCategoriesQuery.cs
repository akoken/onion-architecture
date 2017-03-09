using System.Collections.Generic;
using OnionArchitecture.Core.Domain;

namespace OnionArchitecture.Core.DomainService.Queries
{
    public interface IGetCategoriesQuery
    {
        IEnumerable<Category> GetCategories();
    }
}
