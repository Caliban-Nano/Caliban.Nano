using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Caliban.Nano.UI
{
    /// <summary>
    /// Base implementation of the INotifyPropertyChanged interface.
    /// </summary>
    public abstract class NotifyBase : INotifyPropertyChanged
    {
        /// <inheritdoc />
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Notifies clients that a property value has changed.
        /// </summary>
        /// <param name="name">The property name.</param>
        protected virtual void NotifyPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        /// <summary>
        /// Notifies clients that a property value has changed.
        /// </summary>
        /// <typeparam name="T">The property type.</typeparam>
        /// <param name="property">The property name.</param>
        protected virtual void NotifyPropertyChanged<T>(Expression<Func<T>> property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property.Name));
        }
    }
}
