using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Caliban.Nano.Tests.Mocks;
using Caliban.Nano.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caliban.Nano.Tests.UI
{
    [TestClass]
    public sealed class ViewModelTests
    {
        private ViewModel? Mock;

        [TestInitialize]
        public void Initialize()
        {
            TypeFinder.Sources.Add(GetType().Assembly);

            Mock = new MockViewModel();
        }

        [TestMethod]
        public void BindPassedTest()
        {
            ArgumentNullException.ThrowIfNull(Mock);

            Assert.IsNotNull(Mock.View);
            Assert.IsNotNull(Mock.Model);
            Assert.IsFalse(Mock.IsActive);
            Assert.IsTrue(Mock.CanClose);
        }

        [TestMethod]
        public void BindFailedTest()
        {
            using var writer = new StringWriter();
            var logger = new MockLogger();

            Trace.Listeners.Add(new TextWriterTraceListener(writer));

            var mock = new MockSoloViewModel();

            Assert.IsNull(mock.View);
            Assert.IsNull(mock.Model);
            Assert.IsFalse(mock.IsActive);
            Assert.IsTrue(mock.CanClose);
            Assert.IsTrue(writer.ToString().Contains("Type MockSoloView could not be found"));
        }

        [TestMethod]
        public void ViewAsTest()
        {
            ArgumentNullException.ThrowIfNull(Mock);

            Assert.IsNotNull(Mock.ViewAs<MockView>());
            Assert.IsInstanceOfType(Mock.ViewAs<MockView>(), typeof(MockView));
            Assert.ThrowsException<InvalidCastException>(() => Mock.ViewAs<ViewModel>());
        }

        [TestMethod]
        public void ModelAsTest()
        {
            ArgumentNullException.ThrowIfNull(Mock);

            Assert.IsNotNull(Mock.ModelAs<MockModel>());
            Assert.IsInstanceOfType(Mock.ModelAs<MockModel>(), typeof(MockModel));
            Assert.ThrowsException<InvalidCastException>(() => Mock.ModelAs<ViewModel>());
        }

        [TestMethod]
        public async Task OnActivateTest()
        {
            ArgumentNullException.ThrowIfNull(Mock);

            Assert.IsFalse(Mock.IsActive);
            Assert.IsTrue(await Mock.OnActivate());
            Assert.IsTrue(Mock.IsActive);
        }

        [TestMethod]
        public async Task OnDeactivateTest()
        {
            ArgumentNullException.ThrowIfNull(Mock);

            Assert.IsFalse(Mock.IsActive);
            Assert.IsTrue(await Mock.OnActivate());
            Assert.IsTrue(Mock.IsActive);
            Assert.IsTrue(await Mock.OnDeactivate());
            Assert.IsFalse(Mock.IsActive);
        }

        [TestClass]
        public sealed class ActiveAllTests
        {
            private ViewModel.ActiveAll? Mock { get; set; }

            [TestInitialize]
            public void Initialize()
            {
                TypeFinder.Sources.Add(GetType().Assembly);

                Mock = new MockAllViewModel();
            }

            [TestMethod]
            public async Task ActiveChangedTest()
            {
                ArgumentNullException.ThrowIfNull(Mock);

                var mock = new MockViewModel();

                Mock.ActiveChanged += (item) =>
                {
                    Assert.IsNotNull(item);
                    Assert.AreEqual(item, mock);
                    Assert.IsInstanceOfType(item, typeof(MockViewModel));
                };

                Assert.IsTrue(await Mock.ActivateItem(mock));
                Assert.IsTrue(await Mock.DeactivateItem(mock));
            }

            [TestMethod]
            public async Task ActiveItemsTest()
            {
                ArgumentNullException.ThrowIfNull(Mock);

                var mock1 = new MockViewModel();
                var mock2 = new MockViewModel();

                Assert.IsFalse(Mock.ActiveItems.Contains(mock1));
                Assert.IsFalse(Mock.ActiveItems.Contains(mock2));

                Assert.IsTrue(await Mock.ActivateItem(mock1));
                Assert.IsTrue(await Mock.ActivateItem(mock2));

                Assert.IsTrue(Mock.ActiveItems.Contains(mock1));
                Assert.IsTrue(Mock.ActiveItems.Contains(mock2));
            }

            [TestMethod]
            public async Task ItemsTest()
            {
                ArgumentNullException.ThrowIfNull(Mock);

                var mock = new MockViewModel();

                Assert.IsFalse(Mock.Items.Contains(mock));
                Assert.IsTrue(await Mock.ActivateItem(mock));
                Assert.IsTrue(Mock.Items.Contains(mock));
            }

            [TestMethod]
            public async Task ActivateItemPassedTest()
            {
                ArgumentNullException.ThrowIfNull(Mock);

                var mock1 = new MockViewModel();
                var mock2 = new MockViewModel();

                Assert.IsFalse(mock1.IsActive);
                Assert.IsFalse(mock2.IsActive);

                Assert.IsTrue(await Mock.ActivateItem(mock1));

                Assert.IsTrue(mock1.IsActive);
                Assert.IsFalse(mock2.IsActive);

                Assert.IsTrue(await Mock.ActivateItem(mock2));

                Assert.IsTrue(mock1.IsActive);
                Assert.IsTrue(mock2.IsActive);
            }

            [TestMethod]
            public async Task ActivateItemFailedTest()
            {
                ArgumentNullException.ThrowIfNull(Mock);

                var fail = new MockFailViewModel();

                Assert.IsFalse(await Mock.ActivateItem(fail));
            }

            [TestMethod]
            public async Task DeactivateItemPassedTest()
            {
                ArgumentNullException.ThrowIfNull(Mock);

                var mock1 = new MockViewModel();
                var mock2 = new MockViewModel();

                Assert.IsFalse(mock1.IsActive);
                Assert.IsFalse(mock2.IsActive);

                Assert.IsTrue(await Mock.ActivateItem(mock1));

                Assert.IsTrue(mock1.IsActive);
                Assert.IsFalse(mock2.IsActive);

                Assert.IsTrue(await Mock.ActivateItem(mock2));

                Assert.IsTrue(mock1.IsActive);
                Assert.IsTrue(mock2.IsActive);

                Assert.IsTrue(await Mock.DeactivateItem(mock1));

                Assert.IsFalse(mock1.IsActive);
                Assert.IsTrue(mock2.IsActive);

                Assert.IsTrue(await Mock.DeactivateItem(mock2));

                Assert.IsFalse(mock1.IsActive);
                Assert.IsFalse(mock2.IsActive);
            }

            [TestMethod]
            public async Task DeactivateItemFailedTest()
            {
                ArgumentNullException.ThrowIfNull(Mock);

                var fail = new MockFailViewModel();

                Assert.IsFalse(await Mock.DeactivateItem(fail));
            }

            [TestMethod]
            public async Task DeactivateItemCloseTest()
            {
                ArgumentNullException.ThrowIfNull(Mock);

                var mock = new MockViewModel();

                Assert.IsFalse(Mock.Items.Contains(mock));
                Assert.IsTrue(await Mock.ActivateItem(mock));
                Assert.IsTrue(Mock.Items.Contains(mock));
                Assert.IsTrue(await Mock.DeactivateItem(mock, true));
                Assert.IsFalse(Mock.Items.Contains(mock));
            }
        }

        [TestClass]
        public sealed class ActiveOneTests
        {
            private ViewModel.ActiveOne? Mock { get; set; }

            [TestInitialize]
            public void Initialize()
            {
                TypeFinder.Sources.Add(GetType().Assembly);

                Mock = new MockOneViewModel();
            }

            [TestMethod]
            public async Task ActiveChangedTest()
            {
                ArgumentNullException.ThrowIfNull(Mock);

                var mock = new MockViewModel();

                Mock!.ActiveChanged += (item) =>
                {
                    Assert.IsNotNull(item);
                    Assert.AreEqual(item, mock);
                    Assert.IsInstanceOfType(item, typeof(MockViewModel));
                };

                Assert.IsTrue(await Mock.ActivateItem(mock));
                Assert.IsTrue(await Mock.DeactivateItem(mock));
            }

            [TestMethod]
            public async Task ActiveItemTest()
            {
                ArgumentNullException.ThrowIfNull(Mock);

                var mock = new MockViewModel();

                Assert.IsNull(Mock.ActiveItem);
                Assert.IsTrue(await Mock.ActivateItem(mock));
                Assert.AreEqual(Mock.ActiveItem, mock);
            }

            [TestMethod]
            public async Task ItemsTest()
            {
                ArgumentNullException.ThrowIfNull(Mock);

                var mock = new MockViewModel();

                Assert.IsFalse(Mock.Items.Contains(mock));
                Assert.IsTrue(await Mock.ActivateItem(mock));
                Assert.IsTrue(Mock.Items.Contains(mock));
            }

            [TestMethod]
            public async Task ActivateItemPassedTest()
            {
                ArgumentNullException.ThrowIfNull(Mock);

                var mock1 = new MockViewModel();
                var mock2 = new MockViewModel();

                Assert.IsFalse(mock1.IsActive);
                Assert.IsFalse(mock2.IsActive);

                Assert.IsTrue(await Mock.ActivateItem(mock1));

                Assert.IsTrue(mock1.IsActive);
                Assert.IsFalse(mock2.IsActive);

                Assert.IsTrue(await Mock.ActivateItem(mock2));

                Assert.IsFalse(mock1.IsActive);
                Assert.IsTrue(mock2.IsActive);
            }

            [TestMethod]
            public async Task ActivateItemFailedTest()
            {
                ArgumentNullException.ThrowIfNull(Mock);

                var fail1 = new MockFailViewModel(true, false);
                var fail2 = new MockFailViewModel(false, true);

                Assert.IsTrue(await Mock.ActivateItem(fail1));
                Assert.IsFalse(await Mock.ActivateItem(fail1));
                Assert.IsFalse(await Mock.ActivateItem(fail2));
            }

            [TestMethod]
            public async Task DeactivateItemPassedTest()
            {
                ArgumentNullException.ThrowIfNull(Mock);

                var mock1 = new MockViewModel();
                var mock2 = new MockViewModel();

                Assert.IsFalse(mock1.IsActive);
                Assert.IsFalse(mock2.IsActive);

                Assert.IsTrue(await Mock.ActivateItem(mock1));

                Assert.IsTrue(mock1.IsActive);
                Assert.IsFalse(mock2.IsActive);

                Assert.IsTrue(await Mock.ActivateItem(mock2));

                Assert.IsFalse(mock1.IsActive);
                Assert.IsTrue(mock2.IsActive);

                Assert.IsTrue(await Mock.DeactivateItem(mock1));

                Assert.IsFalse(mock1.IsActive);
                Assert.IsTrue(mock2.IsActive);

                Assert.IsTrue(await Mock.DeactivateItem(mock2));

                Assert.IsFalse(mock1.IsActive);
                Assert.IsFalse(mock2.IsActive);
            }

            [TestMethod]
            public async Task DeactivateItemFailedTest()
            {
                ArgumentNullException.ThrowIfNull(Mock);

                var fail = new MockFailViewModel();

                Assert.IsFalse(await Mock.DeactivateItem(fail));
            }

            [TestMethod]
            public async Task DeactivateItemCloseTest()
            {
                ArgumentNullException.ThrowIfNull(Mock);

                var mock = new MockViewModel();

                Assert.IsFalse(Mock.Items.Contains(mock));
                Assert.IsTrue(await Mock.ActivateItem(mock));
                Assert.IsTrue(Mock.Items.Contains(mock));
                Assert.IsTrue(await Mock.DeactivateItem(mock, true));
                Assert.IsFalse(Mock.Items.Contains(mock));
            }
        }
    }
}
