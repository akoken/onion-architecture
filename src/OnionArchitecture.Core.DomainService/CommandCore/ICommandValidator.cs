namespace OnionArchitecture.Core.DomainService.CommandCore
{
    public interface ICommandValidator
    {
        ValidationResult Validate(object commandObj);
    }

    public interface ICommandValidator<TCommand> : ICommandValidator where TCommand : ICommand
    { }
}
