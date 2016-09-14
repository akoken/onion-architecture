using System.Collections.Generic;

namespace OnionArchitecture.Core.DomainService.CommandCore
{
    public class ValidationResult
    {
        public bool IsValid { get; set; }
        public IList<string> ErrorMessages { get; set; }
    }
}
