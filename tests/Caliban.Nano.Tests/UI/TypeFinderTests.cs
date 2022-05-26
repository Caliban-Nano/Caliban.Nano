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
            var viewModel = TypeFinder.FindViewModel(typeof(MockViewModel));

            Assert.IsNotNull(viewModel);
            Assert.IsInstanceOfType(viewModel, typeof(MockViewModel));
        }

        [TestMethod]
        public void FindViewTest()
        {
            var view = TypeFinder.FindView(typeof(MockView));

            Assert.IsNotNull(view);
            Assert.IsInstanceOfType(view, typeof(MockView));
        }

        [TestMethod]
        public void FindModelTest()
        {
            var model = TypeFinder.FindModel(typeof(MockModel));

            Assert.IsNotNull(model);
            Assert.IsInstanceOfType(model, typeof(MockModel));
        }

        [TestMethod]
        public void FindTypeTest()
        {
            var type = TypeFinder.FindType(typeof(MockClass).Name);

            Assert.IsNotNull(type);
            Assert.IsInstanceOfType(type, typeof(MockClass));
        }

        [TestMethod]
        public void FindTypeExceptionTest()
        {
            Assert.ThrowsException<TypeLoadException>(() => TypeFinder.FindType("Unknown"));
        }
    }
}
