using System.Linq;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using Caliban.Nano.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caliban.Nano.Tests.UI
{
    [TestClass]
    public sealed class ViewBinderTests
    {
        [TestMethod]
        public void ConstructorTest()
        {
            Assert.AreNotEqual(ViewBinder.Scope.Count, 0);
        }

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

        [TestClass]
        public sealed class BindingsTests
        {
            [TestMethod]
            public void DefaultTest()
            {
                ViewBinder.Scope.Clear();

                Assert.AreEqual(ViewBinder.Scope.Count, 0);

                ViewBinder.Bindings.Default();

                var types = ViewBinder.Scope.Select(x => x.Item1);

                Assert.IsTrue(types.Contains(typeof(Control)));
                Assert.IsTrue(types.Contains(typeof(Button)));
                Assert.IsTrue(types.Contains(typeof(Image)));
                Assert.IsTrue(types.Contains(typeof(Label)));
                Assert.IsTrue(types.Contains(typeof(TextBox)));
                Assert.IsTrue(types.Contains(typeof(TextBlock)));
                Assert.IsTrue(types.Contains(typeof(ProgressBar)));
                Assert.IsTrue(types.Contains(typeof(CheckBox)));
                Assert.IsTrue(types.Contains(typeof(RadioButton)));
                Assert.IsTrue(types.Contains(typeof(Calendar)));
                Assert.IsTrue(types.Contains(typeof(DatePicker)));
                Assert.IsTrue(types.Contains(typeof(Selector)));
                Assert.IsTrue(types.Contains(typeof(ItemsControl)));
                Assert.IsTrue(types.Contains(typeof(DocumentViewer)));
                Assert.IsTrue(types.Contains(typeof(ContentControl)));
                Assert.IsTrue(types.Contains(typeof(Control)));
                Assert.IsTrue(types.Contains(typeof(Control)));
            }
        }

        [TestClass]
        public sealed class BindingUtilsTests
        {
            [TestMethod]
            public void IsSubPropertyTest()
            {
                Assert.IsTrue(ViewBinder.BindingUtils.IsSubProperty("Property.Sub"));
            }

            [TestMethod]
            public void GetPathWithGuardTest()
            {
                var path = ViewBinder.BindingUtils.GetPathWithGuard("Action");

                Assert.AreEqual(path, "CanAction");
            }

            [TestMethod]
            public void GetPathWithItemTest()
            {
                var path = ViewBinder.BindingUtils.GetPathWithItem("Items");

                Assert.AreEqual(path, "ItemsSelected");
            }

            [TestMethod]
            public void GetPathWithViewTest()
            {
                var path = ViewBinder.BindingUtils.GetPathWithView("Content");

                Assert.AreEqual(path, "Content.View");
            }

            [TestMethod]
            public void GetDependencyPropertyPassedTest()
            {
                var dp = ViewBinder.BindingUtils.GetDependencyProperty("Text", typeof(TextBox));

                Assert.IsNotNull(dp);
                Assert.AreEqual(dp, TextBox.TextProperty);
            }

            [TestMethod]
            public void GetDependencyPropertyFailedTest()
            {
                var dp = ViewBinder.BindingUtils.GetDependencyProperty("Unknown", typeof(TextBox));

                Assert.IsNull(dp);
            }
        }
    }
}
