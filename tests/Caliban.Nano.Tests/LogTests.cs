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
            IoC.Resolve = new NanoContainer().Resolve;

            using var writer = new StringWriter();

            Trace.Listeners.Add(new TextWriterTraceListener(writer));

            Log.This("Message");

            Assert.IsTrue(writer.ToString().Contains("[info] [caliban.nano] Message"));
        }

        [TestMethod]
        public void ThisExceptionTest()
        {
            IoC.Resolve = new NanoContainer().Resolve;

            using var writer = new StringWriter();

            Trace.Listeners.Add(new TextWriterTraceListener(writer));

            Log.This(new Exception("Exception"));

            Assert.IsTrue(writer.ToString().Contains("[error] [caliban.nano] Exception"));
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
        public void HandleExternTest()
        {
            ArgumentNullException.ThrowIfNull(Logger);

            using var writer = new StringWriter();
            var events = new EventAggregator();

            Trace.Listeners.Add(new TextWriterTraceListener(writer));

            events.Subscribe<LogEvent>(Logger);
            events.Publish(new LogEvent("Event"));

            Assert.IsTrue(writer.ToString().Contains("[event] Event"));
        }

        [TestMethod]
        public void HandleInternTest()
        {
            ArgumentNullException.ThrowIfNull(Logger);

            using var writer = new StringWriter();
            
            Trace.Listeners.Add(new TextWriterTraceListener(writer));

            Logger.Handle(new LogEvent("Event"));

            Assert.IsTrue(writer.ToString().Contains("[event] Event"));
        }

        [TestMethod]
        public void InfoTest()
        {
            ArgumentNullException.ThrowIfNull(Logger);

            using var writer = new StringWriter();
            
            Trace.Listeners.Add(new TextWriterTraceListener(writer));

            Logger.Info("Info");

            Assert.IsTrue(writer.ToString().Contains("[info] Info"));
        }

        [TestMethod]
        public void WarnTest()
        {
            ArgumentNullException.ThrowIfNull(Logger);
            
            using var writer = new StringWriter();
            
            Trace.Listeners.Add(new TextWriterTraceListener(writer));

            Logger.Warn("Warning");

            Assert.IsTrue(writer.ToString().Contains("[warn] Warning"));
        }

        [TestMethod]
        public void ErrorTest()
        {
            ArgumentNullException.ThrowIfNull(Logger);

            using var writer = new StringWriter();
            
            Trace.Listeners.Add(new TextWriterTraceListener(writer));

            Logger.Error("Error");

            Assert.IsTrue(writer.ToString().Contains("[error] Error"));
        }

        [TestMethod]
        public void ErrorFormatTest()
        {
            ArgumentNullException.ThrowIfNull(Logger);

            using var writer = new StringWriter();
            
            Trace.Listeners.Add(new TextWriterTraceListener(writer));

            Logger.Error("{0}", new[] { "Error" });

            Assert.IsTrue(writer.ToString().Contains("[error] Error"));
        }

        [TestMethod]
        public void ErrorExceptionTest()
        {
            ArgumentNullException.ThrowIfNull(Logger);

            using var writer = new StringWriter();
            
            Trace.Listeners.Add(new TextWriterTraceListener(writer));

            Logger.Error(new Exception("Error"));

            Assert.IsTrue(writer.ToString().Contains("[error] Error"));
        }

        [TestMethod]
        public void ErrorExceptionFormatTest()
        {
            ArgumentNullException.ThrowIfNull(Logger);
            
            using var writer = new StringWriter();
            
            Trace.Listeners.Add(new TextWriterTraceListener(writer));

            Logger.Error(new Exception("Exception"), "{0}", new[] { "Message" });

            Assert.IsTrue(writer.ToString().Contains("[error] Exception: Message"));
        }
    }
}
