namespace OnionArchitecture.Core.DomainService
{
    public interface ICommandDispatcher
    {
        ICommandHandler GetHandler(ICommand command);
        ICommandValidator GetValidator(ICommand command);
    }
}
