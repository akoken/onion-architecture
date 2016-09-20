using OnionArchitecture.Core.Domain;
using OnionArchitecture.Core.DomainService.CommandBase;

namespace OnionArchitecture.Core.DomainService.Commands
{
    public class AddNewCategoryCommand : ICommand
    {
        public Category Category { get; set; }        
    }
}
