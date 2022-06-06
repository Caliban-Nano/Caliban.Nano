namespace Caliban.Nano.Contracts
{
    /// <summary>
    /// A basic interface for all repositories.
    /// </summary>
    public interface IRepository
    {
        /// <summary>
        /// If the repository was requested.
        /// </summary>
        event Action<IModel> Requested;

        /// <summary>
        /// If the repository was persisted.
        /// </summary>
        event Action<IModel> Persisted;

        /// <summary>
        /// (Awaitable) Loads the model and resets changed state.
        /// </summary>
        /// <param name="key">The models key.</param>
        /// <returns>An asynchronous task.</returns>
        Task Request(object? key = null);

        /// <summary>
        /// (Awaitable) Saves the model and resets changed state.
        /// </summary>
        /// <param name="key">The models key.</param>
        /// <returns>An asynchronous task.</returns>
        Task Persist(object? key = null);
    }
}
