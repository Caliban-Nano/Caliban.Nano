using System.Diagnostics.CodeAnalysis;

namespace Caliban.Nano.Contracts
{
    /// <summary>
    /// An interface for a minimal dependency injection container.
    /// </summary>
    public interface IContainer : IDisposable
    {
        /// <summary>
        /// Occures when an instance is resolved.
        /// </summary>
        event Action<object>? Resolved;

        /// <summary>
        /// Resolves a registered instance or creates a new if none is registered.
        /// </summary>
        /// <typeparam name="T">The type.</typeparam>
        /// <returns>The resolved or created instance.</returns>
        /// <exception cref="TypeLoadException">Thrown if the type could not be loaded.</exception>
        object Resolve<T>();

        /// <summary>
        /// Resolves a registered instance or creates a new if none is registered.
        /// </summary>
        /// <param name="request">The requested type.</param>
        /// <returns>The resolved or created instance.</returns>
        /// <exception cref="TypeLoadException">Thrown if the request could not be loaded.</exception>
        object Resolve([NotNull] object request);

        /// <summary>
        /// Registers an instance for a type.
        /// </summary>
        /// <typeparam name="T">The type.</typeparam>
        /// <param name="instance">The instance.</param>
        void Register<T>([NotNull] object instance);

        /// <summary>
        /// Returns true if the type is registered.
        /// </summary>
        /// <typeparam name="T">The type.</typeparam>
        /// <returns>True if the type is registered.</returns>
        bool IsRegistered<T>();

        /// <summary>
        /// Unregisters all instances from a type.
        /// </summary>
        /// <typeparam name="T">The type.</typeparam>
        void Unregister<T>();
    }
}
