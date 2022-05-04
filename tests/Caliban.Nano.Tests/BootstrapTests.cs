using System;
using Caliban.Nano.Container;
using Caliban.Nano.Tests.Classes;
using Caliban.Nano.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caliban.Nano.Tests
{
    [TestClass]
    public class BootstrapTests
    {
        [TestMethod]
        public void BootstrapTest()
        {
            var bootstrap = new Bootstrap();

            Assert.IsNotNull(bootstrap.Container);
            Assert.IsInstanceOfType(bootstrap.Container, typeof(NanoContainer));

            Assert.AreEqual(TypeFinder.Sources.Count, 1);

            bootstrap.AddSource(GetType().Assembly);

            Assert.AreEqual(TypeFinder.Sources.Count, 2);

            Assert.ThrowsException<TypeLoadException>(() => IoC.Get<IDependency>());

            bootstrap.Register<IDependency>(new TestClass());

            Assert.IsInstanceOfType(IoC.Get<IDependency>(), typeof(TestClass));
        }
    }
}
