using System.Collections.Generic;
using Caliban.Nano.Tests.Classes;
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

            var test = new TestClass();

            test.PropertyChanged += (_, _) => count++;

            test.TestNotify = true;

            Assert.AreEqual(count, 2);
        }

        [TestMethod]
        public void SetValueTest()
        {
            var names = new List<string?>();

            var test = new TestClass();

            test.PropertyChanged += (s, e) =>
            {
                names.Add(e.PropertyName);
            };

            test.TestValue1 = true;

            Assert.AreEqual(names.Count, 1);
            Assert.AreEqual(names[0], nameof(test.TestValue1));

            names.Clear();

            test.TestValue2 = false;

            Assert.AreEqual(names.Count, 2);
            Assert.AreEqual(names[0], nameof(test.TestValue1));
            Assert.AreEqual(names[1], nameof(test.TestValue2));

            names.Clear();

            test.TestValue2 = false;

            Assert.AreEqual(names.Count, 0);
        }
    }
}
