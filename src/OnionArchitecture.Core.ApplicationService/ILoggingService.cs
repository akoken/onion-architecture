namespace OnionArchitecture.Core.ApplicationService
{
    public interface ILoggingService
    {           
        void Error(string errorMessage);

        void Warning(string warningMessage);

        void Information(string traceMessage);
    }
}
