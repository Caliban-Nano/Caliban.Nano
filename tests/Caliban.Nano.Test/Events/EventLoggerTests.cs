using Caliban.Nano.Contracts;
using Caliban.Nano.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caliban.Nano.Test.Events
{
    [TestClass]
    public class EventLoggerTests
    {
        private class Logger : EventLogger
        {
            public Logger(IEventAggregator events)
            {
                Events = events;
            }
        }

        [TestMethod]
        public void RaiseTest()
        {
            var events = new EventAggregator();
            var logger = new Logger(events);

            events.Subscribe<LogEvent>((LogEvent e) => {
                Assert.AreEqual(e.Message, "test");
            });

            logger.Raise("test");
        }
    }
}
