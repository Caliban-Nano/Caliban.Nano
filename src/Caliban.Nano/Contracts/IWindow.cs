namespace Caliban.Nano.Contracts
{
    /// <summary>
    /// A basic interface for top level windows.
    /// </summary>
    public interface IWindow
    {
        /// <summary>
        /// The name to display as the window title.
        /// </summary>
        string DisplayName { get; }
    }
}
