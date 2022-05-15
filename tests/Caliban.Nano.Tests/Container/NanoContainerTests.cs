using System;
using Caliban.Nano.Container;
using Caliban.Nano.Contracts;
using Caliban.Nano.Tests.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caliban.Nano.Tests.Container
{
    [TestClass]
    public sealed class NanoContainerTests
    {
        private IContainer? Container { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            Container = new NanoContainer();
        }

        [TestMethod]
        public void DisposeTest()
        {
            ArgumentNullException.ThrowIfNull(Container);

            Assert.IsFalse(Container.IsRegistered<MockClass>());

            Container.Register<MockClass>(new MockClass());

            using (Container)
            {
                Assert.IsTrue(Container.IsRegistered<MockClass>());
            }

            Assert.IsFalse(Container.IsRegistered<MockClass>());
        }

        [TestMethod]
        public void ResolvedTest()
        {
            ArgumentNullException.ThrowIfNull(Container);

            Container.Register<MockClass>(new MockClass());
            Container.Resolved += (test) =>
            {
                Assert.IsNotNull(test);
                Assert.IsInstanceOfType(test, typeof(MockClass));
            };

            Container.Resolve(typeof(MockClass));
        }

        [TestMethod]
        public void ResolveTest()
        {
            ArgumentNullException.ThrowIfNull(Container);

            Container.Register<IMock>(new MockClass());

            Assert.IsTrue(Container.IsRegistered<IMock>());

            var instance = Container.Resolve(typeof(MockClass));

            Assert.IsNotNull(instance);
            Assert.IsInstanceOfType(instance, typeof(MockClass));

            var test = (MockClass)instance;

            Assert.IsNotNull(test.DependencyA);
            Assert.IsInstanceOfType(test.DependencyA, typeof(MockClass));

            Assert.IsNotNull(test.DependencyB);
            Assert.IsInstanceOfType(test.DependencyB, typeof(MockClass));

            Assert.IsNotNull(test.DependencyC);
            Assert.IsInstanceOfType(test.DependencyC, typeof(MockClass));

            Assert.IsNotNull(test.DependencyD);
            Assert.IsInstanceOfType(test.DependencyD, typeof(MockClass));

            Container.Register<MockClass>(test);

            Assert.AreEqual(Container.Resolve(typeof(MockClass)), test);

            test = (MockClass)Container.Resolve(new MockClass());

            Assert.IsNull(test.DependencyA);

            Assert.IsNotNull(test.DependencyB);
            Assert.IsInstanceOfType(test.DependencyB, typeof(MockClass));

            Assert.IsNotNull(test.DependencyC);
            Assert.IsInstanceOfType(test.DependencyC, typeof(MockClass));

            Assert.IsNotNull(test.DependencyD);
            Assert.IsInstanceOfType(test.DependencyD, typeof(MockClass));
        }

        [TestMethod]
        public void ResolveTypeTest()
        {
            ArgumentNullException.ThrowIfNull(Container);

            Container.Register<IMock>(new MockClass());

            Assert.IsTrue(Container.IsRegistered<IMock>());

            var instance = Container.Resolve<MockClass>();

            Assert.IsNotNull(instance);
            Assert.IsInstanceOfType(instance, typeof(MockClass));
        }

        [TestMethod]
        public void ResolveFailedTest()
        {
            ArgumentNullException.ThrowIfNull(Container);

            Assert.ThrowsException<TypeLoadException>(() => Container.Resolve<IMock>());
        }

        [TestMethod]
        public void RegisterTest()
        {
            ArgumentNullException.ThrowIfNull(Container);

            Container.Register<MockClass>(new MockClass());

            Assert.IsNotNull(Container.Resolve(typeof(MockClass)));
        }

        [TestMethod]
        public void IsRegisteredTest()
        {
            ArgumentNullException.ThrowIfNull(Container);

            Assert.IsFalse(Container.IsRegistered<MockClass>());

            Container.Register<MockClass>(new MockClass());

            Assert.IsTrue(Container.IsRegistered<MockClass>());

            Container.Unregister<MockClass>();

            Assert.IsFalse(Container.IsRegistered<MockClass>());
        }

        [TestMethod]
        public void UnregisterTest()
        {
            ArgumentNullException.ThrowIfNull(Container);

            var test = new MockClass();

            Container.Register<MockClass>(test);

            Assert.AreEqual(Container.Resolve(typeof(MockClass)), test);

            Container.Unregister<MockClass>();

            Assert.AreNotEqual(Container.Resolve(typeof(MockClass)), test);
        }
    }
}
