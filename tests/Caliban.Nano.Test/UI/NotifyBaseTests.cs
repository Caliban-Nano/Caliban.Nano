using Caliban.Nano.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caliban.Nano.Test.UI
{
    [TestClass]
    public class NotifyBaseTests : NotifyBase
    {
        [TestInitialize]
        public void Setup()
        {
            PropertyChanged += (sender, e) =>
            {
                Assert.AreEqual(e.PropertyName, "Test");
            };
        }

        [TestMethod]
        public void NotifyPropertyChangedTest()
        {
            NotifyPropertyChanged("Test");
        }
    }
}
