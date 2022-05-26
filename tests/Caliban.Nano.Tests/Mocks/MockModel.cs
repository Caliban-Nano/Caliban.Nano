using Caliban.Nano.Data;

namespace Caliban.Nano.Tests.Mocks
{
    internal sealed class MockModel : Model
    {
        public bool Value1
        {
            get => Get<bool>();
            set => Set(value);
        }

        public bool? Value2
        {
            get => Get<bool?>();
            set => Set(value, "Value2", "Value1");
        }

        public void ClearHasChanged() => HasChanged = false;
    }
}
