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

            var resolver = new ViewBinder.Resolver((_, _) => true);

            Assert.AreEqual(ViewBinder.Scope.Count, 0);

            ViewBinder.AddResolver<Control>(resolver);

            Assert.AreEqual(ViewBinder.Scope.Count, 1);
            Assert.AreEqual(ViewBinder.Scope[0].Item2, resolver);
        }

        [TestMethod]
        public void BindTest()
        {
            Assert.IsTrue(true); // TODO
        }
    }
}
