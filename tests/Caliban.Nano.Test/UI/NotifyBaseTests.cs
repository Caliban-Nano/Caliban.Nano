using Caliban.Nano.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caliban.Nano.Test.UI
{
    [TestClass]
    public class NotifyBaseTests
    {
        private class Notify : NotifyBase
        {
            public void Test() => NotifyPropertyChanged();
        }

        [TestMethod]
        public void NotifyPropertyChangedTest()
        {
            var notify = new Notify();

            notify.PropertyChanged += (_, e) => Assert.AreEqual(e.PropertyName, "Test");
            notify.Test();
        }
    }
}
