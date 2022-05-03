using System.Windows.Controls;
using Caliban.Nano.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caliban.Nano.Tests.UI
{
    [TestClass]
    public sealed class ViewBinderTests
    {
        [TestMethod]
        public void AddResolverTest()
        {
            ViewBinder.Scope.Clear();

            Assert.AreEqual(ViewBinder.Scope.Count, 0);

            ViewBinder.AddResolver<Control>(new ViewBinder.Resolver((_, _) => true));

            Assert.AreEqual(ViewBinder.Scope.Count, 1);
        }

        [TestMethod]
        public void BindTest()
        {
            Assert.IsTrue(true); // TODO
        }
    }
}
