using System.Threading.Tasks;
using System.Windows;
using Caliban.Nano.Contracts;
using Caliban.Nano.Hello.UI.Hello;
using Caliban.Nano.UI;

namespace Caliban.Nano.Hello.UI.Shell
{
    public sealed class ShellViewModel : ViewModel.ActiveOne, IWindow, IHandle<string>
    {
        public IEventAggregator Events { get; init; }
        public string DisplayName => "Hello";

        public ShellViewModel(IEventAggregator events)
        {
            Events = events;
            Events.Subscribe<string>(this);
        }

        public override Task<bool> OnActivate()
        {
            return ActivateItem(new HelloViewModel());
        }

        public void Handle(string name)
        {
            MessageBox.Show($"Hello {name}");
        }
    }
}
