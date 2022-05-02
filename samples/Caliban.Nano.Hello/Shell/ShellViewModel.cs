using System.Windows;
using Caliban.Nano.Contracts;
using Caliban.Nano.Hello.Hello;
using Caliban.Nano.UI;

namespace Caliban.Nano.Hello.Shell
{
    public sealed class ShellViewModel : ViewModel.ActiveOne, IWindow, IHandle<string>
    {
        public IEventAggregator Events { get; init; }
        public string DisplayName => "Hello";

        public ShellViewModel(IEventAggregator events)
        {
            Events = events;
            Events.Subscribe<string>(this);

            HelloAsync();
        }

        public async void HelloAsync()
        {
            await ActivateItem(new HelloViewModel());
        }

        public void Handle(string name)
        {
            MessageBox.Show($"Hello {name}");
        }
    }
}
