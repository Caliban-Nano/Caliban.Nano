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
        public string DisplayName => Message?.Content ?? "Error";
    }
}
