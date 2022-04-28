using System.Reflection;
using System.Text.RegularExpressions;
using Caliban.Nano.Exceptions;

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
        public static readonly List<Assembly> Assemblies
            = new() { typeof(TypeFinder).Assembly };

        /// <summary>
        /// List of known namespaces.
        /// </summary>
        public static readonly List<string> Namespaces
            = new() { "Caliban.Nano" };

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
        /// <exception cref="TypeNotFoundException">Thrown if the type could not be found.</exception>
        public static object FindType(string name)
        {
            foreach (var assembly in Assemblies)
            {
                foreach (var @namespace in Namespaces)
                {
                    var type = assembly.GetType($"{@namespace}.{name}");

                    if (type is not null)
                    {
                        return IoC.Resolve(type);
                    }
                }
            }

            throw new TypeNotFoundException(name);
        }
    }
}
