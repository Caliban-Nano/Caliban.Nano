using System.Diagnostics.CodeAnalysis;
using Caliban.Nano.Contracts;

namespace Caliban.Nano.Events
{
    /// <summary>
    /// A basic event logger add-on.
    /// </summary>
    public abstract class EventLogger
    {
        /// <summary>
        /// Used event aggregator.
        /// </summary>
        public IEventAggregator? Events { get; init; }

        /// <summary>
        /// Raises a log event for a specified log message.
        /// </summary>
        /// <param name="message">The log message.</param>
        public void Raise([NotNull] string message)
        {
            Events?.Publish(new LogEvent(message));
        }
    }
}
