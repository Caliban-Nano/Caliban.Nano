using System;
using Caliban.Nano.Contracts;

namespace Caliban.Nano.Tests.Classes
{
    internal sealed class TestLogger : ILogger
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
}
