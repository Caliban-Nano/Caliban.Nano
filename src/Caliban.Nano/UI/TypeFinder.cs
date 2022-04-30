using System.Reflection;
using System.Text.RegularExpressions;

namespace Caliban.Nano.UI
{
    /// <summary>
    /// A very optimistic type finder.
    /// </summary>
    public static class TypeFinder
    {
        /// <summary>
        /// List of known assemblies.
        /// </summary>
        public static readonly List<Assembly> Sources
            = new() { typeof(TypeFinder).Assembly };

        /// <summary>
        /// Type name transformation rule.
        /// </summary>
        public static Func<string, string> Rule { get; set; }
            = name => Regex.Replace(name, @"(View)(Model)?$", "");

        /// <summary>
        /// Returns a view model instance for the requested type.
        /// </summary>
        /// <param name="type">The view model type.</param>
        /// <returns>A view model instance.</returns>
        public static object FindViewModel(Type type)
            => FindType(Rule(type.Name) + "ViewModel");

        /// <summary>
        /// Returns a view instance for the requested type.
        /// </summary>
        /// <param name="type">The view type.</param>
        /// <returns>A view instance.</returns>
        public static object FindView(Type type)
            => FindType(Rule(type.Name) + "View");

        /// <summary>
        /// Returns an injected instance for the requested type.
        /// </summary>
        /// <param name="name">The type name.</param>
        /// <returns>An injected instance.</returns>
        /// <exception cref="TypeLoadException">Thrown if the type could not be loaded.</exception>
        public static object FindType(string name)
        {
            var type = Sources
                .SelectMany(x => x.GetTypes())
                .Where(x => x.Name == name)
                .Where(x => x.IsClass)
                .FirstOrDefault();

            if (type is null)
            {
                throw new TypeLoadException($"Type {name} could not be found");
            }

            return IoC.Resolve(type);
        }
    }
}
