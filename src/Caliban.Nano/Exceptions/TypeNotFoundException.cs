namespace Caliban.Nano.Exceptions
{
    /// <summary>
    /// A framework specific type not found exception.
    /// </summary>
    public class TypeNotFoundException : Exception
    {
        /// <summary>
        /// Initializes a new instance of this class.
        /// </summary>
        public TypeNotFoundException() { }

        /// <summary>
        /// Initializes a new instance of this class for a specified type.
        /// </summary>
        /// <param name="type">The type that was not found.</param>
        public TypeNotFoundException(Type type)
            : base($"Type {type.Name} not found") { }

        /// <summary>
        /// Initializes a new instance of this class for a specified type name.
        /// </summary>
        /// <param name="name">The type name that was not found.</param>
        public TypeNotFoundException(string? name)
            : base($"Type {name} not found") { }

        /// <summary>
        /// Initializes a new instance of this class for a specified type name and an inner exception.
        /// </summary>
        /// <param name="name">The type name that was not found.</param>
        /// <param name="inner">The inner exception that occured.</param>
        public TypeNotFoundException(string? name, Exception? inner)
            : base($"Type {name} not found", inner) { }
    }
}
