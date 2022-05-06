using System;
using Caliban.Nano.Contracts;

namespace Caliban.Nano.Tests.Classes
{
    internal sealed class TestLogger : ILogger
    {
        public void Info(string message) { }
        public void Warn(string message) { }
        public void Error(string message) { }
        public void Error(string format, params object[] args) { }
        public void Error(Exception exception) { }
        public void Error(Exception exception, string format, params object[] args) { }
    }
}
