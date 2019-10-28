using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyQueue;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            myQueue acc = new myQueue(10);
        }
        [TestMethod]
        public void TestEnqueue()
        {
            myQueue S = new myQueue();
            S.Enqueue("1");
            S.Enqueue("2");
            S.Enqueue("3");
            Assert.AreEqual(3, S.Count());
        }
        [TestMethod]
        public void TestDequeue()
        {
            myQueue S = new myQueue();
            S.Enqueue("1");
            S.Enqueue("2");
            S.Enqueue("3");
            Assert.AreEqual("1", S.Dequeue());
            Assert.AreEqual("2", S.Dequeue());
        }
        [TestMethod]
        public void TestPeek()
        {
            myQueue S = new myQueue();
            S.Enqueue("1");
            S.Enqueue("2");
            S.Enqueue("3");
            Assert.AreEqual("1", S.Peek());
            Assert.AreEqual(3, S.Count());
        }
        [TestMethod]
        public void TestClear()
        {
            myQueue S = new myQueue();
            S.Enqueue("1");
            S.Enqueue("2");
            S.Enqueue("3");
            S.Clear();
            Assert.AreEqual(0, S.Count());
        }
    }

}
