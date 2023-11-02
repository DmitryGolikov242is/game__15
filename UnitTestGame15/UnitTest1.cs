using game15;
using NUnit.Framework;

namespace UnitTestGame15
{
    [TestClass]
    public class MoveTest
    {
        [TestMethod]
        public void TestRight()
        {
            Form1.arr = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 0 };
            List<int> expected = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 0, 15 };
            Class1.move("15");
            CollectionAssert.AreEqual(expected, Form1.arr);
        }
        [TestMethod]
        public void TestDown()
        {
            Form1.arr = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 0, 15 };
            List<int> expected = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 0, 12, 13, 14, 11, 15 };
            Class1.move("11");
            CollectionAssert.AreEqual(expected, Form1.arr);
        }
        [TestMethod]
        public void TestLeft()
        {
            Form1.arr = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 0, 12, 13, 14, 11, 15 };
            List<int> expected = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 0, 13, 14, 11, 15 };
            Class1.move("12");
            CollectionAssert.AreEqual(expected, Form1.arr);
        }
        [TestMethod]
        public void TestUp()
        {
            Form1.arr = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 0, 13, 14, 11, 15 };
            List<int> expected = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 15, 13, 14, 11, 0 };
            Class1.move("15");
            CollectionAssert.AreEqual(expected, Form1.arr);
        }
        [TestMethod]
        public void TestNoMove()
        {
            Form1.arr = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 0 };
            List<int> expected = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 0 };
            Class1.move("4");
            CollectionAssert.AreEqual(expected, Form1.arr);
        }
    }
    [TestClass]
    public class CheckTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Form1.arr = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 0, 15 };
            List<int> expected = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 0 };
            Class1.move("15");
            bool res = Class2.check();
            Assert.AreEqual(res, true);
        }

    }
    [TestClass]
    public class NewRandomTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Form1.arr = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 0 };
            List<int> expected = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 0 };
            Class2.renew();
            CollectionAssert.AreNotEqual(expected, Form1.arr);
        }

    }
}