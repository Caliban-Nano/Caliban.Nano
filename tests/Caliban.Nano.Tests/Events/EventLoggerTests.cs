using System.Diagnostics;
using System.IO;
using Caliban.Nano.Container;
using Caliban.Nano.Contracts;
using Caliban.Nano.Events;
using Caliban.Nano.Events.EventLogger;
using Caliban.Nano.Tests.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caliban.Nano.Tests.Events
{
    [TestClass]
    public sealed class EventLoggerTests
    {
        [TestInitialize]
        public void Initialize()
        {
            IoC.Container = new NanoContainer();
        }

        [TestMethod]
        public void RaisePassedTest()
        {
            var events = new EventAggregator();
            var logger = new MockLogger();

            IoC.Container.Bind<IEventAggregator>(events);
            
            events.Subscribe<LogEvent>((LogEvent e) => Assert.AreEqual(e.Message, "Message"));

            logger.Raise("Message");
        }

        [TestMethod]
        public void RaiseFailedTest()
        {
            using var writer = new StringWriter();
            var logger = new MockLogger();

            Trace.Listeners.Add(new TextWriterTraceListener(writer));

            logger.Raise("Message");

            Assert.IsTrue(writer.ToString().Contains("IEventAggregator could not be resolved"));
        }
    }
}
