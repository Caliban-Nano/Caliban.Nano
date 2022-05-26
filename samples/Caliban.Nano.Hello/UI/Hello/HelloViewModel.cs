using Caliban.Nano.Contracts;
using Caliban.Nano.Hello.Data;
using Caliban.Nano.UI;

namespace Caliban.Nano.Hello.UI.Hello
{
    public sealed class HelloViewModel : ViewModel
    {
        public IEventAggregator? Events { get; set; }
        public HelloModel Hello => ModelAs<HelloModel>();

        public bool CanSayHello
            => !string.IsNullOrEmpty(Hello.Input);

        public void SayHello()
            => Events?.Publish(Hello.Input!);
    }
}
