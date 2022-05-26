using Caliban.Nano.Contracts;
using Caliban.Nano.Ninject.Data;
using Caliban.Nano.UI;
using Ninject;

namespace Caliban.Nano.Ninject.UI
{
    public sealed class MainViewModel : ViewModel, IWindow
    {
        [Inject]
        public IMessage? Text { get; init; }

        public string DisplayName => "Ninject Demo";
        public string DisplayText => Text?.Message ?? "Error";
    }
}
