using System;
using Caliban.Nano.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caliban.Nano.Tests.Events
{
    [TestClass]
    public sealed class EventRaiserTests
    {
        private EventRaiser<int>? EventRaiser { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            EventRaiser = new EventRaiser<int>();
        }

        [TestMethod]
        public void RaiseTest()
        {
            ArgumentNullException.ThrowIfNull(EventRaiser);

            var count = 0;

            void handler(object? _, int value) => count += value;

            EventRaiser.Raise(1);
            EventRaiser += handler;
            EventRaiser.Raise(2);
            EventRaiser -= handler;
            EventRaiser.Raise(3);

            Assert.AreEqual(count, 2);
        }
    }
}
