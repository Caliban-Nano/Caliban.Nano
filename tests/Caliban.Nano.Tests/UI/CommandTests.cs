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
            var command = new Command<object>(
                (_) => Assert.IsTrue(true)
            );

            command.Execute(new object());
        }

        [TestMethod]
        public void CanExecuteTest()
        {
            var command = new Command<object>(
                (_) => Assert.IsTrue(true),
                (_) => true
            );

            Assert.IsTrue(command.CanExecute(new object()));
        }

        [TestMethod]
        public void CanExecuteDefaultTest()
        {
            var command = new Command<object>(
                (_) => Assert.IsTrue(true)
            );

            Assert.IsTrue(command.CanExecute(new object()));
        }

        [TestMethod]
        public void CanExecuteChangedTest()
        {
            EventHandler handler = (sender, e) =>
            {
                Assert.IsNotNull(sender);
                Assert.IsNotNull(e);
            };

            var command = new Command<object>(
                (_) => Assert.IsTrue(true)
            );

            command.CanExecuteChanged += handler;

            CommandManager.InvalidateRequerySuggested();

            command.CanExecuteChanged -= handler;
        }

        [TestMethod]
        public void RaiseCanExecuteChangedTest()
        {
            var command = new Command<object>(
                (_) => Assert.IsTrue(true)
            );

            command.CanExecuteChanged += (sender, e) =>
            {
                Assert.IsNotNull(sender);
                Assert.IsNotNull(e);
            };

            command.RaiseCanExecuteChanged();
        }
    }
}
