using Caliban.Nano.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caliban.Nano.Test.Events
{
    [TestClass]
    public class LogEventTests
    {
        [TestMethod]
        public void LogEventTest()
        {
            var log = new LogEvent("test");

            Assert.AreEqual(log.Message, "test");
        }
    }
}
