using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using Caliban.Nano.Contracts;

namespace Caliban.Nano.UI
{
    /// <summary>
    /// A primitive window manager for single window applications.
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
        public static async Task ShowAsync<T>(Dictionary<string, object>? settings = null) where T : IViewModel
        {
            var window = CreateWindow<T>();

            if (settings is not null)
            {
                foreach (var (key, value) in settings)
                {
                    typeof(Window).GetProperty(key)?.SetValue(window, value);
                }
            }

            Application.Current.MainWindow = window;

            await ShowWindowAsync(window);
        }

        /// <summary>
        /// (Awaitable) Forces closing of the main window.
        /// </summary>
        /// <returns>An asynchronous task.</returns>
        [ExcludeFromCodeCoverage]
        public static async Task CloseAsync()
        {
            await CloseWindowAsync(Application.Current.MainWindow, true);
        }

        /// <summary>
        /// Returns a new window.
        /// </summary>
        /// <typeparam name="T">The view model type.</typeparam>
        /// <returns>The created window.</returns>
        [ExcludeFromCodeCoverage]
        public static Window CreateWindow<T>() where T : IViewModel
        {
            var viewModel = (T)IoC.Container.Create(typeof(T));

            return viewModel.ViewAs<Window>();
        }

        /// <summary>
        /// (Awaitable) Shows the specified window.
        /// </summary>
        /// <param name="window">The window.</param>
        /// <returns>An asynchronous task.</returns>
        [ExcludeFromCodeCoverage]
        public static async Task ShowWindowAsync(Window window)
        {
            var viewModel = (IViewModel)window.DataContext;

            window.Closing += ClosingGuard;

            if (viewModel is IWindow wnd)
            {
                window.Title = wnd.DisplayName;
            }

            if (await viewModel.OnActivate())
            {
                window.Show();
            }
        }

        /// <summary>
        /// (Awaitable) Closes the given window.
        /// </summary>
        /// <param name="window">The window.</param>
        /// <param name="force">Forces the window to close.</param>
        /// <returns>An asynchronous task.</returns>
        [ExcludeFromCodeCoverage]
        public static async Task CloseWindowAsync(Window window, bool force = false)
        {
            if (window.DataContext is IViewModel viewModel)
            {
                if (await viewModel.OnDeactivate() || force)
                {
                    window.Closing -= ClosingGuard;
                    window.Close();
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
