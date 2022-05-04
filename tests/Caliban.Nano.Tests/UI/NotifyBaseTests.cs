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
            var test = new TestClass();

            test.PropertyChanged += (_, e) => Assert.AreEqual(e.PropertyName, "Test");
            test.Test();
        }
    }
}
