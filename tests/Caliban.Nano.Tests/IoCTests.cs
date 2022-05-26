using Caliban.Nano.Container;
using Caliban.Nano.Contracts;
using Caliban.Nano.Tests.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caliban.Nano.Tests
{
    [TestClass]
    public sealed class IoCTests
    {
        [TestInitialize]
        public void Initialize()
        {
            IoC.Container = new NanoContainer();
        }

        [TestMethod]
        public void ContainerTest()
        {
            Assert.IsNotNull(IoC.Container);
            Assert.IsInstanceOfType(IoC.Container, typeof(IContainer));
        }

        [TestMethod]
        public void GetTest()
        {
            var mock = new MockClass();

            IoC.Container.Bind<IMock>(mock);

            Assert.AreEqual(IoC.Get<IMock>(), mock);
        }
    }
}
