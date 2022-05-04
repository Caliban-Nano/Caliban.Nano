using System.Diagnostics.CodeAnalysis;
using Caliban.Nano.Contracts;

namespace Caliban.Nano.Events.EventLogger
{
    /// <summary>
    /// An event logger mixin.
    /// </summary>
    public static class EventLogger
    {
        /// <summary>
        /// Raises a log event for a specified log message.
        /// </summary>
        /// <param name="logger">The logger instance.</param>
        /// <param name="message">The log message.</param>
        public static void Raise(this ILogger _, [NotNull] string message)
        {
            try
            {
                IoC.Get<IEventAggregator>().Publish(new LogEvent(message));
            }
            catch (TypeLoadException)
            {
                Log.This($"{nameof(IEventAggregator)} could not be resolved");
            }
        }
    }
}
