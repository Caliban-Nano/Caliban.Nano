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
        object View { get; }

        /// <summary>
        /// If this view model is active.
        /// </summary>
        bool IsActive { get; }

        /// <summary>
        /// If this view model can be closed.
        /// </summary>
        bool CanClose { get; }

        /// <summary>
        /// Executed asynchronously on activation.
        /// </summary>
        /// <returns>True if activation was successful.</returns>
        Task<bool> OnActivate();

        /// <summary>
        /// Executed asynchronously on deactivation.
        /// </summary>
        /// <returns>True if deactivation was successful.</returns>
        Task<bool> OnDeactivate();
    }
}
