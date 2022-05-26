namespace Caliban.Nano.Contracts
{
    /// <summary>
    /// A basic interface for all view models.
    /// </summary>
    public interface IViewModel
    {
        /// <summary>
        /// The associated view.
        /// </summary>
        object? View { get; }

        /// <summary>
        /// The associated model.
        /// </summary>
        object? Model { get; }

        /// <summary>
        /// If this view model is active.
        /// </summary>
        bool IsActive { get; }

        /// <summary>
        /// If this view model can be closed.
        /// </summary>
        bool CanClose { get; }

        /// <summary>
        /// Returns the views as type.
        /// </summary>
        /// <typeparam name="T">The type.</typeparam>
        /// <returns>The typed view.</returns>
        /// <exception cref="InvalidCastException">Thrown if the view could not be cast.</exception>
        T ViewAs<T>() where T : class;

        /// <summary>
        /// Returns the model as type.
        /// </summary>
        /// <typeparam name="T">The type.</typeparam>
        /// <returns>The typed model.</returns>
        /// <exception cref="InvalidCastException">Thrown if the model could not be cast.</exception>
        T ModelAs<T>() where T : class;

        /// <summary>
        /// (Awaitable) Executed on activation.
        /// </summary>
        /// <returns>True if activation was successful; otherwise false.</returns>
        Task<bool> OnActivate();

        /// <summary>
        /// (Awaitable) Executed on deactivation.
        /// </summary>
        /// <returns>True if deactivation was successful; otherwise false.</returns>
        Task<bool> OnDeactivate();
    }
}
