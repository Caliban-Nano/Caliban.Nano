using System.Windows;
using Caliban.Nano.Contracts;
using Caliban.Nano.Ninject.Data;
using Caliban.Nano.UI;
using Ninject;

namespace Caliban.Nano.Ninject.UI
{
    public sealed class MainViewModel : ViewModel, IWindow
    {
        [Inject]
        public IMessage? Message { get; init; }
        public string DisplayName => "Ninject Sample";

        public MainViewModel()
        {
            MessageBox.Show(Message?.Content ?? "Error");

            Shutdown();
        }

        public async void Shutdown()
        {
            await Close();
        }
    }
}
