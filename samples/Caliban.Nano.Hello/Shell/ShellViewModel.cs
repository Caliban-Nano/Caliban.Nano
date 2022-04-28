using System.Windows;
using Caliban.Nano.Contracts;
using Caliban.Nano.Hello.Hello;
using Caliban.Nano.UI;

namespace Caliban.Nano.Hello.Shell
{
    public class ShellViewModel : ViewModel, IWindow, IHandle<string>
    {
        public IEventAggregator Events { get; init; }
        public string DisplayName => "Hello";

        public ShellViewModel(IEventAggregator events)
        {
            Events = events;
            Events.Subscribe<string>(this);

            LoadAsync();
        }

        public async void LoadAsync()
        {
            await Activate(new HelloViewModel());
        }

        public void Handle(string name)
        {
            MessageBox.Show($"Hello {name}");
        }
    }
}
