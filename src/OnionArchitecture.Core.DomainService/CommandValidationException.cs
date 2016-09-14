using System;
using System.Collections.Generic;

namespace OnionArchitecture.Core.DomainService
{
    public class CommandValidationException : Exception
    {
        private readonly IEnumerable<string> _errorMessages;

        public CommandValidationException(IEnumerable<string> errorMessages)
        {
            _errorMessages = errorMessages;
        }

        public override string Message
        {
            get
            {
                return string.Join(string.Empty, _errorMessages);
            }
        }
    }
}
