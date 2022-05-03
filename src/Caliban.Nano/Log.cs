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
    }

    /// <summary>
    /// A debug trace logger implementing ILogger.
    /// </summary>
    public sealed class TraceLogger : ILogger, IHandle<LogEvent>
    {
        /// <inheritdoc />
        public void Handle(LogEvent message)
            => Trace.WriteLine($"[event] {message}");

        /// <inheritdoc />
        public void Info(string message)
            => Trace.WriteLine($"[info] {message}");

        /// <inheritdoc />
        public void Warn(string message)
            => Trace.WriteLine($"[warn] {message}");

        /// <inheritdoc />
        public void Error(string message)
            => Trace.WriteLine($"[error] {message}");

        /// <inheritdoc />
        public void Error(string format, params object[] args)
            => Trace.WriteLine($"[error] {string.Format(format, args)}");

        /// <inheritdoc />
        public void Error(Exception exception)
            => Trace.WriteLine($"[error] {exception.Message}");

        /// <inheritdoc />
        public void Error(Exception exception, string format, params object[] args)
            => Trace.WriteLine($"[error] {exception.Message}: {string.Format(format, args)}");
    }
}
