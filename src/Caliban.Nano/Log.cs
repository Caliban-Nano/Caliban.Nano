using System.Diagnostics;
using Caliban.Nano.Contracts;

namespace Caliban.Nano
{
    /// <summary>
    /// A logger facade with a default debugging logger.
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
        /// Logs an internal message.
        /// </summary>
        /// <param name="message">The message.</param>
        public static void Intern(string message)
        {
            Logger.Info($"[caliban.nano] {message}");
        }
    }

    /// <summary>
    /// An internal trace logger implementing ILogger.
    /// </summary>
    internal sealed class TraceLogger : ILogger
    {
        public void Info(string message)
            => Trace.WriteLine($"[info] {message}");

        public void Warn(string message)
            => Trace.WriteLine($"[warn] {message}");

        public void Error(string message)
            => Trace.WriteLine($"[error] {message}");

        public void Error(string format, params object[] args)
            => Trace.WriteLine($"[error] {string.Format(format, args)}");

        public void Error(Exception exception)
            => Trace.WriteLine($"[error] {exception.Message}");

        public void Error(Exception exception, string format, params object[] args)
            => Trace.WriteLine($"[error] {exception.Message}: {string.Format(format, args)}");
    }
}
