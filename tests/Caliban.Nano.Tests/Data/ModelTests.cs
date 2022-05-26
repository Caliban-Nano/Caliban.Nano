using Caliban.Nano.Tests.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caliban.Nano.Tests.Data
{
    [TestClass]
    public sealed class ModelTests
    {
        [TestMethod]
        public void HasChangedTest()
        {
            var mock = new MockModel();

            mock.ClearHasChanged();

            Assert.IsFalse(mock.HasChanged);

            mock.Value1 = !mock.Value1;

            Assert.IsTrue(mock.HasChanged);

            mock.ClearHasChanged();

            Assert.IsFalse(mock.HasChanged);

            mock.Value2 = true;

            Assert.IsTrue(mock.HasChanged);
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
