using Caliban.Nano.Contracts;

namespace Caliban.Nano.Data
{
    public abstract partial class Model
    {
        /// <summary>
        /// A base model repository.
        /// </summary>
        public abstract class Repository : Model, IRepository
        {
            /// <inheritdoc />
            public event Action<IModel> Requested;

            /// <inheritdoc />
            public event Action<IModel> Persisted;

            /// <summary>
            /// Initializes a new instance of this class.
            /// </summary>
            public Repository()
            {
                Requested += (_) => HasChanged = false;
                Persisted += (_) => HasChanged = false;
            }

            /// <inheritdoc />
            public virtual Task Request(object? key = null)
            {
                return Task.Run(() => Requested?.Invoke(this));
            }

            /// <inheritdoc />
            public virtual Task Persist(object? key = null)
            {
                return Task.Run(() => Persisted?.Invoke(this));
            }
        }
    }
}
