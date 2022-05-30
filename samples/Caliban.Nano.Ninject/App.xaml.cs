using System.Windows;
using Caliban.Nano.Ninject.Container;
using Caliban.Nano.Ninject.Data;
using Caliban.Nano.Ninject.UI;

namespace Caliban.Nano.Ninject
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        void OnStartup(object sender, StartupEventArgs e)
        {
            new Bootstrap(new NinjectAdapter())
                .Register<IMessage>(typeof(Message))
                .Show<MainViewModel>();
        }
    }
}
