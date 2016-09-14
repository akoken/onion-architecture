namespace OnionArchitecture.Core.DomainService.CommandCore
{
    public interface ICommandDispatcher
    {
        ICommandHandler GetHandler(ICommand command);

        ICommandValidator GetValidator(ICommand command);
    }
}
