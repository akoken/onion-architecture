using System.Collections.Generic;
using System.Linq;
using OnionArchitecture.Core.Domain;
using OnionArchitecture.Core.DomainService.Queries;
using OnionArchitecture.Infrastructure.Data.EntityFramework;

namespace OnionArchitecture.Infrastructure.Data.Queries
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
