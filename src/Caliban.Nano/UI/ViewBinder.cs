using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;

namespace Caliban.Nano.UI
{
    /// <summary>
    /// A recursive view to view model binder.
    /// </summary>
    public static class ViewBinder
    {
        /// <summary>
        /// Resolver method signature.
        /// </summary>
        /// <param name="target">The target element.</param>
        /// <param name="source">The source object.</param>
        /// <returns>True if resolving should continue.</returns>
        public delegate bool Resolver(FrameworkElement target, object source);

        /// <summary>
        /// Scope of all used resolvers.
        /// </summary>
        public static readonly List<(Type, Resolver)> Scope = new();

        /// <summary>
        /// Initializes this class with the default bindings.
        /// </summary>
        static ViewBinder()
        {
            Bindings.Default();
        }

        /// <summary>
        /// Adds a resolver to the scope.
        /// </summary>
        /// <typeparam name="T">The control type.</typeparam>
        /// <param name="resolver">The resolver method.</param>
        public static void AddResolver<T>(Resolver resolver) where T : FrameworkElement
        {
            Scope.Add((typeof(T), resolver));
        }

        /// <summary>
        /// Recursive binds a view to a view model.
        /// </summary>
        /// <param name="view">The view to bind.</param>
        /// <param name="viewModel">The view model to bind.</param>
        [ExcludeFromCodeCoverage]
        public static void Bind([NotNull] object view, [NotNull] object viewModel)
        {
            if (view is FrameworkElement element)
            {
                element.DataContext = viewModel;

                Resolve(element, viewModel);

                foreach (var child in LogicalTreeHelper.GetChildren(element))
                {
                    Bind(child, viewModel);
                }
            }
        }

        [ExcludeFromCodeCoverage]
        private static void Resolve(FrameworkElement target, object source)
        {
            if (string.IsNullOrWhiteSpace(target.Name))
            {
                return;
            }

            var resolvers = Scope
                .Where(x => target.GetType().IsAssignableTo(x.Item1))
                .Select(x => x.Item2);

            foreach (var resolver in resolvers)
            {
                if (!resolver(target, source))
                {
                    break;
                }
            }
        }

        internal static class Bindings
        {
            public static void Default()
            {
                AddResolver<Control>(BindGuard("IsEnabled"));
                AddResolver<Button>(BindButton());
                AddResolver<Image>(BindProperty("Source"));
                AddResolver<Label>(BindProperty("Content"));
                AddResolver<TextBox>(BindProperty("Text"));
                AddResolver<TextBlock>(BindProperty("Text"));
                AddResolver<ProgressBar>(BindProperty("Value"));
                AddResolver<CheckBox>(BindProperty("IsChecked"));
                AddResolver<RadioButton>(BindProperty("IsChecked")); 
                AddResolver<Calendar>(BindProperty("SelectedDate"));
                AddResolver<DatePicker>(BindProperty("SelectedDate"));
                AddResolver<Selector>(BindItem("SelectedItem"));
                AddResolver<ItemsControl>(BindProperty("ItemsSource"));
                AddResolver<DocumentViewer>(BindProperty("Document"));
                AddResolver<ContentControl>(BindView("Content"));
            }

            [ExcludeFromCodeCoverage]
            private static Resolver BindButton()
            {
                return (t, s) =>
                {
                    var method = s.GetType().GetMethod(t.Name);

                    if (method is not null && t is ButtonBase button)
                    {
                        button.Command = new Command<object>(
                            (_) => method.Invoke(s, null)
                        );
                    }

                    return false; // Prevent content control binding
                };
            }

            [ExcludeFromCodeCoverage]
            private static Resolver BindEvent(string name)
            {
                return (t, s) =>
                {
                    var method = s.GetType().GetMethod(t.Name);

                    if (method is not null)
                    {
                        var @event = t.GetType().GetEvent(name);

                        @event?.AddEventHandler(t, new RoutedEventHandler(
                            (sender, e) => method.Invoke(s, new[] { sender, e })
                        ));
                    }

                    return true;
                };
            }

            [ExcludeFromCodeCoverage]
            private static Resolver BindGuard(string name)
            {
                return (t, s) => Bind(t, s, name, BindingUtils.GetPathWithGuard(t.Name));
            }

            [ExcludeFromCodeCoverage]
            private static Resolver BindItem(string name)
            {
                return (t, s) => Bind(t, s, name, BindingUtils.GetPathWithItem(t.Name));
            }

            [ExcludeFromCodeCoverage]
            private static Resolver BindView(string name)
            {
                return (t, s) => Bind(t, s, name, BindingUtils.GetPathWithView(t.Name));
            }

            [ExcludeFromCodeCoverage]
            private static Resolver BindProperty(string name)
            {
                return (t, s) => Bind(t, s, name, t.Name);
            }

            [ExcludeFromCodeCoverage]
            private static bool Bind(FrameworkElement target, object source, string property, string path)
            {
                var op = source.GetType().GetProperty(path);

                if (op is null && BindingUtils.IsGuard(path))
                {
                    return true; // Pass on not existing guard properties
                }

                var dp = BindingUtils.GetDependencyProperty(property, target.GetType());

                if (BindingOperations.GetBindingExpression(target, dp) is null)
                {
                    BindingOperations.SetBinding(target, dp, new Binding()
                    {
                        Source = source,
                        Path = new PropertyPath(path),
                        Mode = op?.CanWrite ?? false
                            ? BindingMode.TwoWay
                            : BindingMode.OneWay,

                        NotifyOnSourceUpdated = true,
                        NotifyOnTargetUpdated = true,

                        UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
                    });
                }
                else
                {
                    Log.This($"Binding for {target.Name}.{property} already exists");
                }

                return true;
            }
        }

        internal static class BindingUtils
        {
            public static bool IsGuard(string path) => path.StartsWith("Can");
            public static string GetPathWithGuard(string name) => $"Can{name}";
            public static string GetPathWithItem(string name) => $"{name}Selected";
            public static string GetPathWithView(string name) => $"{name}.View";            
            public static DependencyProperty? GetDependencyProperty(string property, Type type)
                => DependencyPropertyDescriptor.FromName(property, type, type)?.DependencyProperty;
        }
    }
}
