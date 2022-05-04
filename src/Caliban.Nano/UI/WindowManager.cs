using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using Caliban.Nano.Contracts;

namespace Caliban.Nano.UI
{
    /// <summary>
    /// A window manager for single window applications.
    /// </summary>
    public static class WindowManager
    {
        /// <summary>
        /// Creates and shows the specified view model as the main window.
        /// </summary>
        /// <typeparam name="T">The view model type.</typeparam>
        /// <param name="settings">The window settings.</param>
        /// <returns>An asynchronous task.</returns>
        [ExcludeFromCodeCoverage]
        public static async Task ShowWindowAsync<T>(Dictionary<string, object>? settings = null) where T : IViewModel
        {
            var viewModel = IoC.Get<T>();
            var view = (Window)viewModel.View;

            Application.Current.MainWindow = view;

            if (settings is not null)
            {
                foreach (var (key, value) in settings)
                {
                    typeof(Window).GetProperty(key)?.SetValue(view, value);
                }
            }

            if (viewModel is IWindow window)
            {
                view.Title = window.DisplayName;
            }

            view.Closing += OnWindowClosing;

            if (await viewModel.OnActivate())
            {
                view.Show();
            }
        }

        /// <summary>
        /// Tries to close the main window.
        /// </summary>
        /// <returns>An asynchronous task.</returns>
        [ExcludeFromCodeCoverage]
        public static async Task CloseWindowAsync()
        {
            var view = Application.Current.MainWindow;

            if (view.DataContext is IViewModel viewModel)
            {
                if (await viewModel.OnDeactivate())
                {
                    view.Close();
                }
            }                        
        }

        private static void OnWindowClosing(object? sender, CancelEventArgs e)
        {
            if ((sender as Window)?.DataContext is IViewModel viewModel)
            {
                e.Cancel = !viewModel.CanClose;
            };
        }
    }
}
