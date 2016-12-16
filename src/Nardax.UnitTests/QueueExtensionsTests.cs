using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Nardax.UnitTests
{
    [TestClass]
    public class QueueExtensionsTests
    {
        Queue<string> _queue;

        public QueueExtensionsTests()
        {
            _queue = new Queue<string>();
            
            Assert.AreEqual("bb", _queue.Dequeue());
            Assert.AreEqual("cc", _queue.Dequeue());
            Assert.AreEqual("dd", _queue.Dequeue());
            Assert.AreEqual("ee", _queue.Dequeue());
        }
    }
}
