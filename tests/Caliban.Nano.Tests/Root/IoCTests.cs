using System;
using Caliban.Nano.Container;
using Caliban.Nano.Contracts;
using Caliban.Nano.Tests.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caliban.Nano.Tests.Root
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

            var mock = new MockClass();

            Container.Register<IMock>(mock);

            Assert.AreEqual(IoC.Resolve(typeof(IMock)), mock);
        }

        [TestMethod]
        public void GetTest()
        {
            ArgumentNullException.ThrowIfNull(Container);

            var mock = new MockClass();

            Container.Register<IMock>(mock);

            Assert.AreEqual(IoC.Get<IMock>(), mock);
        }
    }
}
