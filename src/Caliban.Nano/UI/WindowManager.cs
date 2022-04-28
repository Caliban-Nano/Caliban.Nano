using System.ComponentModel;
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

            await viewModel.OnActivate();

            view.Show();
        }

        private static void OnWindowClosing(object? sender, CancelEventArgs e)
        {
            var viewModel = (sender as Window)?.DataContext as IViewModel;

            e.Cancel = !viewModel?.CanClose ?? true;
        }
    }
}
