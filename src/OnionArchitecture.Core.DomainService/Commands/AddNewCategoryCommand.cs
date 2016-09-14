using OnionArchitecture.Core.Domain;

namespace OnionArchitecture.Core.DomainService.Commands
{
    public class AddNewCategoryCommand : ICommand
    {
        public Category Category { get; set; }        
    }
}
