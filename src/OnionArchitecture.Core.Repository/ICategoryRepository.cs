using System.Collections.Generic;
using OnionArchitecture.Core.Domain;

namespace OnionArchitecture.Core.DomainService
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories();
    }
}
