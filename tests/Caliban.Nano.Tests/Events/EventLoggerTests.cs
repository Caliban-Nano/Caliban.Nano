using System;
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
        private IContainer? Container { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            Container = new NanoContainer();

            IoC.Resolve = Container.Resolve;
        }

        [TestMethod]
        public void RaisePassedTest()
        {
            ArgumentNullException.ThrowIfNull(Container);

            var events = new EventAggregator();
            var logger = new MockLogger();

            Container.Register<IEventAggregator>(events);
            
            events.Subscribe<LogEvent>((LogEvent e) => Assert.AreEqual(e.Message, "Message"));

            logger.Raise("Message");
        }

        [TestMethod]
        public void RaiseFailedTest()
        {
            ArgumentNullException.ThrowIfNull(Container);

            using var writer = new StringWriter();
            var logger = new MockLogger();

            Trace.Listeners.Add(new TextWriterTraceListener(writer));

            logger.Raise("Message");

            Assert.IsTrue(writer.ToString().Contains("IEventAggregator could not be resolved"));
        }
    }
}
