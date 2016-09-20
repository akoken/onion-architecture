using System;
using OnionArchitecture.Core.DomainService.CommandBase;

namespace OnionArchitecture.Infrastructure.Data
{
    public class CommandDispatcher : ICommandDispatcher
    {
        public ICommandHandler GetHandler(ICommand command)
        {
            var commandType = command.GetType();

            Type handlerType = typeof(ICommandHandler<>);
            Type constructedClass = handlerType.MakeGenericType(commandType);

            var handler = Activator.CreateInstance(constructedClass);

            return handler as ICommandHandler;
        }

        public ICommandValidator GetValidator(ICommand command)
        {
            var commandType = command.GetType();

            Type validatorType = typeof(ICommandValidator<>);
            Type constructedClass = validatorType.MakeGenericType(commandType);

            var validator = Activator.CreateInstance(constructedClass);

            return validator as ICommandValidator;
        }
    }
}
