using System.Collections.Generic;

namespace OnionArchitecture.Core.DomainService
{
    public interface ICommandExecutor
    {
        void Execute(IEnumerable<ICommand> commands);
    }
}
