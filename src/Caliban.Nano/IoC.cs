using Caliban.Nano.Container;
using Caliban.Nano.Contracts;

namespace Caliban.Nano
{
    /// <summary>
    /// An implementation of the service locator pattern.
    /// </summary>
    public static class IoC
    {
        /// <summary>
        /// The internal service container.
        /// </summary>
        internal static IContainer Container { get; set; }
            = new NanoContainer();

        /// <summary>
        /// Locates a service for the given type.
        /// </summary>
        /// <typeparam name="T">The type.</typeparam>
        /// <returns>The located service.</returns>
        public static T Get<T>() where T : class
        {
            return (T)Container.Resolve(typeof(T));
        }
    }
}
