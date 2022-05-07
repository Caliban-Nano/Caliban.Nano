using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Caliban.Nano.Container;
using Caliban.Nano.Contracts;
using Caliban.Nano.UI;

namespace Caliban.Nano
{
    /// <summary>
    /// A framework bootstrapper and livecycle manager with fluent interface.
    /// </summary>
    public sealed class Bootstrap : IDisposable
    {
        /// <summary>
        /// Used dependency injection container.
        /// </summary>
        public IContainer Container { get; init; }

        /// <summary>
        /// Initializes a new instance of this class with a specified container.
        /// </summary>
        /// <param name="container">The used container.</param>
        public Bootstrap(IContainer? container = null)
        {
            TypeFinder.Sources.Add(Assembly.GetCallingAssembly());

            Container = container ?? new NanoContainer();

            IoC.Resolve = Container.Resolve;
        }

        /// <summary>
        /// Adds an assembly to the type finder.
        /// </summary>
        /// <param name="assembly">The new assembly.</param>
        /// <returns>The bootstrap instance.</returns>
        public Bootstrap AddSource([NotNull] Assembly assembly)
        {
            TypeFinder.Sources.Add(assembly);

            return this;
        }   

        /// <summary>
        /// Registers an instance for a type at the used container.
        /// </summary>
        /// <typeparam name="T">The type.</typeparam>
        /// <param name="instance">The instance.</param>
        /// <returns>The bootstrap instance.</returns>
        public Bootstrap Register<T>([NotNull] object instance)
        {
            Container.Register<T>(instance);

            return this;
        }

        /// <summary>
        /// Shows the view model as main window via the window manager.
        /// </summary>
        /// <typeparam name="T">The view model type.</typeparam>
        /// <param name="settings">The window settings.</param>
        [ExcludeFromCodeCoverage]
        [SuppressMessage("Performance", "CA1822", Justification = "Intended Behavior")]
        public async void Show<T>(Dictionary<string, object>? settings = null) where T : IViewModel
        {
            await WindowManager.ShowWindowAsync<T>(settings);
        }

        /// <summary>
        /// Closes the main window via the window manager. 
        /// </summary>
        [ExcludeFromCodeCoverage]
        [SuppressMessage("Performance", "CA1822", Justification = "Intended Behavior")]
        public async void Dispose()
        {
            await WindowManager.CloseWindowAsync(true);
        }
    }
}
