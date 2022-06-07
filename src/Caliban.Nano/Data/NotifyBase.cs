using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Caliban.Nano.Data
{
    /// <summary>
    /// Chainable implementation of the INotifyPropertyChanged interface.
    /// </summary>
    public abstract class NotifyBase : INotifyPropertyChanged
    {
        /// <inheritdoc />
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Notifies clients that a property value has changed.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        protected virtual void NotifyPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(e.PropertyName));
        }

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

        /// <summary>
        /// Sets the value of a property and notifies.
        /// </summary>
        /// <typeparam name="T">The property type.</typeparam>
        /// <param name="field">The inner field.</param>
        /// <param name="value">The property value.</param>
        /// <param name="name">The property name.</param>
        /// <param name="others">Other names to notify about.</param>
        /// <returns>True if the value could be set; otherwise false.</returns>
        protected virtual bool SetProperty<T>(ref T field, T value, [CallerMemberName] string? name = null, params string[] others)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
            {
                return false; // Nothing changed
            }

            field = value;

            NotifyPropertyChanged(name);

            foreach (var other in others)
            {
                NotifyPropertyChanged(other);
            }

            return true;
        }
    }
}
