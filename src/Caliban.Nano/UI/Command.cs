using System.Windows.Input;

namespace Caliban.Nano.UI
{
    /// <summary>
    /// A functional relay command.
    /// </summary>
    public class Command<T> : ICommand
    {
        private readonly Action<T?> _action;
        private readonly Func<T?, bool> _guard;

        /// <summary>
        /// Initializes a new instance of this class.
        /// </summary>
        /// <param name="action">The execute action.</param>
        public Command(Action<T?> action)
            : this(action, (_) => true) { }

        /// <summary>
        /// Initializes a new instance of this class.
        /// </summary>
        /// <param name="action">The execute action.</param>
        /// <param name="guard">The guard function.</param>
        public Command(Action<T?> action, Func<T?, bool> guard)
        {
            _action = action;
            _guard = guard;
        }

        /// <inheritdoc />
        public virtual event EventHandler? CanExecuteChanged
        {
            add    => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        /// <summary>
        /// Raises the CanExecuteChanged event.
        /// </summary>
        public virtual void RaiseCanExecuteChanged()
        {
            CommandManager.InvalidateRequerySuggested();
        }

        /// <inheritdoc />
        public virtual bool CanExecute(object? parameter)
        {
            return _guard((T?)parameter);
        }

        /// <inheritdoc />
        public virtual void Execute(object? parameter)
        {
            _action((T?)parameter);
        }
    }
}
