using System;
using System.Diagnostics;
using System.IO;
using Caliban.Nano.Container;
using Caliban.Nano.Contracts;
using Caliban.Nano.Events;
using Caliban.Nano.Tests.Mocks;
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

            Events.Subscribe<MockEvent>(Handler);

            using (Events)
            {
                Assert.IsTrue(Events.HasHandler<MockEvent>());                
            }

            Assert.IsFalse(Events.HasHandler<MockEvent>());
        }

        [TestMethod]
        public void HasHandlerTest()
        {
            ArgumentNullException.ThrowIfNull(Events);

            Assert.IsFalse(Events.HasHandler<MockEvent>());

            Events.Subscribe<MockEvent>(Handler);

            Assert.IsTrue(Events.HasHandler<MockEvent>());
        }

        [TestMethod]
        public void SubscribeTest()
        {
            ArgumentNullException.ThrowIfNull(Events);

            Events.Subscribe<MockEvent>(Handler);

            Assert.IsTrue(Events.HasHandler<MockEvent>());
        }

        [TestMethod]
        public void UnsubscribeTest()
        {
            ArgumentNullException.ThrowIfNull(Events);

            Events.Subscribe<MockEvent>(Handler);

            Assert.IsTrue(Events.HasHandler<MockEvent>());

            Events.Unsubscribe<MockEvent>(Handler);

            Assert.IsFalse(Events.HasHandler<MockEvent>());
        }

        [TestMethod]
        public void PublishTest()
        {
            Action<MockEvent> handler = (e) => Assert.IsTrue(true);

            ArgumentNullException.ThrowIfNull(Events);

            Events.Subscribe<MockEvent>(handler);

            Assert.IsTrue(Events.HasHandler<MockEvent>());

            Events.Publish(new MockEvent());
        }

        [TestMethod]
        public void PublishFailedTest()
        {
            ArgumentNullException.ThrowIfNull(Events);

            using var test = new StringWriter();

            Trace.Listeners.Add(new TextWriterTraceListener(test));

            IoC.Resolve = new NanoContainer().Resolve;

            Events.Subscribe<MockEvent>(new object());

            Assert.IsTrue(Events.HasHandler<MockEvent>());

            Events.Publish(new MockEvent());

            Assert.IsTrue(test.ToString().Contains("Handler System.Object is not supported"));
        }
    }
}
