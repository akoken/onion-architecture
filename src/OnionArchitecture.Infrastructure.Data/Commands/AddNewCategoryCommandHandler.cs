using OnionArchitecture.Core.DomainService.CommandCore;
using OnionArchitecture.Core.DomainService.Commands;
using OnionArchitecture.Infrastructure.Data.EntityFramework;

namespace OnionArchitecture.Infrastructure.Data.Commands
{
    public class AddNewCategoryCommandHandler : ICommandHandler<AddNewCategoryCommand>
    {
        private readonly IStoreContext _storeContext;        
        public AddNewCategoryCommandHandler(IStoreContext context)
        {            
            _storeContext = context;
        }

        public void Handle(object commandObj)
        {
            var command = (AddNewCategoryCommand) commandObj;
            _storeContext.Categories.Add(command.Category);
        }           
    }
}
