using System.Threading.Tasks;
using Caliban.Nano.UI;

namespace Caliban.Nano.Tests.Mocks
{
    internal sealed class MockViewModel : ViewModel { }
    internal sealed class MockAllViewModel : ViewModel.ActiveAll { }
    internal sealed class MockOneViewModel : ViewModel.ActiveOne { }
    internal sealed class MockFailViewModel : ViewModel
    {
        private readonly bool _doActivate;
        private readonly bool _doDeactivate;

        public MockFailViewModel(bool doActivate = false, bool doDeactivate = false)
        {
            _doActivate = doActivate;
            _doDeactivate = doDeactivate;
        }

        public override Task<bool> OnActivate()
        {
            IsActive = true;

            return Task.FromResult(_doActivate);
        }

        public override Task<bool> OnDeactivate()
        {
            IsActive = false;

            return Task.FromResult(_doDeactivate);
        }
    }
}
