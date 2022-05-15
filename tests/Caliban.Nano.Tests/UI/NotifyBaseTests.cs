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

            var test = new MockClass();

            test.PropertyChanged += (_, _) => count++;

            test.Notify = true;

            Assert.AreEqual(count, 2);
        }

        [TestMethod]
        public void SetValueTest()
        {
            var names = new List<string?>();

            var test = new MockClass();

            test.PropertyChanged += (s, e) =>
            {
                names.Add(e.PropertyName);
            };

            test.Value1 = true;

            Assert.AreEqual(names.Count, 1);
            Assert.AreEqual(names[0], nameof(test.Value1));

            names.Clear();

            test.Value2 = false;

            Assert.AreEqual(names.Count, 2);
            Assert.AreEqual(names[0], nameof(test.Value1));
            Assert.AreEqual(names[1], nameof(test.Value2));

            names.Clear();

            test.Value2 = false;

            Assert.AreEqual(names.Count, 0);
        }
    }
}
