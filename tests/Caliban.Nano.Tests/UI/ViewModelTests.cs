using System.Linq;
using System.Threading.Tasks;
using Caliban.Nano.Container;
using Caliban.Nano.Test.Classes;
using Caliban.Nano.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caliban.Nano.Tests.UI
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

    [TestClass]
    public sealed class ViewModelActiveAllTests
    {
        private ViewModel.ActiveAll? Test { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            TypeFinder.Sources.Add(GetType().Assembly);

            IoC.Resolve = new NanoContainer().Resolve;

            Test = new TestActiveAllViewModel();
        }

        [TestMethod]
        public async Task ActiveChangedTest()
        {
            var test = new TestViewModel();

            Test!.ActiveChanged += (item) =>
            {
                Assert.IsNotNull(item);
                Assert.AreEqual(item, test);
                Assert.IsInstanceOfType(item, typeof(TestViewModel));
            };

            Assert.IsTrue(await (Test?.ActivateItem(test) ?? Task.FromResult(false)));

            Assert.IsTrue(await (Test?.DeactivateItem(test) ?? Task.FromResult(false)));
        }

        [TestMethod]
        public async Task ActiveItemsTest()
        {
            var test1 = new TestViewModel();
            var test2 = new TestViewModel();

            Assert.IsFalse(Test?.ActiveItems.Contains(test1));
            Assert.IsFalse(Test?.ActiveItems.Contains(test2));

            Assert.IsTrue(await (Test?.ActivateItem(test1) ?? Task.FromResult(false)));
            Assert.IsTrue(await (Test?.ActivateItem(test2) ?? Task.FromResult(false)));

            Assert.IsTrue(Test?.ActiveItems.Contains(test1));
            Assert.IsTrue(Test?.ActiveItems.Contains(test2));
        }

        [TestMethod]
        public async Task ItemsTest()
        {
            var test = new TestViewModel();

            Assert.IsFalse(Test?.Items.Contains(test));

            Assert.IsTrue(await (Test?.ActivateItem(test) ?? Task.FromResult(false)));

            Assert.IsTrue(Test?.Items.Contains(test));
        }

        [TestMethod]
        public async Task ActivateItemTest()
        {
            var test1 = new TestViewModel();
            var test2 = new TestViewModel();

            Assert.IsFalse(test1.IsActive);
            Assert.IsFalse(test2.IsActive);

            Assert.IsTrue(await (Test?.ActivateItem(test1) ?? Task.FromResult(false)));

            Assert.IsTrue(test1.IsActive);
            Assert.IsFalse(test2.IsActive);

            Assert.IsTrue(await (Test?.ActivateItem(test2) ?? Task.FromResult(false)));

            Assert.IsTrue(test1.IsActive);
            Assert.IsTrue(test2.IsActive);
        }

        [TestMethod]
        public async Task DeactivateItemTest()
        {
            var test1 = new TestViewModel();
            var test2 = new TestViewModel();

            Assert.IsFalse(test1.IsActive);
            Assert.IsFalse(test2.IsActive);

            Assert.IsTrue(await (Test?.ActivateItem(test1) ?? Task.FromResult(false)));

            Assert.IsTrue(test1.IsActive);
            Assert.IsFalse(test2.IsActive);

            Assert.IsTrue(await (Test?.ActivateItem(test2) ?? Task.FromResult(false)));

            Assert.IsTrue(test1.IsActive);
            Assert.IsTrue(test2.IsActive);

            Assert.IsTrue(await (Test?.DeactivateItem(test1) ?? Task.FromResult(false)));

            Assert.IsFalse(test1.IsActive);
            Assert.IsTrue(test2.IsActive);

            Assert.IsTrue(await (Test?.DeactivateItem(test2) ?? Task.FromResult(false)));

            Assert.IsFalse(test1.IsActive);
            Assert.IsFalse(test2.IsActive);
        }
    }

    [TestClass]
    public sealed class ViewModelActiveOneTests
    {
        private ViewModel.ActiveOne? Test { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            TypeFinder.Sources.Add(GetType().Assembly);

            IoC.Resolve = new NanoContainer().Resolve;

            Test = new TestActiveOneViewModel();
        }

        [TestMethod]
        public async Task ActiveChangedTest()
        {
            var test = new TestViewModel();

            Test!.ActiveChanged += (item) =>
            {
                Assert.IsNotNull(item);
                Assert.AreEqual(item, test);
                Assert.IsInstanceOfType(item, typeof(TestViewModel));
            };

            Assert.IsTrue(await (Test?.ActivateItem(test) ?? Task.FromResult(false)));

            Assert.IsTrue(await (Test?.DeactivateItem(test) ?? Task.FromResult(false)));
        }

        [TestMethod]
        public async Task ActiveItemTest()
        {
            var test = new TestViewModel();

            Assert.IsNull(Test?.ActiveItem);

            Assert.IsTrue(await (Test?.ActivateItem(test) ?? Task.FromResult(false)));

            Assert.AreEqual(Test?.ActiveItem, test);
        }

        [TestMethod]
        public async Task ItemsTest()
        {
            var test = new TestViewModel();

            Assert.IsFalse(Test?.Items.Contains(test));

            Assert.IsTrue(await (Test?.ActivateItem(test) ?? Task.FromResult(false)));

            Assert.IsTrue(Test?.Items.Contains(test));
        }

        [TestMethod]
        public async Task ActivateItemTest()
        {
            var test1 = new TestViewModel();
            var test2 = new TestViewModel();

            Assert.IsFalse(test1.IsActive);
            Assert.IsFalse(test2.IsActive);

            Assert.IsTrue(await (Test?.ActivateItem(test1) ?? Task.FromResult(false)));

            Assert.IsTrue(test1.IsActive);
            Assert.IsFalse(test2.IsActive);

            Assert.IsTrue(await (Test?.ActivateItem(test2) ?? Task.FromResult(false)));

            Assert.IsFalse(test1.IsActive);
            Assert.IsTrue(test2.IsActive);
        }

        [TestMethod]
        public async Task DeactivateItemTest()
        {
            var test1 = new TestViewModel();
            var test2 = new TestViewModel();

            Assert.IsFalse(test1.IsActive);
            Assert.IsFalse(test2.IsActive);

            Assert.IsTrue(await (Test?.ActivateItem(test1) ?? Task.FromResult(false)));

            Assert.IsTrue(test1.IsActive);
            Assert.IsFalse(test2.IsActive);

            Assert.IsTrue(await (Test?.ActivateItem(test2) ?? Task.FromResult(false)));

            Assert.IsFalse(test1.IsActive);
            Assert.IsTrue(test2.IsActive);

            Assert.IsTrue(await (Test?.DeactivateItem(test1) ?? Task.FromResult(false)));

            Assert.IsFalse(test1.IsActive);
            Assert.IsTrue(test2.IsActive);

            Assert.IsTrue(await (Test?.DeactivateItem(test2) ?? Task.FromResult(false)));

            Assert.IsFalse(test1.IsActive);
            Assert.IsFalse(test2.IsActive);
        }
    }
}
