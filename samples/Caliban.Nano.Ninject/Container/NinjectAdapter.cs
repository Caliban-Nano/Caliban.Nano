using System;
using System.Diagnostics.CodeAnalysis;
using Caliban.Nano.Contracts;
using Ninject;

namespace Caliban.Nano.Ninject.Container
{
    /// <summary>
    /// A Ninject kernel adapter.
    /// </summary>
    public sealed class NinjectAdapter : IContainer
    {
        /// <inheritdoc />
        public event Action<object>? Resolved;

        private readonly IKernel _kernel = new StandardKernel();

        /// <summary>
        /// Initializes a new self bound instance of this class.
        /// </summary>
        public NinjectAdapter()
        {
            _kernel.Bind<IContainer>().ToSelf();
        }

        /// <summary>
        /// Clears the container bindings on dispose.
        /// </summary>
        public void Dispose()
        {
            if (!_kernel.IsDisposed)
            {
                _kernel.Dispose();
            }
        }

        /// <inheritdoc />
        public object Resolve<T>() where T : class
        {
            return Resolve(typeof(T));
        }

        /// <inheritdoc />
        public object Resolve([NotNull] Type type)
        {
            if (!_kernel.CanResolve(type))
            {
                throw new TypeLoadException($"Type {type.Name} could not resolved");
            }

            var instance = Create(type);

            Resolved?.Invoke(instance);

            return instance;
        }

        /// <inheritdoc />
        public bool CanResolve<T>() where T : class
        {
            return _kernel.CanResolve<T>();
        }

        /// <inheritdoc />
        public object Create([NotNull] Type type)
        {
            var instance = _kernel.Get(type);

            if (instance is null)
            {
                throw new TypeLoadException($"Type {type.Name} could not created");
            }

            Build(instance);

            return instance;
        }

        /// <inheritdoc />
        public void Build([NotNull] object instance)
        {
            _kernel.Inject(instance);
        }

        /// <inheritdoc />
        public void Bind<T>([NotNull] object @object) where T : class
        {
            if (@object is Type type)
            {
                _kernel.Bind<T>().To(type);
            }
            else
            {
                _kernel.Bind<T>().ToConstant((T)@object);
            }
        }

        /// <inheritdoc />
        public void Unbind<T>() where T : class
        {
            _kernel.Unbind<T>();
        }
    }
}
