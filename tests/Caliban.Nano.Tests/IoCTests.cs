using System;
using Caliban.Nano.Container;
using Caliban.Nano.Contracts;
using Caliban.Nano.Tests.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caliban.Nano.Tests
{
    [TestClass]
    public sealed class IoCTests
    {
        private IContainer? Container { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            Container = new NanoContainer();

            IoC.Resolve = Container.Resolve;
        }

        [TestMethod]
        public void ResolveTest()
        {
            ArgumentNullException.ThrowIfNull(Container);

            var test = new MockClass();

            Container.Register<MockClass>(test);

            Assert.AreEqual(IoC.Resolve(typeof(MockClass)), test);
        }

        [TestMethod]
        public void GetTest()
        {
            ArgumentNullException.ThrowIfNull(Container);

            var test = new MockClass();

            Container.Register<MockClass>(test);

            Assert.AreEqual(IoC.Get<MockClass>(), test);
        }
    }
}
