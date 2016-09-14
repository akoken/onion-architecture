using OnionArchitecture.Core.DomainService.CommandCore;
using OnionArchitecture.Core.DomainService.Commands;

namespace OnionArchitecture.Core.DomainService.Validations
{
    public class AddNewCategoryValidator : ICommandValidator<AddNewCategoryCommand>
    {
        public ValidationResult Validate(object commandObj)
        {
            var command = (AddNewCategoryCommand)commandObj;

            var result = new ValidationResult() { IsValid = true };

            if (command.Category == null)
            {
                result.IsValid = false;
                result.ErrorMessages.Add("Category must be set.");
                return result;
            }

            if (string.IsNullOrEmpty(command.Category.CategoryName))
            {
                result.IsValid = false;
                result.ErrorMessages.Add("Category name must be set.");
            }

            if (command.Category.CategoryId > 0)
            {
                result.IsValid = false;
                result.ErrorMessages.Add("Category id cannot be set.");
            }

            return result;
        }
    }
}