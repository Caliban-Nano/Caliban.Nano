namespace Caliban.Nano.Events
{
    /// <summary>
    /// A simple wrapper for raising an event externally.
    /// </summary>
    /// <typeparam name="T">The event arguments type.</typeparam>
    public class EventRaiser<T>
    {
        /// <summary>
        /// Enclosed event handler.
        /// </summary>
        /// <typeparam name="T">The event arguments type.</typeparam>
        public event EventHandler<T>? Event;

        /// <summary>
        /// Attaches an event handler to the enclosed event.
        /// </summary>
        /// <param name="@this">The event raiser.</param>
        /// <param name="handler">The event handler.</param>
        /// <typeparam name="T">The event arguments type.</typeparam>
        /// <returns>Returns the given event raiser.</returns>
        public static EventRaiser<T> operator +(EventRaiser<T> @this, EventHandler<T> handler)
        {
            @this.Event += handler;

            return @this;
        }

        /// <summary>
        /// Detaches an event handler to the enclosed event.
        /// </summary>
        /// <param name="@this">The event raiser.</param>
        /// <param name="handler">The event handler.</param>
        /// <typeparam name="T">The event arguments type.</typeparam>
        /// <returns>Returns the given event raiser.</returns>
        public static EventRaiser<T> operator -(EventRaiser<T> @this, EventHandler<T> handler)
        {
            @this.Event -= handler;

            return @this;
        }

        /// <summary>
        /// Raises the enclosed event.
        /// </summary>
        /// <param name="e">The event arguments.</param>
        public virtual void Raise(T e)
        {
            Event?.Invoke(this, e);
        }
    }
}
