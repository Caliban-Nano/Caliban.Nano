using System;
using Caliban.Nano.Container;
using Caliban.Nano.Contracts;
using Caliban.Nano.Tests.Classes;
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

            var test = new TestClass();

            Container.Register<TestClass>(test);

            Assert.AreEqual(IoC.Resolve(typeof(TestClass)), test);
        }

        [TestMethod]
        public void GetTest()
        {
            ArgumentNullException.ThrowIfNull(Container);

            var test = new TestClass();

            Container.Register<TestClass>(test);

            Assert.AreEqual(IoC.Get<TestClass>(), test);
        }
    }
}
