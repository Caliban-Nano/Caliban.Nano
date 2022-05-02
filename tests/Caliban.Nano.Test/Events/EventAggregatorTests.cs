using System;
using Caliban.Nano.Contracts;
using Caliban.Nano.Events;
using Caliban.Nano.Test.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caliban.Nano.Test.Events
{
    [TestClass]
    public class EventAggregatorTests
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
            Action<TestEvent> handler = (e) => Assert.AreEqual(e.EventArg, "Hello");

            ArgumentNullException.ThrowIfNull(Events);

            Events.Subscribe<TestEvent>(handler);

            Assert.IsTrue(Events.HasHandler<TestEvent>());

            Events.Publish(new TestEvent("Hello"));
        }
    }
}
