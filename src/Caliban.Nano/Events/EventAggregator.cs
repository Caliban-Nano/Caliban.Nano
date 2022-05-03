using System.Diagnostics.CodeAnalysis;
using Caliban.Nano.Contracts;

namespace Caliban.Nano.Events
{
    /// <summary>
    /// A thread-safe event aggregator.
    /// </summary>
    public class EventAggregator : IEventAggregator
    {
        private readonly List<(Type, object)> _subscriptions = new();

        /// <summary>
        /// Clears all subscriptions on dispose.
        /// </summary>
        public virtual void Dispose()
        {
            lock (_subscriptions)
            {
                _subscriptions.Clear();
            }
        }

        /// <inheritdoc />
        public virtual bool HasHandler<T>()
        {
            lock (_subscriptions)
            {
                return _subscriptions.Any(s => s.Item1 == typeof(T));
            }
        }

        /// <inheritdoc />
        public virtual void Subscribe<T>([NotNull] object handler)
        {
            lock (_subscriptions)
            {
                _subscriptions.Add(new(typeof(T), handler));
            }
        }

        /// <inheritdoc />
        public virtual void Unsubscribe<T>([NotNull] object handler)
        {
            lock (_subscriptions)
            {
                _subscriptions.Remove(new(typeof(T), handler));
            }
        }

        /// <inheritdoc />
        public virtual void Publish<T>(T message) where T : notnull
        {
            IEnumerable<object> handlers;

            lock (_subscriptions)
            {
                handlers = _subscriptions
                    .Where(s => s.Item1 == typeof(T))
                    .Select(s => s.Item2);
            }

            foreach (var handler in handlers)
            {
                switch (handler)
                {
                    case IHandle<T> handle:
                        handle.Handle(message);
                        break;

                    case Action<T> action:
                        action.Invoke(message);
                        break;

                    default:
                        Log.This($"Handler {handler} is not supported");
                        break;
                }
            }
        }
    }
}
