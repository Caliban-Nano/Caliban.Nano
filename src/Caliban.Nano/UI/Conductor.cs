using System.Collections.ObjectModel;
using System.Windows;
using Caliban.Nano.Contracts;

namespace Caliban.Nano.UI
{
    /// <summary>
    /// A conductor engine for single active view models.
    /// </summary>
    public abstract class Conductor : NotifyBase
    {
        /// <summary>
        /// Occures when the active item changed.
        /// </summary>
        public event Action<IViewModel> ActiveChanged;

        /// <summary>
        /// Active child view model item.
        /// </summary>
        public IViewModel? ActiveItem => Items.FirstOrDefault(x => x.IsActive);

        /// <summary>
        /// Collection of child view model items.
        /// </summary>
        public ObservableCollection<IViewModel> Items { get; private set; } = new();

        /// <summary>
        /// Initializes a new instance of this class with bounded events.
        /// </summary>
        public Conductor()
        {
            ActiveChanged += (_) => NotifyPropertyChanged(() => ActiveItem);
        }

        /// <summary>
        /// Asynchronous activates the given view model item.
        /// </summary>
        /// <param name="item">The view model item.</param>
        /// <returns>True if the activation was successful.</returns>
        public virtual async Task<bool> Activate(IViewModel item)
        {
            if (!await (ActiveItem?.OnDeactivate() ?? Task.FromResult(true)))
            {
                return false;
            }

            if (!Items.Contains(item))
            {
                Items.Add(item);
            }

            if (!await item.OnActivate())
            {
                return false;
            }

            ActiveChanged.Invoke(item);

            return true;
        }

        /// <summary>
        /// Asynchronous deactivates the given view model item.
        /// </summary>
        /// <param name="item">The view model item.</param>
        /// <param name="close">If the item should be closed and removed.</param>
        /// <returns>True if the deactivation was successful.</returns>
        public virtual async Task<bool> Deactivate(IViewModel item, bool close = false)
        {
            if (!await item.OnDeactivate())
            {
                return false;
            }

            if (close)
            {
                Items.Remove(item);

                if (item.View is Window window)
                {
                    window.Close();
                }
            }
    
            if (!await (Items.LastOrDefault()?.OnActivate() ?? Task.FromResult(true)))
            {
                return false;
            }

            ActiveChanged.Invoke(item);

            return true;
        }
    }
}
