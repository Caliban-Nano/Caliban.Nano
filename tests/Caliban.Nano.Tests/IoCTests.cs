using System;
using Caliban.Nano.Container;
using Caliban.Nano.Contracts;
using Caliban.Nano.Test.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caliban.Nano.Tests
{
    [TestClass]
    public sealed class IoCTests
    {
        private IContainer? Container { get; set; }

        private void Initialize()
        {
            Container = new NanoContainer();

            IoC.Resolve = Container.Resolve;
        }

        [TestMethod]
        public void ExceptionTest()
        {
            Assert.ThrowsException<NotImplementedException>(() => IoC.Get<TestClass>());
        }

        [TestMethod]
        public void ResolveTest()
        {
            Initialize();

            var test = new TestClass();

            Container?.Register<TestClass>(test);

            Assert.AreEqual(IoC.Resolve(typeof(TestClass)), test);
        }

        [TestMethod]
        public void GetTest()
        {
            Initialize();

            var test = new TestClass();

            Container?.Register<TestClass>(test);

            Assert.AreEqual(IoC.Get<TestClass>(), test);
        }
    }
}
