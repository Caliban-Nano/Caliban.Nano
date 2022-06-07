using System.Collections.ObjectModel;
using Caliban.Nano.Contracts;

namespace Caliban.Nano.UI
{
    public abstract partial class ViewModel
    {
        /// <summary>
        /// A composition conductor for single active view models.
        /// </summary>
        public abstract class Single : ViewModel, IParent
        {
            /// <inheritdoc />
            public event Action<IViewModel> ActiveChanged;

            /// <summary>
            /// Active child view model item.
            /// </summary>
            public IViewModel? ActiveItem => Items.FirstOrDefault(x => x.IsActive);

            /// <inheritdoc />
            public ObservableCollection<IViewModel> Items { get; protected set; } = new();

            /// <summary>
            /// Initializes a new instance of this class with bounded event.
            /// </summary>
            /// <param name="parent">The optional parent view model.</param>
            public Single(IViewModel? parent = null) : base(parent)
            {
                ActiveChanged += (_) => NotifyPropertyChanged(() => ActiveItem);
            }

            /// <inheritdoc />
            public virtual async Task<bool> ActivateItem(IViewModel item)
            {
                if (ActiveItem is not null && !await ActiveItem.OnDeactivate())
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
