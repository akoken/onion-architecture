using System.Collections.Generic;
using System.Linq;
using OnionArchitecture.Core.Domain;
using OnionArchitecture.Core.DomainService.Queries;
using OnionArchitecture.Infrastructure.Persistence.EntityFramework;

namespace OnionArchitecture.Infrastructure.Persistence.Queries
{
    public class GetCategoriesQuery : IGetCategoriesQuery
    {
        private readonly IStoreContext _storeContext;
        public GetCategoriesQuery(IStoreContext context)
        {
            _storeContext = context;
        }
        public IEnumerable<Category> GetCategories()
        {
            return _storeContext.Categories.ToList();
        }
    }
}
