using System.Windows;
using Caliban.Nano.Contracts;

namespace Caliban.Nano.NLog
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static string? Name => typeof(App).Namespace;
        private ILogger Log { get; } = new NLogAdapter($"{Name}.log");

        void OnStartup(object sender, StartupEventArgs e)
        {
            Current.Shutdown();

            Log.Info($"{Name} has started");
        }

        void OnExit(object sender, ExitEventArgs e)
        {
            Log.Info($"{Name} has exited");
        }
    }
}
