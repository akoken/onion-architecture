namespace OnionArchitecture.Core.DomainService.CommandBase
{
    public interface ICommandDispatcher
    {
        ICommandHandler GetHandler(ICommand command);

        ICommandValidator GetValidator(ICommand command);
    }
}
