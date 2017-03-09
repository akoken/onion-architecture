using OnionArchitecture.Core.DomainService.Validations;

namespace OnionArchitecture.Core.DomainService.CommandBase
{
    public interface ICommandValidator
    {
        ValidationResult Validate(object commandObj);
    }

    public interface ICommandValidator<TCommand> : ICommandValidator where TCommand : ICommand
    { }
}
