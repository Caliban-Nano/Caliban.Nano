using System.Collections.Generic;
using Caliban.Nano.Tests.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caliban.Nano.Tests.UI
{
    [TestClass]
    public sealed class NotifyBaseTests
    {
        [TestMethod]
        public void NotifyPropertyChangedTest()
        {
            var count = 0;
            var mock = new MockClass();

            mock.PropertyChanged += (_, _) => count++;
            mock.Notify = true;

            Assert.AreEqual(count, 2);
        }

        [TestMethod]
        public void SetValueTest()
        {
            var names = new List<string?>();
            var mock = new MockClass();

            mock.PropertyChanged += (_, e) => names.Add(e.PropertyName);
            mock.Value1 = true;

            Assert.AreEqual(names.Count, 1);
            Assert.AreEqual(names[0], nameof(mock.Value1));

            names.Clear();

            mock.Value2 = false;

            Assert.AreEqual(names.Count, 2);
            Assert.AreEqual(names[0], nameof(mock.Value1));
            Assert.AreEqual(names[1], nameof(mock.Value2));

            names.Clear();

            mock.Value2 = false;

            Assert.AreEqual(names.Count, 0);
        }
    }
}
