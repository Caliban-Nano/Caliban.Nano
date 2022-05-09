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

        public bool TestNotify
        {
            get => _testNotify;
            set
            {
                _testNotify = value;

                NotifyPropertyChanged();
                NotifyPropertyChanged(() => TestNotify);
            }
        }

        public bool TestValue1
        {
            get => _testValue;
            set => SetValue(ref _testValue, value);
        }

        public bool TestValue2
        {
            get => _testValue;
            set => SetValue(ref _testValue, value, "TestValue1", "TestValue2");
        }

        private bool _testNotify;
        private bool _testValue;
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
