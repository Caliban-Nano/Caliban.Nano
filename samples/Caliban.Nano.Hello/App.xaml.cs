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
                .AddAssembly(Assembly.GetExecutingAssembly())
                .AddNamespace("Caliban.Nano.Hello.Shell")
                .AddNamespace("Caliban.Nano.Hello.Hello")
                .Register<IEventAggregator>(new EventAggregator())
                .Show<ShellViewModel>();
        }
    }
}
