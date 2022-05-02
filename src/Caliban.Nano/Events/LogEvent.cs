namespace Caliban.Nano.Events
{
    /// <summary>
    /// A simple log event class.
    /// </summary>
    public sealed class LogEvent
    {
        /// <summary>
        /// The log message.
        /// </summary>
        public readonly string Message;

        /// <summary>
        /// Initializes a new instance of this class with a specified log message.
        /// </summary>
        /// <param name="message">The log message.</param>
        public LogEvent(string message)
        {
            Message = message;
        }

        /// <summary>
        /// Returns the log message.
        /// </summary>
        /// <returns>The log message.</returns>
        public override string ToString()
        {
            return Message;
        }
    }
}
