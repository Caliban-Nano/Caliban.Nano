using System.Reflection;
using System.Windows;
using Caliban.Nano.Contracts;
using Caliban.Nano.Events;
using Caliban.Nano.Hello.Shell;

namespace Caliban.Nano.Hello
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        void OnStartup(object sender, StartupEventArgs e)
        {
            new Bootstrap()
                .AddSource(Assembly.GetExecutingAssembly())
                .Register<IEventAggregator>(new EventAggregator())
                .Show<ShellViewModel>();
        }
    }
}
