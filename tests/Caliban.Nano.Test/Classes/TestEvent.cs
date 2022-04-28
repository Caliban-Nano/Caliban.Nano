namespace Caliban.Nano.Test.Classes
{
    /// <summary>
    /// Internal test event.
    /// </summary>
    internal class TestEvent
    {
        public readonly object EventArg;

        public TestEvent(object arg)
        {
            EventArg = arg;
        }
    }
}
