using System.Collections.Generic;

namespace OnionArchitecture.Core.DomainService.CommandCore
{
    public interface ICommandExecutor
    {
        void Execute(IEnumerable<ICommand> commands);
    }
}
