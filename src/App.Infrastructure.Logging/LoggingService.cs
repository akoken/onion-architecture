using System;
using NLog;
using OnionArchitecture.Infrastructure.Interfaces;

namespace OnionArchitecture.Infrastructure.Logging
{
    public class LoggingService : Logger, ILoggingService
    {
        private const string LoggerName = "NLogLogger";

        public void Debug(Exception exception, string format, params object[] args)
        {
            if (!IsDebugEnabled) return;
            var logEvent = GetLogEvent(LoggerName, LogLevel.Debug, exception, format, args);
            Log(typeof (LoggingService), logEvent);
        }

        public void Error(Exception exception, string format, params object[] args)
        {
            if (!IsErrorEnabled) return;
            var logEvent = GetLogEvent(LoggerName, LogLevel.Error, exception, format, args);
            Log(typeof (LoggingService), logEvent);
        }

        public void Fatal(Exception exception, string format, params object[] args)
        {
            if (!IsFatalEnabled) return;
            var logEvent = GetLogEvent(LoggerName, LogLevel.Fatal, exception, format, args);
            Log(typeof (LoggingService), logEvent);
        }

        public void Info(Exception exception, string format, params object[] args)
        {
            if (!IsInfoEnabled) return;
            var logEvent = GetLogEvent(LoggerName, LogLevel.Info, exception, format, args);
            Log(typeof (LoggingService), logEvent);
        }

        public void Trace(Exception exception, string format, params object[] args)
        {
            if (!IsTraceEnabled) return;
            var logEvent = GetLogEvent(LoggerName, LogLevel.Trace, exception, format, args);
            Log(typeof (LoggingService), logEvent);
        }

        public void Warn(Exception exception, string format, params object[] args)
        {
            if (!IsWarnEnabled) return;
            var logEvent = GetLogEvent(LoggerName, LogLevel.Warn, exception, format, args);
            Log(typeof (LoggingService), logEvent);
        }

        public void Debug(Exception exception)
        {
            Debug(exception, string.Empty);
        }

        public void Error(Exception exception)
        {
            Error(exception, string.Empty);
        }

        public void Fatal(Exception exception)
        {
            Fatal(exception, string.Empty);
        }

        public void Info(Exception exception)
        {
            Info(exception, string.Empty);
        }

        public void Trace(Exception exception)
        {
            Trace(exception, string.Empty);
        }

        public void Warn(Exception exception)
        {
            Warn(exception, string.Empty);
        }

        private LogEventInfo GetLogEvent(string loggerName, LogLevel level, Exception exception, string format,
            object[] args)
        {
            var assemblyProp = string.Empty;
            var classProp = string.Empty;
            var methodProp = string.Empty;
            var messageProp = string.Empty;
            var innerMessageProp = string.Empty;

            var logEvent = new LogEventInfo
                (level, loggerName, string.Format(format, args));

            if (exception != null)
            {
                assemblyProp = exception.Source;
                classProp = exception.TargetSite.DeclaringType.FullName;
                methodProp = exception.TargetSite.Name;
                messageProp = exception.Message;
                logEvent.Exception = exception;

                if (exception.InnerException != null)
                {
                    innerMessageProp = exception.InnerException.Message;
                }
            }

            logEvent.Properties["error-source"] = assemblyProp;
            logEvent.Properties["error-class"] = classProp;
            logEvent.Properties["error-method"] = methodProp;
            logEvent.Properties["error-message"] = messageProp;
            logEvent.Properties["inner-error-message"] = innerMessageProp;

            return logEvent;
        }
    }
}