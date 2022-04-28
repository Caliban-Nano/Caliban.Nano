namespace Caliban.Nano.Contracts
{
    /// <summary>
    /// An all-purpose logger interface as the lowest common denominator.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Logs an informal message.
        /// </summary>
        /// <param name="message">The message.</param>
        void Info(string message);

        /// <summary>
        /// Logs a warning message.
        /// </summary>
        /// <param name="message">The message.</param>
        void Warn(string message);

        /// <summary>
        /// Logs an error message.
        /// </summary>
        /// <param name="message">The message.</param>
        void Error(string message);

        /// <summary>
        /// Logs an error message.
        /// </summary>
        /// <param name="format">The message format.</param>
        /// <param name="args">The message arguments.</param>
        void Error(string format, params object[] args);

        /// <summary>
        /// Logs an occured exception.
        /// </summary>
        /// <param name="exception">The occured exception.</param>
        void Error(Exception exception);

        /// <summary>
        /// Logs an occured exception with a specified message.
        /// </summary>
        /// <param name="exception">The occured exception.</param>
        /// <param name="format">The message format.</param>
        /// <param name="args">The message arguments.</param>
        void Error(Exception exception, string format, params object[] args);
    }
}
