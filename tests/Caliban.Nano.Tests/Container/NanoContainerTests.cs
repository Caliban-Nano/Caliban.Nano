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

            Assert.IsFalse(Container.CanResolve<IMock>());

            Container.Bind<IMock>(new MockClass());

            using (Container)
            {
                Assert.IsTrue(Container.CanResolve<IMock>());
            }

            Assert.IsFalse(Container.CanResolve<IMock>());
        }

        [TestMethod]
        public void ResolvedTest()
        {
            ArgumentNullException.ThrowIfNull(Container);

            Container.Bind<IMock>(new MockClass());
            Container.Resolved += (instance) =>
            {
                Assert.IsNotNull(instance);
                Assert.IsInstanceOfType(instance, typeof(MockClass));
            };

            Container.Resolve<IMock>();
        }

        [TestMethod]
        public void ResolveTypeTest()
        {
            ArgumentNullException.ThrowIfNull(Container);

            Container.Bind<IMock>(new MockClass());

            Assert.IsTrue(Container.CanResolve<IMock>());

            var instance = Container.Resolve<IMock>();

            Assert.IsNotNull(instance);
            Assert.IsInstanceOfType(instance, typeof(MockClass));
        }

        [TestMethod]
        public void ResolvePassedTest()
        {
            ArgumentNullException.ThrowIfNull(Container);

            Container.Bind<MockClass>(typeof(MockClass));

            Assert.IsTrue(Container.CanResolve<MockClass>());

            Container.Bind<IMock>(new MockClass());

            Assert.IsTrue(Container.CanResolve<IMock>());

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
        }

        [TestMethod]
        public void ResolveFailedTest()
        {
            ArgumentNullException.ThrowIfNull(Container);

            Assert.ThrowsException<TypeLoadException>(() => Container.Resolve<IMock>());
        }

        [TestMethod]
        public void CanResolveTest()
        {
            ArgumentNullException.ThrowIfNull(Container);

            Assert.IsFalse(Container.CanResolve<IMock>());

            Container.Bind<IMock>(new MockClass());

            Assert.IsTrue(Container.CanResolve<IMock>());

            Container.Unbind<IMock>();

            Assert.IsFalse(Container.CanResolve<IMock>());
        }

        [TestMethod]
        public void CreatePassedTest()
        {
            ArgumentNullException.ThrowIfNull(Container);

            Container.Bind<IMock>(new MockClass());

            Assert.IsTrue(Container.CanResolve<IMock>());

            var instance = Container.Create(typeof(MockClass));

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
        }

        [TestMethod]
        public void CreateFailedTest()
        {
            ArgumentNullException.ThrowIfNull(Container);

            Assert.ThrowsException<TypeLoadException>(() => Container.Create(typeof(MockClassPrivate)));
        }

        [TestMethod]
        public void BuildTest()
        {
            ArgumentNullException.ThrowIfNull(Container);

            var mock = new MockClass();

            Container.Bind<IMock>(mock);

            Container.Build(mock);

            Assert.IsNull(mock.DependencyA);

            Assert.IsNotNull(mock.DependencyB);
            Assert.IsInstanceOfType(mock.DependencyB, typeof(MockClass));

            Assert.IsNotNull(mock.DependencyC);
            Assert.IsInstanceOfType(mock.DependencyC, typeof(MockClass));

            Assert.IsNotNull(mock.DependencyD);
            Assert.IsInstanceOfType(mock.DependencyD, typeof(MockClass));
        }

        [TestMethod]
        public void BuildRecursiveTest()
        {
            ArgumentNullException.ThrowIfNull(Container);

            var mock = new MockClass();

            Container.Bind<IMock>(typeof(MockClassEmpty));

            Container.Build(mock);

            Assert.IsNull(mock.DependencyA);

            Assert.IsNotNull(mock.DependencyB);
            Assert.IsInstanceOfType(mock.DependencyB, typeof(MockClassEmpty));

            Assert.IsNotNull(mock.DependencyC);
            Assert.IsInstanceOfType(mock.DependencyC, typeof(MockClassEmpty));

            Assert.IsNotNull(mock.DependencyD);
            Assert.IsInstanceOfType(mock.DependencyD, typeof(MockClassEmpty));
        }

        [TestMethod]
        public void BindInstanceTest()
        {
            ArgumentNullException.ThrowIfNull(Container);

            var mock = new MockClass();

            Container.Bind<IMock>(mock);

            Assert.AreEqual(Container.Resolve<IMock>(), mock);
        }

        [TestMethod]
        public void BindTypeTest()
        {
            ArgumentNullException.ThrowIfNull(Container);

            var type = typeof(MockClass);

            Container.Bind<MockClass>(type);

            Assert.IsInstanceOfType(Container.Resolve<MockClass>(), typeof(MockClass));
        }

        [TestMethod]
        public void BindLambdaTest()
        {
            ArgumentNullException.ThrowIfNull(Container);

            var count = 0;

            Container.Bind<MockClass>(() => ++count);

            var lambda = (Func<int>)Container.Resolve<MockClass>();

            Assert.AreEqual(lambda(), 1);
        }

        [TestMethod]
        public void UnbindTest()
        {
            ArgumentNullException.ThrowIfNull(Container);

            var mock = new MockClass();

            Container.Bind<IMock>(mock);

            Assert.AreEqual(Container.Resolve(typeof(IMock)), mock);

            Container.Unbind<IMock>();

            Assert.ThrowsException<TypeLoadException>(() => Container.Resolve(typeof(IMock)));
        }
    }
}
