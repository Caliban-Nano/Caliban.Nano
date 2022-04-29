using System;

namespace Caliban.Nano.Test.Classes
{
    /// <summary>
    /// Internal test class.
    /// </summary>
    internal class TestClass : IDependency
    {
        public IDependency? A => _a;
        public IDependency? B { get; set; } = null;
        public IDependency? C { get; init; } = null;
        public IDependency? D { get; private set; } = null;

        private readonly IDependency? _a = null;

        public TestClass(IDependency _)
        {
            throw new Exception("Wrong constructor");
        }

        public TestClass(IDependency? a = null, IDependency? b = null)
        {
            _a = a;
            B = b;
        }
    }
}
