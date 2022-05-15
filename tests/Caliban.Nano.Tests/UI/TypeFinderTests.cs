using System;
using Caliban.Nano.Container;
using Caliban.Nano.Tests.Mocks;
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
            var test = TypeFinder.FindViewModel(typeof(MockViewModel));

            Assert.IsNotNull(test);
            Assert.IsInstanceOfType(test, typeof(MockViewModel));
        }

        [TestMethod]
        public void FindViewTest()
        {
            var test = TypeFinder.FindView(typeof(MockView));

            Assert.IsNotNull(test);
            Assert.IsInstanceOfType(test, typeof(MockView));
        }

        [TestMethod]
        public void FindTypeTest()
        {
            var test = TypeFinder.FindType(typeof(MockClass).Name);

            Assert.IsNotNull(test);
            Assert.IsInstanceOfType(test, typeof(MockClass));
        }

        [TestMethod]
        public void FindTypeExceptionTest()
        {
            Assert.ThrowsException<TypeLoadException>(() => TypeFinder.FindType("unknown"));
        }
    }
}
