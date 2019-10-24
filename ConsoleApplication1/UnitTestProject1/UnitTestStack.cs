using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestStack
    {
        [TestMethod]
        public void TestPush()
        {
            //Push 3 items, check Count
            Stack S = new Stack(100);
            S.Push("1");
            S.Push("2");
            S.Push("3");
            Assert.AreEqual(3, S.Count());
        }
        [TestMethod]
        public void TestPop()
        {
            // Push some items, check the poped value
            Stack S = new Stack(100);
            S.Push("1");
            S.Push("2");
            S.Push("3");
            Assert.AreEqual("3", S.Pop());
            Assert.AreEqual("2", S.Pop());
        }
        [TestMethod]
        public void TestPeek()
        {
            //Push some items, check Peeked valueand Count
            Stack S = new Stack(100);
            S.Push("1");
            S.Push("2");
            S.Push("3");
            Assert.AreEqual("3", S.Peek());
            Assert.AreEqual(3, S.Count());
        }
    [TestMethod]
        public void TestClear()
        {
        //invoke Clear and check Count
            Stack S = new Stack(100);
            S.Push("1");
            S.Push("2");
            S.Push("3");
            S.Clear();
            Assert.AreEqual(0, S.Count());
            
        }
    }
}
