using System.Threading.Tasks;
using Caliban.Nano.Tests.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caliban.Nano.Tests.Data
{
    [TestClass]
    public sealed class ModelTests
    {
        [TestMethod]
        public void PropertyChangedTest()
        {
            var count = 0;

            var mock = new MockModel();

            mock.PropertyChanged += (_, _) => count++;

            Assert.AreEqual(0, count);

            mock.Value1 = !mock.Value1;

            Assert.AreEqual(1, count);
        }

        [TestMethod]
        public void HasChangedTest()
        {
            var mock = new MockModel();
            
            mock.SetHasChanged(false);

            Assert.IsFalse(mock.HasChanged);

            mock.Value1 = !mock.Value1;

            Assert.IsTrue(mock.HasChanged);

            mock.SetHasChanged(false);

            Assert.IsFalse(mock.HasChanged);

            mock.Value2 = true;

            Assert.IsTrue(mock.HasChanged);
        }

        [TestMethod]
        public async Task LoadTest()
        {
            var mock = new MockModel();

            mock.SetHasChanged(true);

            Assert.IsTrue(mock.HasChanged);

            await mock.Load();

            Assert.IsFalse(mock.HasChanged);
        }

        [TestMethod]
        public async Task SaveTest()
        {
            var mock = new MockModel();

            mock.SetHasChanged(true);

            Assert.IsTrue(mock.HasChanged);

            await mock.Save();

            Assert.IsFalse(mock.HasChanged);
        }

        [TestMethod]
        public void GetDefaultTest()
        {
            var mock = new MockModel();

            Assert.IsFalse(mock.Value1);
        }

        [TestMethod]
        public void GetNullTest()
        {
            var mock = new MockModel();

            Assert.IsNull(mock.Value2);
        }

        [TestMethod]
        public void GetTest()
        {
            var mock = new MockModel
            {
                Value1 = true
            };

            Assert.IsTrue(mock.Value1);
        }

        [TestMethod]
        public void SetTest()
        {
            var mock = new MockModel();

            Assert.IsFalse(mock.Value1);

            mock.Value1 = true;

            Assert.IsTrue(mock.Value1);
        }
    }
}
