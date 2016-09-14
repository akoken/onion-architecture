namespace OnionArchitecture.Core.DomainService
{

    public interface ICommandHandler
    {
        void Handle(object commandObj);
    }

    public interface ICommandHandler<TCommand> : ICommandHandler where TCommand : ICommand
    {
    }
}
