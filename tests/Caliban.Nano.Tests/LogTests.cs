using System;
using System.Diagnostics;
using System.IO;
using Caliban.Nano.Container;
using Caliban.Nano.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caliban.Nano.Tests
{
    [TestClass]
    public sealed class LogTests
    {
        [TestMethod]
        public void ThisMessageTest()
        {
            using var test = new StringWriter();

            IoC.Resolve = new NanoContainer().Resolve;

            Trace.Listeners.Add(new TextWriterTraceListener(test));

            Log.This("test");

            Assert.IsTrue(test.ToString().Contains("[info] [caliban.nano] test"));
        }

        [TestMethod]
        public void ThisExceptionTest()
        {
            using var test = new StringWriter();

            IoC.Resolve = new NanoContainer().Resolve;

            Trace.Listeners.Add(new TextWriterTraceListener(test));

            Log.This(new Exception("test"));

            Assert.IsTrue(test.ToString().Contains("[error] [caliban.nano] test"));
        }
    }

    [TestClass]
    public sealed class TraceLoggerTests
    {
        private TraceLogger? Logger { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            Logger = new TraceLogger();
        }

        [TestMethod]
        public void HandleEventTest()
        {
            ArgumentNullException.ThrowIfNull(Logger);

            using var test = new StringWriter();

            Trace.Listeners.Add(new TextWriterTraceListener(test));

            var events = new EventAggregator();

            events.Subscribe<LogEvent>(Logger);
            events.Publish(new LogEvent("test"));

            Assert.IsTrue(test.ToString().Contains("[event] test"));
        }

        [TestMethod]
        public void HandleTest()
        {
            ArgumentNullException.ThrowIfNull(Logger);

            using var test = new StringWriter();
            
            Trace.Listeners.Add(new TextWriterTraceListener(test));

            Logger.Handle(new LogEvent("test"));

            Assert.IsTrue(test.ToString().Contains("[event] test"));
        }

        [TestMethod]
        public void InfoTest()
        {
            ArgumentNullException.ThrowIfNull(Logger);

            using var test = new StringWriter();
            
            Trace.Listeners.Add(new TextWriterTraceListener(test));

            Logger.Info("test");

            Assert.IsTrue(test.ToString().Contains("[info] test"));
        }

        [TestMethod]
        public void WarnTest()
        {
            ArgumentNullException.ThrowIfNull(Logger);
            
            using var test = new StringWriter();
            
            Trace.Listeners.Add(new TextWriterTraceListener(test));

            Logger.Warn("test");

            Assert.IsTrue(test.ToString().Contains("[warn] test"));
        }

        [TestMethod]
        public void ErrorTest()
        {
            ArgumentNullException.ThrowIfNull(Logger);

            using var test = new StringWriter();
            
            Trace.Listeners.Add(new TextWriterTraceListener(test));

            Logger.Error("test");

            Assert.IsTrue(test.ToString().Contains("[error] test"));
        }

        [TestMethod]
        public void ErrorFormatTest()
        {
            ArgumentNullException.ThrowIfNull(Logger);

            using var test = new StringWriter();
            
            Trace.Listeners.Add(new TextWriterTraceListener(test));

            Logger.Error("{0}", new[] { "test" });

            Assert.IsTrue(test.ToString().Contains("[error] test"));
        }

        [TestMethod]
        public void ErrorExceptionTest()
        {
            ArgumentNullException.ThrowIfNull(Logger);

            using var test = new StringWriter();
            
            Trace.Listeners.Add(new TextWriterTraceListener(test));

            Logger.Error(new Exception("test"));

            Assert.IsTrue(test.ToString().Contains("[error] test"));
        }

        [TestMethod]
        public void ErrorExceptionFormatTest()
        {
            ArgumentNullException.ThrowIfNull(Logger);
            
            using var test = new StringWriter();
            
            Trace.Listeners.Add(new TextWriterTraceListener(test));

            Logger.Error(new Exception("test1"), "{0}", new[] { "test2" });

            Assert.IsTrue(test.ToString().Contains("[error] test1: test2"));
        }
    }
}
