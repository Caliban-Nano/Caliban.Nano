using System;
using Caliban.Nano.Container;
using Caliban.Nano.Contracts;
using Caliban.Nano.Events;
using Caliban.Nano.Events.EventLogger;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caliban.Nano.Test.Events
{
    [TestClass]
    public class EventLoggerTests
    {
        private class Logger : ILogger
        {
            public void Info(string message)
                => throw new NotImplementedException();
            public void Warn(string message)
                => throw new NotImplementedException();
            public void Error(string message)
                => throw new NotImplementedException();
            public void Error(string format, params object[] args)
                => throw new NotImplementedException();
            public void Error(Exception exception)
                => throw new NotImplementedException();
            public void Error(Exception exception, string format, params object[] args)
                => throw new NotImplementedException();
        }

        private IContainer? Container { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            var events = new EventAggregator();

            Container = new NanoContainer();
            Container.Register<IEventAggregator>(events);

            IoC.Resolve = Container.Resolve;
        }

        [TestMethod]
        public void RaiseTest()
        {
            var events = IoC.Get<IEventAggregator>();
            var logger = new Logger();
            
            events.Subscribe<LogEvent>((LogEvent e) => {
                Assert.AreEqual(e.Message, "test");
            });

            logger.Raise("test");
        }
    }
}
