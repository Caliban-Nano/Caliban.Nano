using System;
using Caliban.Nano.UI;

namespace Caliban.Nano.Tests.Classes
{
    internal sealed class TestClass : NotifyBase, IDependency
    {
        public IDependency? A => _a;
        public IDependency? B { get; set; } = null;
        public IDependency? C { get; init; } = null;
        public IDependency? D { get; private set; } = null;
        public void Test() => NotifyPropertyChanged();

        private readonly IDependency? _a = null;

        public TestClass(IDependency _)
        {
            throw new InvalidOperationException("Wrong constructor");
        }

        public TestClass(IDependency? a = null, IDependency? b = null)
        {
            _a = a;
            B = b;
        }
    }
}
