using Caliban.Nano.Container;
using Caliban.Nano.Test.Classes;
using Caliban.Nano.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caliban.Nano.Test.UI
{
    [TestClass]
    public class TypeFinderTests
    {
        [TestInitialize]
        public void Setup()
        {
            var container = new NanoContainer();

            IoC.Resolve = container.Resolve;

            TypeFinder.Sources.Add(GetType().Assembly);
        }

        [TestMethod]
        public void FindViewModelTest()
        {
            var test = TypeFinder.FindViewModel(typeof(TestViewModel));

            Assert.IsNotNull(test);
            Assert.IsInstanceOfType(test, typeof(TestViewModel));
        }

        [TestMethod]
        public void FindViewTest()
        {
            var test = TypeFinder.FindView(typeof(TestView));

            Assert.IsNotNull(test);
            Assert.IsInstanceOfType(test, typeof(TestView));
        }

        [TestMethod]
        public void FindTypeTest()
        {
            var test = TypeFinder.FindType(typeof(TestClass).Name);

            Assert.IsNotNull(test);
            Assert.IsInstanceOfType(test, typeof(TestClass));
        }
    }
}
