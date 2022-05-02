using System;
using Caliban.Nano.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caliban.Nano.Test.Events
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

            void handler(object? sender, int value)
            {
                count += value;
            }

            EventRaiser.Raise(1);

            EventRaiser += handler;

            EventRaiser.Raise(1);

            EventRaiser -= handler;

            EventRaiser.Raise(1);

            Assert.AreEqual(count, 1);
        }
    }
}
