using System;
using System.Windows.Input;
using Caliban.Nano.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caliban.Nano.Tests.UI
{
    [TestClass]
    public sealed class CommandTests
    {
        [TestMethod]
        public void ExecuteTest()
        {
            var test = new Command<object>(
                (_) => Assert.IsTrue(true)
            );

            test.Execute(new object());
        }

        [TestMethod]
        public void CanExecuteTest()
        {
            var test = new Command<object>(
                (_) => Assert.IsTrue(true),
                (_) => true
            );

            Assert.IsTrue(test.CanExecute(new object()));
        }

        [TestMethod]
        public void CanExecuteDefaultTest()
        {
            var test = new Command<object>(
                (_) => Assert.IsTrue(true)
            );

            Assert.IsTrue(test.CanExecute(new object()));
        }

        [TestMethod]
        public void CanExecuteChangedTest()
        {
            EventHandler handler = (sender, e) =>
            {
                Assert.IsNotNull(sender);
                Assert.IsNotNull(e);
            };

            var test = new Command<object>(
                (_) => Assert.IsTrue(true),
                (_) => true
            );

            test.CanExecuteChanged += handler;

            CommandManager.InvalidateRequerySuggested();

            test.CanExecuteChanged -= handler;
        }
    }
}
