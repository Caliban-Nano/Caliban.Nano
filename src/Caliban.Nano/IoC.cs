namespace Caliban.Nano
{
    /// <summary>
    /// An implementation of the service locator pattern.
    /// </summary>
    public static class IoC
    {
        /// <summary>
        /// The internal service resolve method (must be initialized).
        /// </summary>
        internal static Func<object, object> Resolve =
            _ => throw new NotImplementedException();

        /// <summary>
        /// Locates a service for the requested type.
        /// </summary>
        /// <typeparam name="T">The requested type.</typeparam>
        /// <returns>The located service.</returns>
        public static T Get<T>()
        {
            return (T)Resolve(typeof(T));
        }
    }
}
