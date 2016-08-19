using System.Collections.Generic;
using OnionArchitecture.Core.Domain;

namespace OnionArchitecture.Core.DomainServices
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories();
    }
}
