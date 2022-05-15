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
        public void RaiseTest()
        {
            ArgumentNullException.ThrowIfNull(Container);

            var events = new EventAggregator();
            var logger = new MockLogger();

            Container.Register<IEventAggregator>(events);
            
            events.Subscribe<LogEvent>((LogEvent e) => {
                Assert.AreEqual(e.Message, "test");
            });

            logger.Raise("test");
        }

        [TestMethod]
        public void RaiseFailedTest()
        {
            ArgumentNullException.ThrowIfNull(Container);

            using var test = new StringWriter();

            Trace.Listeners.Add(new TextWriterTraceListener(test));

            var logger = new MockLogger();

            logger.Raise("test");

            Log.This("test");

            Assert.IsTrue(test.ToString().Contains("IEventAggregator could not be resolved"));
        }
    }
}
