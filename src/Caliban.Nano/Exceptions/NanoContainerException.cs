namespace Caliban.Nano.Exceptions
{
    /// <summary>
    /// A framework specific container exception.
    /// </summary>
    public class NanoContainerException : Exception
    {
        /// <summary>
        /// Initializes a new instance of this class.
        /// </summary>
        public NanoContainerException() { }

        /// <summary>
        /// Initializes a new instance of this class with a specified error message.
        /// </summary>
        /// <param name="message">The error message.</param>
        public NanoContainerException(string? message)
            : base(message) { }

        /// <summary>
        /// Initializes a new instance of this class with a specified error message and an inner exception.
        /// </summary>
        /// <param name="message">The error message.</param>
        /// <param name="inner">The inner exception.</param>
        public NanoContainerException(string? message, Exception? inner)
            : base(message, inner) { }
    }
}
