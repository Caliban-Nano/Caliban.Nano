using Caliban.Nano.Data;

namespace Caliban.Nano.Hello.Data
{
    public sealed class HelloModel : Model
    {
        public string? Input
        {
            get => Get<string?>();
            set => Set<string?>(value, "Input", "CanSayHello");
        }
    }
}
