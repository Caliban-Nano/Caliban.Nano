using System;
using Caliban.Nano.Contracts;

namespace Caliban.Nano.Tests.Mocks
{
    internal sealed class MockLogger : ILogger
    {
        public void Dispose() { }
        public void Info(string _) { }
        public void Warn(string _) { }
        public void Error(string _) { }
        public void Error(string _, params object[] __) { }
        public void Error(Exception _) { }
        public void Error(Exception _, string __, params object[] ___) { }
    }
}
