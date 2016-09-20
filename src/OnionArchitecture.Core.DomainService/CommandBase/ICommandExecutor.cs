using System.Collections.Generic;

namespace OnionArchitecture.Core.DomainService.CommandBase
{
    public interface ICommandExecutor
    {
        void Execute(IEnumerable<ICommand> commands);
    }
}
