namespace Caliban.Nano.Tests.Classes
{
    internal sealed class TestEvent
    {
        public readonly object EventArg;

        public TestEvent(object arg)
        {
            EventArg = arg;
        }
    }
}
