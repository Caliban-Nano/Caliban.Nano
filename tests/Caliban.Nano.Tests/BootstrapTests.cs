using System;
using Caliban.Nano.Container;
using Caliban.Nano.Tests.Mocks;
using Caliban.Nano.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caliban.Nano.Tests
{
    [TestClass]
    public class BootstrapTests
    {
        [TestInitialize]
        public void Initialize()
        {
            TypeFinder.Sources.Clear();
        }

        [TestMethod]
        public void BootstrapTest()
        {
            var bootstrap = new Bootstrap();

            Assert.IsNotNull(bootstrap.Container);
            Assert.IsInstanceOfType(bootstrap.Container, typeof(NanoContainer));

            Assert.AreEqual(1, TypeFinder.Sources.Count);

            bootstrap.AddSource(GetType().Assembly);

            Assert.AreEqual(2, TypeFinder.Sources.Count);

            Assert.ThrowsException<TypeLoadException>(() => IoC.Get<IMock>());

            bootstrap.Register<MockClass>(typeof(MockClass));

            Assert.IsInstanceOfType(IoC.Get<MockClass>(), typeof(MockClass));

            bootstrap.Register<IMock>(new MockClass());

            Assert.IsInstanceOfType(IoC.Get<IMock>(), typeof(MockClass));
        }
    }
}
