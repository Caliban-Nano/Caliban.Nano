using System.Threading.Tasks;
using Caliban.Nano.UI;

namespace Caliban.Nano.Tests.Classes
{
    internal sealed class TestViewModel : ViewModel { }
    internal sealed class TestActiveAllViewModel : ViewModel.ActiveAll { }
    internal sealed class TestActiveOneViewModel : ViewModel.ActiveOne { }
    internal sealed class TestActiveFailViewModel : ViewModel
    {
        private bool Activate { get; init; }
        private bool Deactivate { get; init; }

        public TestActiveFailViewModel(bool activate = false, bool deactivate = false)
        {
            Activate = activate;
            Deactivate = deactivate;
        }

        public override Task<bool> OnActivate()
        {
            IsActive = true;

            return Task.FromResult(Activate);
        }

        public override Task<bool> OnDeactivate()
        {
            IsActive = false;

            return Task.FromResult(Deactivate);
        }
    }
}
