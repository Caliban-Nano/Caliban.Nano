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

            test.PropertyChanged += (_, e) => count++;

            test.TestProperty = true;

            Assert.AreEqual(count, 2);
        }
    }
}
