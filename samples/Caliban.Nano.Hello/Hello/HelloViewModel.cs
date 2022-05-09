using Caliban.Nano.Contracts;
using Caliban.Nano.UI;

namespace Caliban.Nano.Hello.Hello
{
    public sealed class HelloViewModel : ViewModel
    {
        public IEventAggregator? Events { get; set; }
        public bool CanSayHello => !string.IsNullOrEmpty(Input);
        public string Input
        {
            get => _input;
            set => SetValue(ref _input, value, "Input", "CanSayHello");
        }

        private string _input = "";

        public void SayHello()
        {
            Events?.Publish(Input);
        }
    }
}
