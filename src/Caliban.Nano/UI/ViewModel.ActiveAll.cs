using System.Collections.ObjectModel;
using Caliban.Nano.Contracts;

namespace Caliban.Nano.UI
{
    public abstract partial class ViewModel
    {
        /// <summary>
        /// A composition conductor for multiple active view models.
        /// </summary>
        public abstract class ActiveAll : ViewModel
        {
            /// <summary>
            /// Occures when the active item changed.
            /// </summary>
            public event Action<IViewModel> ActiveChanged;

            /// <summary>
            /// Active child view model items.
            /// </summary>
            public IEnumerable<IViewModel> ActiveItems => Items.Where(x => x.IsActive);

            /// <summary>
            /// Collection of child view model items.
            /// </summary>
            public ObservableCollection<IViewModel> Items { get; private set; } = new();

            /// <summary>
            /// Initializes a new instance of this class with bounded event.
            /// </summary>
            public ActiveAll()
            {
                ActiveChanged += (_) => NotifyPropertyChanged(() => ActiveItems);
            }

            /// <summary>
            /// Activates the given view model item (async).
            /// </summary>
            /// <param name="item">The view model item.</param>
            /// <returns>True if the activation was successful.</returns>
            public virtual async Task<bool> ActivateItem(IViewModel item)
            {
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
            /// Deactivates the given view model item (async).
            /// </summary>
            /// <param name="item">The view model item.</param>
            /// <param name="close">If the item should be removed.</param>
            /// <returns>True if the deactivation was successful.</returns>
            public virtual async Task<bool> DeactivateItem(IViewModel item, bool close = false)
            {
                if (!await item.OnDeactivate())
                {
                    return false;
                }

                if (close)
                {
                    Items.Remove(item);
                }
        
                ActiveChanged.Invoke(item);

                return true;
            }
        }
    }
}
