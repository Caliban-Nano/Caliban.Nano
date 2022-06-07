using System.Collections.ObjectModel;
using Caliban.Nano.Contracts;

namespace Caliban.Nano.UI
{
    public abstract partial class ViewModel
    {
        /// <summary>
        /// A composition conductor for multiple active view models.
        /// </summary>
        public abstract class Multiple : ViewModel, IParent
        {
            /// <inheritdoc />
            public event Action<IViewModel> ActiveChanged;

            /// <summary>
            /// Active child view model items.
            /// </summary>
            public IEnumerable<IViewModel> ActiveItems => Items.Where(x => x.IsActive);

            /// <inheritdoc />
            public ObservableCollection<IViewModel> Items { get; protected set; } = new();

            /// <summary>
            /// Initializes a new instance of this class with bounded event.
            /// </summary>
            /// <param name="parent">The optional parent view model.</param>
            public Multiple(IViewModel? parent = null) : base(parent)
            {
                ActiveChanged += (_) => NotifyPropertyChanged(() => ActiveItems);
            }

            /// <inheritdoc />
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

            /// <inheritdoc />
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
