using System.Collections.ObjectModel;

namespace Caliban.Nano.Contracts
{
    /// <summary>
    /// An interface for all parent view models.
    /// </summary>
    public interface IParent
    {
        /// <summary>
        /// Occures when the active item changed.
        /// </summary>
        event Action<IViewModel> ActiveChanged;

        /// <summary>
        /// Collection of child view model items.
        /// </summary>
        ObservableCollection<IViewModel> Items { get; }
        
        /// <summary>
        /// (Awaitable) Activates the given view model item.
        /// </summary>
        /// <param name="item">The view model item.</param>
        /// <returns>True if the activation was successful; otherwise false.</returns>
        Task<bool> ActivateItem(IViewModel item);

        /// <summary>
        /// (Awaitable) Deactivates the given view model item.
        /// </summary>
        /// <param name="item">The view model item.</param>
        /// <param name="close">If the item should be removed.</param>
        /// <returns>True if the deactivation was successful; otherwise false.</returns>
        Task<bool> DeactivateItem(IViewModel item, bool close = false);
    }
}
