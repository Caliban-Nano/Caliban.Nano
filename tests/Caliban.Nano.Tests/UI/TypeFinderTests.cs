using System;
using Caliban.Nano.Container;
using Caliban.Nano.Tests.Classes;
using Caliban.Nano.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caliban.Nano.Tests.UI
{
    [TestClass]
    public sealed class TypeFinderTests
    {
        [TestInitialize]
        public void Initialize()
        {
            TypeFinder.Sources.Add(GetType().Assembly);

            IoC.Resolve = new NanoContainer().Resolve;
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

        [TestMethod]
        public void FindTypeExceptionTest()
        {
            Assert.ThrowsException<TypeLoadException>(() => TypeFinder.FindType("unknown"));
        }
    }
}
