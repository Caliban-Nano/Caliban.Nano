using System.Windows;
using Caliban.Nano.Ninject.Data;
using Caliban.Nano.UI;
using Ninject;

namespace Caliban.Nano.Ninject.UI
{
    public sealed class MainViewModel : ViewModel
    {
        [Inject]
        public IMessage? Message { get; init; }

        public MainViewModel()
        {
            MessageBox.Show(Message?.Content ?? "Error");

            Application.Current.Shutdown();
        }
    }
}
