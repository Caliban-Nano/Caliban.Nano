using System;
using System.Linq;
using System.Threading.Tasks;
using Caliban.Nano.Container;
using Caliban.Nano.Tests.Mocks;
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

            Test = new MockViewModel();
        }

        [TestMethod]
        public void ConstructorTest()
        {
            ArgumentNullException.ThrowIfNull(Test);

            Assert.IsNotNull(Test.View);

            Assert.IsFalse(Test.IsActive);

            Assert.IsTrue(Test.CanClose);
        }

        [TestMethod]
        public async Task OnActivateTest()
        {
            ArgumentNullException.ThrowIfNull(Test);

            Assert.IsFalse(Test.IsActive);

            Assert.IsTrue(await Test.OnActivate());

            Assert.IsTrue(Test.IsActive);
        }

        [TestMethod]
        public async Task OnDeactivateTest()
        {
            ArgumentNullException.ThrowIfNull(Test);

            Assert.IsFalse(Test.IsActive);

            Assert.IsTrue(await Test.OnActivate());

            Assert.IsTrue(Test.IsActive);

            Assert.IsTrue(await Test.OnDeactivate());

            Assert.IsFalse(Test.IsActive);
        }

        [TestClass]
        public sealed class ActiveAllTests
        {
            private ViewModel.ActiveAll? Test { get; set; }

            [TestInitialize]
            public void Initialize()
            {
                TypeFinder.Sources.Add(GetType().Assembly);

                IoC.Resolve = new NanoContainer().Resolve;

                Test = new MockAllViewModel();
            }

            [TestMethod]
            public async Task ActiveChangedTest()
            {
                ArgumentNullException.ThrowIfNull(Test);

                var test = new MockViewModel();

                Test.ActiveChanged += (item) =>
                {
                    Assert.IsNotNull(item);
                    Assert.AreEqual(item, test);
                    Assert.IsInstanceOfType(item, typeof(MockViewModel));
                };

                Assert.IsTrue(await Test.ActivateItem(test));

                Assert.IsTrue(await Test.DeactivateItem(test));
            }

            [TestMethod]
            public async Task ActiveItemsTest()
            {
                ArgumentNullException.ThrowIfNull(Test);

                var test1 = new MockViewModel();
                var test2 = new MockViewModel();

                Assert.IsFalse(Test.ActiveItems.Contains(test1));
                Assert.IsFalse(Test.ActiveItems.Contains(test2));

                Assert.IsTrue(await Test.ActivateItem(test1));
                Assert.IsTrue(await Test.ActivateItem(test2));

                Assert.IsTrue(Test.ActiveItems.Contains(test1));
                Assert.IsTrue(Test.ActiveItems.Contains(test2));
            }

            [TestMethod]
            public async Task ItemsTest()
            {
                ArgumentNullException.ThrowIfNull(Test);

                var test = new MockViewModel();

                Assert.IsFalse(Test.Items.Contains(test));

                Assert.IsTrue(await Test.ActivateItem(test));

                Assert.IsTrue(Test.Items.Contains(test));
            }

            [TestMethod]
            public async Task ActivateItemTest()
            {
                ArgumentNullException.ThrowIfNull(Test);

                var test1 = new MockViewModel();
                var test2 = new MockViewModel();

                Assert.IsFalse(test1.IsActive);
                Assert.IsFalse(test2.IsActive);

                Assert.IsTrue(await Test.ActivateItem(test1));

                Assert.IsTrue(test1.IsActive);
                Assert.IsFalse(test2.IsActive);

                Assert.IsTrue(await Test.ActivateItem(test2));

                Assert.IsTrue(test1.IsActive);
                Assert.IsTrue(test2.IsActive);
            }

            [TestMethod]
            public async Task ActivateItemFailedTest()
            {
                ArgumentNullException.ThrowIfNull(Test);

                var test = new MockFailViewModel();

                Assert.IsFalse(await Test.ActivateItem(test));
            }

            [TestMethod]
            public async Task DeactivateItemTest()
            {
                ArgumentNullException.ThrowIfNull(Test);

                var test1 = new MockViewModel();
                var test2 = new MockViewModel();

                Assert.IsFalse(test1.IsActive);
                Assert.IsFalse(test2.IsActive);

                Assert.IsTrue(await Test.ActivateItem(test1));

                Assert.IsTrue(test1.IsActive);
                Assert.IsFalse(test2.IsActive);

                Assert.IsTrue(await Test.ActivateItem(test2));

                Assert.IsTrue(test1.IsActive);
                Assert.IsTrue(test2.IsActive);

                Assert.IsTrue(await Test.DeactivateItem(test1));

                Assert.IsFalse(test1.IsActive);
                Assert.IsTrue(test2.IsActive);

                Assert.IsTrue(await Test.DeactivateItem(test2));

                Assert.IsFalse(test1.IsActive);
                Assert.IsFalse(test2.IsActive);
            }

            [TestMethod]
            public async Task DeactivateItemCloseTest()
            {
                ArgumentNullException.ThrowIfNull(Test);

                var test = new MockViewModel();

                Assert.IsFalse(Test.Items.Contains(test));

                Assert.IsTrue(await Test.ActivateItem(test));

                Assert.IsTrue(Test.Items.Contains(test));

                Assert.IsTrue(await Test.DeactivateItem(test, true));

                Assert.IsFalse(Test.Items.Contains(test));
            }

            [TestMethod]
            public async Task DeactivateItemFailedTest()
            {
                ArgumentNullException.ThrowIfNull(Test);

                var test = new MockFailViewModel();

                Assert.IsFalse(await Test.DeactivateItem(test));
            }
        }

        [TestClass]
        public sealed class ActiveOneTests
        {
            private ViewModel.ActiveOne? Test { get; set; }

            [TestInitialize]
            public void Initialize()
            {
                TypeFinder.Sources.Add(GetType().Assembly);

                IoC.Resolve = new NanoContainer().Resolve;

                Test = new MockOneViewModel();
            }

            [TestMethod]
            public async Task ActiveChangedTest()
            {
                ArgumentNullException.ThrowIfNull(Test);

                var test = new MockViewModel();

                Test!.ActiveChanged += (item) =>
                {
                    Assert.IsNotNull(item);
                    Assert.AreEqual(item, test);
                    Assert.IsInstanceOfType(item, typeof(MockViewModel));
                };

                Assert.IsTrue(await Test.ActivateItem(test));

                Assert.IsTrue(await Test.DeactivateItem(test));
            }

            [TestMethod]
            public async Task ActiveItemTest()
            {
                ArgumentNullException.ThrowIfNull(Test);

                var test = new MockViewModel();

                Assert.IsNull(Test.ActiveItem);

                Assert.IsTrue(await Test.ActivateItem(test));

                Assert.AreEqual(Test.ActiveItem, test);
            }

            [TestMethod]
            public async Task ItemsTest()
            {
                ArgumentNullException.ThrowIfNull(Test);

                var test = new MockViewModel();

                Assert.IsFalse(Test.Items.Contains(test));

                Assert.IsTrue(await Test.ActivateItem(test));

                Assert.IsTrue(Test.Items.Contains(test));
            }

            [TestMethod]
            public async Task ActivateItemTest()
            {
                ArgumentNullException.ThrowIfNull(Test);

                var test1 = new MockViewModel();
                var test2 = new MockViewModel();

                Assert.IsFalse(test1.IsActive);
                Assert.IsFalse(test2.IsActive);

                Assert.IsTrue(await Test.ActivateItem(test1));

                Assert.IsTrue(test1.IsActive);
                Assert.IsFalse(test2.IsActive);

                Assert.IsTrue(await Test.ActivateItem(test2));

                Assert.IsFalse(test1.IsActive);
                Assert.IsTrue(test2.IsActive);
            }

            [TestMethod]
            public async Task ActivateItemFailedTest()
            {
                ArgumentNullException.ThrowIfNull(Test);

                var test1 = new MockFailViewModel(true, false);
                var test2 = new MockFailViewModel(false, true);

                Assert.IsTrue(await Test.ActivateItem(test1));
                Assert.IsFalse(await Test.ActivateItem(test1));
                Assert.IsFalse(await Test.ActivateItem(test2));
            }

            [TestMethod]
            public async Task DeactivateItemTest()
            {
                ArgumentNullException.ThrowIfNull(Test);

                var test1 = new MockViewModel();
                var test2 = new MockViewModel();

                Assert.IsFalse(test1.IsActive);
                Assert.IsFalse(test2.IsActive);

                Assert.IsTrue(await Test.ActivateItem(test1));

                Assert.IsTrue(test1.IsActive);
                Assert.IsFalse(test2.IsActive);

                Assert.IsTrue(await Test.ActivateItem(test2));

                Assert.IsFalse(test1.IsActive);
                Assert.IsTrue(test2.IsActive);

                Assert.IsTrue(await Test.DeactivateItem(test1));

                Assert.IsFalse(test1.IsActive);
                Assert.IsTrue(test2.IsActive);

                Assert.IsTrue(await Test.DeactivateItem(test2));

                Assert.IsFalse(test1.IsActive);
                Assert.IsFalse(test2.IsActive);
            }

            [TestMethod]
            public async Task DeactivateItemCloseTest()
            {
                ArgumentNullException.ThrowIfNull(Test);

                var test = new MockViewModel();

                Assert.IsFalse(Test.Items.Contains(test));

                Assert.IsTrue(await Test.ActivateItem(test));

                Assert.IsTrue(Test.Items.Contains(test));

                Assert.IsTrue(await Test.DeactivateItem(test, true));

                Assert.IsFalse(Test.Items.Contains(test));
            }

            [TestMethod]
            public async Task DeactivateItemFailedTest()
            {
                ArgumentNullException.ThrowIfNull(Test);

                var test = new MockFailViewModel();

                Assert.IsFalse(await Test.DeactivateItem(test));
            }
        }
    }
}
