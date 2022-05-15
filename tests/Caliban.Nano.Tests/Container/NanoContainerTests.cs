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
            Container.Resolved += (instance) =>
            {
                Assert.IsNotNull(instance);
                Assert.IsInstanceOfType(instance, typeof(MockClass));
            };

            Container.Resolve(typeof(MockClass));
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
        public void ResolvePassedTest()
        {
            ArgumentNullException.ThrowIfNull(Container);

            Container.Register<IMock>(new MockClass());

            Assert.IsTrue(Container.IsRegistered<IMock>());

            var instance = Container.Resolve(typeof(MockClass));

            Assert.IsNotNull(instance);
            Assert.IsInstanceOfType(instance, typeof(MockClass));

            var mock = (MockClass)instance;

            Assert.IsNotNull(mock.DependencyA);
            Assert.IsInstanceOfType(mock.DependencyA, typeof(MockClass));

            Assert.IsNotNull(mock.DependencyB);
            Assert.IsInstanceOfType(mock.DependencyB, typeof(MockClass));

            Assert.IsNotNull(mock.DependencyC);
            Assert.IsInstanceOfType(mock.DependencyC, typeof(MockClass));

            Assert.IsNotNull(mock.DependencyD);
            Assert.IsInstanceOfType(mock.DependencyD, typeof(MockClass));

            Container.Register<MockClass>(mock);

            Assert.AreEqual(Container.Resolve(typeof(MockClass)), mock);

            mock = (MockClass)Container.Resolve(new MockClass());

            Assert.IsNull(mock.DependencyA);

            Assert.IsNotNull(mock.DependencyB);
            Assert.IsInstanceOfType(mock.DependencyB, typeof(MockClass));

            Assert.IsNotNull(mock.DependencyC);
            Assert.IsInstanceOfType(mock.DependencyC, typeof(MockClass));

            Assert.IsNotNull(mock.DependencyD);
            Assert.IsInstanceOfType(mock.DependencyD, typeof(MockClass));
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

            var mock = new MockClass();

            Container.Register<MockClass>(mock);

            Assert.AreEqual(Container.Resolve(typeof(MockClass)), mock);

            Container.Unregister<MockClass>();

            Assert.AreNotEqual(Container.Resolve(typeof(MockClass)), mock);
        }
    }
}
