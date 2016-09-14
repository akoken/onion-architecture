namespace OnionArchitecture.Core.DomainService
{
    public interface ICommandValidator
    {
        ValidationResult Validate(object commandObj);
    }

    public interface ICommandValidator<TCommand> : ICommandValidator where TCommand : ICommand
    {
    }
}
