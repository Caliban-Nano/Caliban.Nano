using System.Threading.Tasks;
using Caliban.Nano.Container;
using Caliban.Nano.Test.Classes;
using Caliban.Nano.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caliban.Nano.Test.UI
{
    [TestClass]
    public sealed class ViewModelTests
    {
        private ViewModel? Test;

        [TestInitialize]
        public void Initialize()
        {
            TypeFinder.Sources.Add(GetType().Assembly);

            IoC.Resolve = new NanoContainer().Resolve;

            Test = new TestViewModel();
        }

        [TestMethod]
        public void ConstructorTest()
        {
            Assert.IsNotNull(Test?.View);

            Assert.IsFalse(Test?.IsActive);

            Assert.IsTrue(Test?.CanClose);
        }

        [TestMethod]
        public async Task OnActivateTest()
        {
            Assert.IsFalse(Test?.IsActive);

            Assert.IsTrue(await (Test?.OnActivate() ?? Task.FromResult(false)));

            Assert.IsTrue(Test?.IsActive);
        }

        [TestMethod]
        public async Task OnDeactivateTest()
        {
            Assert.IsFalse(Test?.IsActive);

            Assert.IsTrue(await (Test?.OnActivate() ?? Task.FromResult(false)));

            Assert.IsTrue(Test?.IsActive);

            Assert.IsTrue(await (Test?.OnDeactivate() ?? Task.FromResult(false)));

            Assert.IsFalse(Test?.IsActive);
        }
    }
}
