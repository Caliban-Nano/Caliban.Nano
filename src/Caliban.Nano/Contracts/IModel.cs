﻿using System.ComponentModel;

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

        /// <summary>
        /// (Awaitable) Loads the model and resets changed state.
        /// </summary>
        /// <returns>True if loading was successful; otherwise false.</returns>
        Task<bool> Load();

        /// <summary>
        /// (Awaitable) Saves the model and resets changed state.
        /// </summary>
        /// <returns>True if saving was successful; otherwise false.</returns>
        Task<bool> Save();
    }
}
