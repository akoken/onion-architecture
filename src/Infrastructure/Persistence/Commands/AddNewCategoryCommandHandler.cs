using OnionArchitecture.Core.DomainService.CommandBase;
using OnionArchitecture.Core.DomainService.Commands;
using OnionArchitecture.Infrastructure.Persistence.EntityFramework;

namespace OnionArchitecture.Infrastructure.Persistence.Commands
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
