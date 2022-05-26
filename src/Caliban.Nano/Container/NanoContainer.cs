using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Caliban.Nano.Contracts;

namespace Caliban.Nano.Container
{
    /// <summary>
    /// A thread-safe minimal dependency injection container.
    /// </summary>
    public sealed class NanoContainer : IContainer
    {
        /// <inheritdoc />
        public event Action<object>? Resolved = null;

        private readonly Dictionary<Type, object> _bindings = new();

        /// <summary>
        /// Initializes a new self bound instance of this class.
        /// </summary>
        public NanoContainer()
        {
            Bind<IContainer>(this);
        }

        /// <summary>
        /// Clears the container bindings on dispose.
        /// </summary>
        public void Dispose()
        {
            lock (_bindings)
            {
                _bindings.Clear();
            }
        }

        /// <inheritdoc />
        public object Resolve<T>()
        {
            return Resolve(typeof(T));
        }

        /// <inheritdoc />
        public object Resolve([NotNull] Type type)
        {
            if (!LockGetValue(type, out var value) || value is null)
            {
                throw new TypeLoadException($"Type {type.Name} could not resolved");
            }

            var instance = value;

            if (value is Type @class)
            {
                instance = Create(@class);
            }
            else
            {
                Build(instance);
            }

            Resolved?.Invoke(instance);

            return instance;
        }

        /// <inheritdoc />
        public bool CanResolve<T>()
        {
            lock (_bindings)
            {
                return _bindings.ContainsKey(typeof(T));
            }
        }

        /// <inheritdoc />
        public object Create([NotNull] Type type)
        {
            var ctor = SelectConstructor(type);

            if (ctor is null)
            {
                throw new TypeLoadException($"Type {type.Name} has no constructor");
            }

            var instance = ctor.Invoke(DetermineParameters(ctor));

            Build(instance);

            return instance;
        }

        /// <inheritdoc />
        public void Build([NotNull] object instance)
        {
            var properties = instance.GetType().GetProperties();

            foreach (var property in properties.Where(p => p.CanWrite))
            {
                if (LockGetValue(property.PropertyType, out var value))
                {
                    if (value is Type type)
                    {
                        value = Create(type);
                    }

                    property.SetValue(instance, value);
                }
            }
        }

        /// <inheritdoc />
        public void Bind<T>([NotNull] object @object)
        {
            lock (_bindings)
            {
                _bindings.Add(typeof(T), @object);
            }
        }

        /// <inheritdoc />
        public void Unbind<T>()
        {
            lock (_bindings)
            {
                _bindings.Remove(typeof(T));
            }
        }

        private bool LockGetValue(Type type, out object? value)
        {
            lock (_bindings)
            {
                return _bindings.TryGetValue(type, out value);
            }
        }

        private ConstructorInfo? SelectConstructor(Type type)
        {
            lock (_bindings)
            {
                return type.GetConstructors()
                    .OrderBy(c => c.GetParameters().Count(p => _bindings.ContainsKey(p.ParameterType)))
                    .LastOrDefault();
            }
        }

        private object?[] DetermineParameters(ConstructorInfo info)
        {
            lock (_bindings)
            {
                return info.GetParameters()
                    .Select(p => _bindings.ContainsKey(p.ParameterType) ? Resolve(p.ParameterType) : null)
                    .ToArray();
            }
        }
    }
}
