using System.Diagnostics.CodeAnalysis;

namespace Caliban.Nano.Contracts
{
    /// <summary>
    /// An interface for a minimal dependency injection container.
    /// </summary>
    public interface IContainer : IDisposable
    {
        /// <summary>
        /// Occures when an object is resolved.
        /// </summary>
        event Action<object>? Resolved;

        /// <summary>
        /// Resolves a bound type by returning an existing instance or creating a new one.
        /// </summary>
        /// <typeparam name="T">The type.</typeparam>
        /// <returns>The bound or created instance.</returns>
        /// <exception cref="TypeLoadException">Thrown if the type could not be created.</exception>
        object Resolve<T>();

        /// <summary>
        /// Resolves a bound type by returning an existing instance or creating a new one.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>The bound or created instance.</returns>
        /// <exception cref="TypeLoadException">Thrown if the type could not be created.</exception>
        object Resolve([NotNull] Type type);

        /// <summary>
        /// Returns if the type can be resolved.
        /// </summary>
        /// <typeparam name="T">The type.</typeparam>
        /// <returns>True if the type can be resolved; otherwise false.</returns>
        bool CanResolve<T>();

        /// <summary>
        /// Returns a new type instance.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>The created instance.</returns>
        /// <exception cref="TypeLoadException">Thrown if the type could not be created.</exception>
        object Create([NotNull] Type type);

        /// <summary>
        /// Builds up an instance.
        /// </summary>
        /// <param name="instance">The instance.</param>
        void Build([NotNull] object instance);

        /// <summary>
        /// Binds the type to the type or instance.
        /// </summary>
        /// <typeparam name="T">The type.</typeparam>
        /// <param name="object">The type or instance.</param>
        void Bind<T>([NotNull] object @object);

        /// <summary>
        /// Unbinds the type.
        /// </summary>
        /// <typeparam name="T">The type.</typeparam>
        void Unbind<T>();
    }
}
