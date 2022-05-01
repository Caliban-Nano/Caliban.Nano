using System;
using Caliban.Nano.Container;
using Caliban.Nano.Contracts;
using Caliban.Nano.Test.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caliban.Nano.Test.Container
{
    [TestClass]
    public class NanoContainerTests
    {
        private static IContainer? Container { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            Container = new NanoContainer();
        }

        [TestMethod]
        public void DisposeTest()
        {
            ArgumentNullException.ThrowIfNull(Container);

            Assert.IsFalse(Container.IsRegistered<TestClass>());

            Container.Register<TestClass>(new TestClass());

            using (Container)
            {
                Assert.IsTrue(Container.IsRegistered<TestClass>());
            }

            Assert.IsFalse(Container.IsRegistered<TestClass>());
        }

        [TestMethod]
        public void ResolvedTest()
        {
            ArgumentNullException.ThrowIfNull(Container);

            Container.Register<TestClass>(new TestClass());
            Container.Resolved += (test) => {
                Assert.IsNotNull(test);
                Assert.IsInstanceOfType(test, typeof(TestClass));
            };

            Container.Resolve(typeof(TestClass));
        }

        [TestMethod]
        public void ResolveTest()
        {
            ArgumentNullException.ThrowIfNull(Container);

            Container.Register<IDependency>(new TestClass());

            Assert.IsTrue(Container.IsRegistered<IDependency>());

            var instance = Container.Resolve(typeof(TestClass));

            Assert.IsNotNull(instance);
            Assert.IsInstanceOfType(instance, typeof(TestClass));

            var test = (TestClass)instance;

            Assert.IsNotNull(test.A);
            Assert.IsInstanceOfType(test.A, typeof(TestClass));

            Assert.IsNotNull(test.B);
            Assert.IsInstanceOfType(test.B, typeof(TestClass));

            Assert.IsNotNull(test.C);
            Assert.IsInstanceOfType(test.C, typeof(TestClass));

            Assert.IsNotNull(test.D);
            Assert.IsInstanceOfType(test.D, typeof(TestClass));

            Container.Register<TestClass>(test);

            Assert.AreEqual(Container.Resolve(typeof(TestClass)), test);

            test = (TestClass)Container.Resolve(new TestClass());

            Assert.IsNull(test.A);

            Assert.IsNotNull(test.B);
            Assert.IsInstanceOfType(test.B, typeof(TestClass));

            Assert.IsNotNull(test.C);
            Assert.IsInstanceOfType(test.C, typeof(TestClass));

            Assert.IsNotNull(test.D);
            Assert.IsInstanceOfType(test.D, typeof(TestClass));
        }

        [TestMethod]
        public void RegisterTest()
        {
            ArgumentNullException.ThrowIfNull(Container);

            Container.Register<TestClass>(new TestClass());

            Assert.IsNotNull(Container.Resolve(typeof(TestClass)));
        }

        [TestMethod]
        public void IsRegisteredTest()
        {
            ArgumentNullException.ThrowIfNull(Container);

            Assert.IsFalse(Container.IsRegistered<TestClass>());

            Container.Register<TestClass>(new TestClass());

            Assert.IsTrue(Container.IsRegistered<TestClass>());

            Container.Unregister<TestClass>();

            Assert.IsFalse(Container.IsRegistered<TestClass>());
        }

        [TestMethod]
        public void UnregisterTest()
        {
            ArgumentNullException.ThrowIfNull(Container);

            var test = new TestClass();

            Container.Register<TestClass>(test);

            Assert.AreEqual(Container.Resolve(typeof(TestClass)), test);

            Container.Unregister<TestClass>();

            Assert.AreNotEqual(Container.Resolve(typeof(TestClass)), test);
        }
    }
}
