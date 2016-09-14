using System.Collections.Generic;
using OnionArchitecture.Core.DomainService;
using OnionArchitecture.Infrastructure.Data.EntityFramework;

namespace OnionArchitecture.Infrastructure.Data
{
    public class CommandExecutor : ICommandExecutor
    {
        private readonly IStoreContext _storeContext;
        private readonly ICommandDispatcher _dispatcher;

        public CommandExecutor(IStoreContext context, ICommandDispatcher dispatcher)
        {
            _storeContext = context;
            _dispatcher = dispatcher;
        }

        public void Execute(IEnumerable<ICommand> commands)
        {
            foreach (var command in commands)
            {

                var validator = _dispatcher.GetValidator(command);
                var validationResult = validator.Validate(command);

                if (!validationResult.IsValid)
                    throw new CommandValidationException(validationResult.ErrorMessages);

                var handler = _dispatcher.GetHandler(command);
                handler.Handle(command);
            }

            _storeContext.SaveChanges();
        }
    }
}
