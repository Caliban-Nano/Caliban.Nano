using Caliban.Nano.Contracts;

namespace Caliban.Nano.UI
{
    /// <summary>
    /// A base view model using the composition pattern.
    /// </summary>
    public abstract class ViewModel : Conductor, IViewModel
    {
        /// <inheritdoc />
        public object View { get; protected set; }

        /// <inheritdoc />
        public bool IsActive { get; protected set; }

        /// <inheritdoc />
        public bool CanClose { get; protected set; } = true;

        /// <summary>
        /// Initializes a new instance of this class with dependency injection and binding.
        /// </summary>
        public ViewModel()
        {
            IoC.Resolve(this);

            ViewBinder.Bind(View = TypeFinder.FindView(GetType()), this);
        }

        /// <inheritdoc />
        public virtual Task<bool> OnActivate()
        {
            return Task.Run(() => IsActive = true);
        }

        /// <inheritdoc />
        public virtual Task<bool> OnDeactivate()
        {
            return Task.Run(() => !(IsActive = !CanClose));
        }
    }
}
