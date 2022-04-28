namespace Caliban.Nano.Events
{
    /// <summary>
    /// A simple class for raising an event externally.
    /// </summary>
    /// <typeparam name="T">The event argument type.</typeparam>
    public class EventRaiser<T>
    {
        /// <summary>
        /// Enclosed event with one argument.
        /// </summary>
        protected event Action<T>? Event;

        /// <summary>
        /// Attaches an event handler to the enclosed event.
        /// </summary>
        /// <param name="@this">The event raiser.</param>
        /// <param name="handler">The event handler.</param>
        /// <returns>Returns the given event raiser.</returns>
        public static EventRaiser<T> operator +(EventRaiser<T> @this, Action<T> handler)
        {
            @this.Event += handler;

            return @this;
        }

        /// <summary>
        /// Detaches an event handler to the enclosed event.
        /// </summary>
        /// <param name="@this">The event raiser.</param>
        /// <param name="handler">The event handler.</param>
        /// <returns>Returns the given event raiser.</returns>
        public static EventRaiser<T> operator -(EventRaiser<T> @this, Action<T> handler)
        {
            @this.Event -= handler;

            return @this;
        }

        /// <summary>
        /// Raises the enclosed event.
        /// </summary>
        /// <param name="arg">The event argument.</param>
        public void Raise(T arg)
        {
            Event?.Invoke(arg);
        }
    }
}
