using System;
using System.Diagnostics;
using System.IO;
using Caliban.Nano.Container;
using Caliban.Nano.Contracts;
using Caliban.Nano.Events;
using Caliban.Nano.Tests.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caliban.Nano.Tests.Events
{
    [TestClass]
    public sealed class EventAggregatorTests
    {
        private IEventAggregator? Events { get; set; }

        private readonly Action<object> Handler = (_) => { };

        [TestInitialize]
        public void Initialize()
        {
            Events = new EventAggregator();
        }

        [TestMethod]
        public void DisposeTest()
        {
            ArgumentNullException.ThrowIfNull(Events);

            Events.Subscribe<TestEvent>(Handler);

            using (Events)
            {
                Assert.IsTrue(Events.HasHandler<TestEvent>());                
            }

            Assert.IsFalse(Events.HasHandler<TestEvent>());
        }

        [TestMethod]
        public void HasHandlerTest()
        {
            ArgumentNullException.ThrowIfNull(Events);

            Assert.IsFalse(Events.HasHandler<TestEvent>());

            Events.Subscribe<TestEvent>(Handler);

            Assert.IsTrue(Events.HasHandler<TestEvent>());
        }

        [TestMethod]
        public void SubscribeTest()
        {
            ArgumentNullException.ThrowIfNull(Events);

            Events.Subscribe<TestEvent>(Handler);

            Assert.IsTrue(Events.HasHandler<TestEvent>());
        }

        [TestMethod]
        public void UnsubscribeTest()
        {
            ArgumentNullException.ThrowIfNull(Events);

            Events.Subscribe<TestEvent>(Handler);

            Assert.IsTrue(Events.HasHandler<TestEvent>());

            Events.Unsubscribe<TestEvent>(Handler);

            Assert.IsFalse(Events.HasHandler<TestEvent>());
        }

        [TestMethod]
        public void PublishTest()
        {
            Action<TestEvent> handler = (e) => Assert.AreEqual(e.EventArg, "Test");

            ArgumentNullException.ThrowIfNull(Events);

            Events.Subscribe<TestEvent>(handler);

            Assert.IsTrue(Events.HasHandler<TestEvent>());

            Events.Publish(new TestEvent("Test"));
        }

        [TestMethod]
        public void PublishFailedTest()
        {
            ArgumentNullException.ThrowIfNull(Events);

            using var test = new StringWriter();

            Trace.Listeners.Add(new TextWriterTraceListener(test));

            IoC.Resolve = new NanoContainer().Resolve;

            Events.Subscribe<TestEvent>(new object());

            Assert.IsTrue(Events.HasHandler<TestEvent>());

            Events.Publish(new TestEvent("Test"));

            Assert.IsTrue(test.ToString().Contains("Handler System.Object is not supported"));
        }
    }
}
