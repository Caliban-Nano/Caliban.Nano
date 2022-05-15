using Caliban.Nano.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caliban.Nano.Tests.Events
{
    [TestClass]
    public sealed class LogEventTests
    {
        [TestMethod]
        public void LogEventTest()
        {
            var logEvent = new LogEvent("Message");

            Assert.AreEqual(logEvent.Message, "Message");
            Assert.AreEqual(logEvent.ToString(), "Message");
        }
    }
}
