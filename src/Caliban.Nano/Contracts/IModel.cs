using System.ComponentModel;

namespace Caliban.Nano.Contracts
{
    /// <summary>
    /// A basic interface for all models.
    /// </summary>
    public interface IModel : INotifyPropertyChanged
    {
        /// <summary>
        /// If the model has changed.
        /// </summary>
        bool HasChanged { get; }
    }
}
