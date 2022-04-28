namespace Caliban.Nano.Contracts
{
    /// <summary>
    /// An interface for a general type separated message handler.
    /// </summary>
    /// <typeparam name="T">The message type.</typeparam>
    public interface IHandle<T>
    {
        /// <summary>
        /// Handle the incoming message according to its type.
        /// </summary>
        /// <param name="message">The message.</param>
        void Handle(T message);
    }
}
