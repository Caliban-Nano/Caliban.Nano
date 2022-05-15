using System;
using Caliban.Nano.UI;

namespace Caliban.Nano.Tests.Mocks
{
    internal sealed class MockClass : NotifyBase, IMock
    {
        #region Dependency Properties

        public IMock? DependencyA => _dependency;
        public IMock? DependencyB { get; set; } = null;
        public IMock? DependencyC { get; init; } = null;
        public IMock? DependencyD { get; private set; } = null;

        private readonly IMock? _dependency = null;

        #endregion

        #region Notify Properties

        public bool Notify
        {
            get => _notify;
            set
            {
                _notify = value;

                NotifyPropertyChanged();
                NotifyPropertyChanged(() => Notify);
            }
        }

        public bool Value1
        {
            get => _value;
            set => SetValue(ref _value, value);
        }

        public bool Value2
        {
            get => _value;
            set => SetValue(ref _value, value, "Value1", "Value2");
        }

        private bool _notify;
        private bool _value;

        #endregion

        #region Constructors

        public MockClass(IMock _)
        {
            throw new InvalidOperationException("Wrong constructor");
        }

        public MockClass(IMock? dependencyA = null, IMock? dependencyB = null)
        {
            _dependency = dependencyA;
            DependencyB = dependencyB;
        }

        #endregion
    }
}
