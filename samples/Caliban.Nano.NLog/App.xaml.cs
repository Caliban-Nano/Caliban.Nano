using System.Windows;
using Caliban.Nano.Contracts;
using Caliban.Nano.NLog.Logging;

namespace Caliban.Nano.NLog
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ILogger Log { get; } = new NLogAdapter($"{typeof(App).Namespace}.log");

        void OnStartup(object sender, StartupEventArgs e)
        {
            Current.Shutdown();

            Log.Info("Application was started");
        }

        void OnExit(object sender, ExitEventArgs e)
        {
            Log.Info("Application has exited");
        }
    }
}
