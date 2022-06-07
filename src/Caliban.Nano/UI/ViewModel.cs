using Caliban.Nano.Contracts;
using Caliban.Nano.Data;

namespace Caliban.Nano.UI
{
    /// <summary>
    /// A base view model.
    /// </summary>
    public abstract partial class ViewModel : NotifyBase, IViewModel
    {
        /// <inheritdoc />
        public object? View { get; protected set; }

        /// <inheritdoc />
        public object? Model { get; protected set; }

        /// <inheritdoc />
        public bool IsActive { get; protected set; }

        /// <inheritdoc />
        public bool CanClose { get; protected set; } = true;

        /// <inheritdoc />
        public IViewModel? Parent { get; protected set; } = null;

        /// <inheritdoc />
        public T ViewAs<T>() where T : class
        {
            return View as T ?? throw new InvalidCastException($"View is not {typeof(T).Name}");
        }

        /// <inheritdoc />
        public T ModelAs<T>() where T : class
        {
            return Model as T ?? throw new InvalidCastException($"Model is not {typeof(T).Name}");
        }

        /// <summary>
        /// Initializes a new instance of this class with dependency injection and binding.
        /// </summary>
        /// <param name="parent">The optional parent view model.</param>
        public ViewModel(IViewModel? parent = null)
        {
            IoC.Container.Build(this);

            Parent = parent;

            BindToModel();
            BindToView();
        }

        /// <inheritdoc />
        public virtual Task<bool> Close()
        {
            if (Parent is IParent parent)
            {
                return parent.DeactivateItem(this, true);
            }

            return OnDeactivate();
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

        /// <summary>
        /// Binds the view model to the view.
        /// </summary>
        protected virtual void BindToView()
        {
            try
            {
                View = TypeFinder.FindView(GetType());

                ViewBinder.Bind(View, this);
            }
            catch (TypeLoadException ex)
            {
                Log.This(ex);
            }
        }

        /// <summary>
        /// Binds the view model to the model.
        /// </summary>
        protected virtual void BindToModel()
        {
            try
            {
                Model = TypeFinder.FindModel(GetType());

                if (Model is IModel model)
                {
                    model.PropertyChanged += NotifyPropertyChanged;
                }
            }
            catch (TypeLoadException)
            {
                // Not all view models have a model
            }
        }
    }
}
