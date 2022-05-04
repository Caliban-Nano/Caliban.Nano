using System.Threading.Tasks;
using Caliban.Nano.UI;

namespace Caliban.Nano.Tests.Classes
{
    internal sealed class TestViewModel : ViewModel { }
    internal sealed class TestActiveAllViewModel : ViewModel.ActiveAll { }
    internal sealed class TestActiveOneViewModel : ViewModel.ActiveOne { }
    internal sealed class TestFailViewModel : ViewModel
    {
        private readonly bool _failOnActivate;
        private readonly bool _failOnDeactivate;

        public TestFailViewModel(bool failOnActivate = true, bool failOnDeactive = true)
        {
            _failOnActivate = failOnActivate;
            _failOnDeactivate = failOnDeactive;
        }

        public override Task<bool> OnActivate()
        {
            return Task.FromResult(_failOnActivate);
        }

        public override Task<bool> OnDeactivate()
        {
            return Task.FromResult(_failOnDeactivate);
        }
    }
}
