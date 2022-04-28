using System.Diagnostics.CodeAnalysis;

namespace Caliban.Nano.Contracts
{
    /// <summary>
    /// An interface for a type separated event aggregator.
    /// </summary>
    public interface IEventAggregator : IDisposable
    {
        /// <summary>
        /// Returns true if a handler is subscribed to the type.
        /// </summary>
        /// <typeparam name="T">The message type.</typeparam>
        /// <returns>True if the type has a handler.</returns>
        bool HasHandler<T>();

        /// <summary>
        /// Subscribes a handler to a type.
        /// </summary>
        /// <typeparam name="T">The message type.</typeparam>
        /// <param name="handler">The event handler.</param>
        void Subscribe<T>([NotNull] object handler);

        /// <summary>
        /// Unsubscribes a handler from a type.
        /// </summary>
        /// <typeparam name="T">The message type.</typeparam>
        /// <param name="handler">The event handler.</param>
        void Unsubscribe<T>([NotNull] object handler);

        /// <summary>
        /// Publishes a message to all subscribed handlers.
        /// </summary>
        /// <typeparam name="T">The message type.</typeparam>
        /// <param name="message">The message.</param>
        void Publish<T>(T message) where T : notnull;
    }
}
