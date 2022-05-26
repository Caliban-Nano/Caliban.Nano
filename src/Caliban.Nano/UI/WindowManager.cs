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
        /// (Awaitable) Creates and shows the specified view model as the main window.
        /// </summary>
        /// <typeparam name="T">The view model type.</typeparam>
        /// <param name="settings">The window settings.</param>
        /// <returns>An asynchronous task.</returns>
        [ExcludeFromCodeCoverage]
        public static async Task ShowWindowAsync<T>(Dictionary<string, object>? settings = null) where T : IViewModel
        {
            var viewModel = (T)IoC.Container.Create(typeof(T));
            var view = viewModel.ViewAs<Window>();

            Application.Current.MainWindow = view;

            view.Closing += ClosingGuard;

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

            if (await viewModel.OnActivate())
            {
                view.Show();
            }
        }

        /// <summary>
        /// (Awaitable) Tries to close the main window.
        /// </summary>
        /// <param name="force">Forces the window to close.</param>
        /// <returns>An asynchronous task.</returns>
        [ExcludeFromCodeCoverage]
        public static async Task CloseWindowAsync(bool force = true)
        {
            var view = Application.Current.MainWindow;

            if (view.DataContext is IViewModel viewModel)
            {
                if (await viewModel.OnDeactivate() || force)
                {
                    view.Closing -= ClosingGuard;
                    view.Close();
                }
            }                        
        }

        [ExcludeFromCodeCoverage]
        private static void ClosingGuard(object? sender, CancelEventArgs e)
        {
            if ((sender as Window)?.DataContext is IViewModel viewModel)
            {
                viewModel.OnDeactivate().Wait();

                e.Cancel = !viewModel.CanClose;
            };
        }
    }
}
