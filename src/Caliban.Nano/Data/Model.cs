using System.ComponentModel;
using System.Runtime.CompilerServices;
using Caliban.Nano.Contracts;

namespace Caliban.Nano.Data
{
    /// <summary>
    /// A base model.
    /// </summary>
    public abstract partial class Model : IModel
    {
        /// <inheritdoc />
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <inheritdoc />
        public bool HasChanged { get; protected set; } = false;

        /// <summary>
        /// The internal value storage.
        /// </summary>
        protected Dictionary<string, object?> _values = new();

        /// <summary>
        /// Initializes a new instance of this class.
        /// </summary>
        public Model()
        {
            PropertyChanged += (_, _) => HasChanged = true;
        }

        /// <summary>
        /// Gets a model value.
        /// </summary>
        /// <typeparam name="T">The value type.</typeparam>
        /// <param name="name">The value key.</param>
        /// <returns>The model value.</returns>
        protected virtual T? Get<T>([CallerMemberName] string? name = null)
        {
            ArgumentNullException.ThrowIfNull(name, nameof(name));

            lock (_values)
            {
                if (_values.TryGetValue(name, out object? value))
                {
                    return (T?)value;
                }
                else
                {
                    return default;
                }
            }
        }

        /// <summary>
        /// Sets a model value.
        /// </summary>
        /// <typeparam name="T">The value type.</typeparam>
        /// <param name="value">The model value.</param>
        /// <param name="name">The value key.</param>
        /// <param name="others">Other names to notify about.</param>
        protected virtual void Set<T>(T value, [CallerMemberName] string? name = null, params string[] others)
        {
            ArgumentNullException.ThrowIfNull(name, nameof(name));

            if (!EqualityComparer<T>.Default.Equals(Get<T>(name), value))
            {
                lock (_values)
                {
                    _values[name] = value;
                }

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

                foreach (var other in others)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(other));
                }
            }
        }
    }
}
