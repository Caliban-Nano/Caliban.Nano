using System.Diagnostics;
using Caliban.Nano.Contracts;
using Caliban.Nano.Events;

namespace Caliban.Nano
{
    /// <summary>
    /// A logger facade with a default debug logger.
    /// </summary>
    internal static class Log
    {
        private static ILogger? _logger;
        private static ILogger Logger
        {
            get
            {
                try
                {
                    return _logger ??= IoC.Get<ILogger>();
                }
                catch (TypeLoadException)
                {
                    return _logger = new TraceLogger();
                }
            }
        }

        /// <summary>
        /// Logs a framework message.
        /// </summary>
        /// <param name="message">The message.</param>
        public static void This(string message)
        {
            Logger.Info($"[caliban.nano] {message}");
        }

        /// <summary>
        /// Logs a framework exception.
        /// </summary>
        /// <param name="exception">The exception.</param>
        public static void This(Exception exception)
        {
            Logger.Error($"[caliban.nano] {exception.Message}");
        }
    }

    /// <summary>
    /// A debug trace logger implementing ILogger.
    /// </summary>
    public sealed class TraceLogger : ILogger, IHandle<LogEvent>
    {
        /// <summary>
        /// Initializes a new instance of this class.
        /// </summary>
        public TraceLogger()
        {
            Trace.AutoFlush = true;
        }

        /// <inheritdoc />
        public void Dispose()
        {
            Trace.Close();
        }

        /// <inheritdoc />
        public void Handle(LogEvent message)
        {
            Trace.TraceInformation($"[event] {message}");
        }

        /// <inheritdoc />
        public void Info(string message)
        {
            Trace.TraceInformation($"[info] {message}");
        }

        /// <inheritdoc />
        public void Warn(string message)
        {
            Trace.TraceWarning($"[warn] {message}");
        }

        /// <inheritdoc />
        public void Error(string message)
        {
            Trace.TraceError($"[error] {message}");
        }

        /// <inheritdoc />
        public void Error(string format, params object?[] args)
        {
            Trace.TraceError($"[error] {string.Format(format, args)}");
        }
            
        /// <inheritdoc />
        public void Error(Exception exception)
        {
            Trace.TraceError($"[error] {exception.Message}");
        }

        /// <inheritdoc />
        public void Error(Exception exception, string format, params object?[] args)
        {
            Trace.TraceError($"[error] {exception.Message}: {string.Format(format, args)}");
        }
    }
}
