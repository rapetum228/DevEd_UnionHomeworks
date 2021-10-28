using NUnit.Framework;

namespace LinkedLists.Tests
{
    public class LinkListTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(20)]
        public void ToArrayTest(int ID)
        {
            //arrange
            LinkList toTest = TestDataLinkList.GetListForToArrayAndGetLengthTest(ID);
            int[] expected = TestDataLinkList.GetExpectedArrayForToArrayTest(ID);
            //act
            int[] actual = toTest.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 1)]
        [TestCase(1, 1)]
        [TestCase(2, 4)]
        [TestCase(20, 0)]
        public void GetLengthTest(int ID, int expected)
        {
            //arrange
            LinkList toTest = TestDataLinkList.GetListForToArrayAndGetLengthTest(ID);
            //act
            int actual = toTest.GetLength();
            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase(20, 0)]
        [TestCase(2, 5)]
        [TestCase(0, 2)]
        [TestCase(1, 12)]
        public void AddLastTest(int ID, int value)
        {
            //arrange
            LinkList toTest = TestDataLinkList.GetListForAddLastTest(ID);
            int[] expected = TestDataLinkList.GetExpectedArrayForAddLastTest(ID);
            //act
            toTest.AddLast(value);
            int[] actual = toTest.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(20)]
        [TestCase(2)]
        [TestCase(0)]
        [TestCase(1)]
        public void AddLastListTest(int ID)
        {
            //arrange
            LinkList toTest = TestDataLinkList.GetListForAddLastTest(ID);
            LinkList add = TestDataLinkList.GetAddListForAddLastTest(ID);
            LinkList expected = TestDataLinkList.GetExpectedListForAddLastTest(ID);
            //act
            toTest.AddLast(add);
            int[] actual = toTest.ToArray();
            
            //assert
            Assert.AreEqual(expected.ToArray(), actual);
        }

        [TestCase(20, 0)]
        [TestCase(2, 5)]
        [TestCase(0, 2)]
        [TestCase(1, 12)]
        public void AddFirstTest(int ID, int value)
        {
            //arrange
            LinkList toTest = TestDataLinkList.GetListForAddFirstTest(ID);
            int[] expected = TestDataLinkList.GetExpectedArrayForAddFirstTest(ID);
            //act
            toTest.AddFirst(value);
            int[] actual = toTest.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(20)]
        [TestCase(2)]
        [TestCase(0)]
        [TestCase(1)]
        public void AddFirstListTest(int ID)
        {
            //arrange
            LinkList toTest = TestDataLinkList.GetListForAddFirstTest(ID);
            LinkList add = TestDataLinkList.GetAddListForAddFirstTest(ID);
            LinkList expected = TestDataLinkList.GetExpectedListForAddFirstTest(ID);
            //act
            toTest.AddFirst(add);
            int[] actual = toTest.ToArray();

            //assert
            Assert.AreEqual(expected.ToArray(), actual);
        }

        [TestCase(0, 0, 2)]
        [TestCase(1, 0, 12)]
        [TestCase(2, 2, 5)]
        [TestCase(3, 3, 0)]
        [TestCase(4, 0, 0)]
        public void AddAtTest(int ID, int idx, int value)
        {
            //arrange
            LinkList toTest = TestDataLinkList.GetListForAddAtTest(ID);
            int[] expected = TestDataLinkList.GetExpectedArrayForAddAtTest(ID);
            //act
            toTest.AddAt(idx, value);
            int[] actual = toTest.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0)]
        [TestCase(1, 0)]
        [TestCase(2, 0)]
        [TestCase(3, 2)]
        [TestCase(4, 0)]
        public void AddAtListTest(int ID, int idx)
        {
            //arrange
            LinkList toTest = TestDataLinkList.GetListForAddAtTest(ID);
            LinkList add = TestDataLinkList.GetAddListForAddAtTest(ID);
            LinkList expected = TestDataLinkList.GetExpectedListForAddAtTest(ID);
            //act
            toTest.AddAt(idx, add);
            int[] actual = toTest.ToArray();

            //assert
            Assert.AreEqual(expected.ToArray(), actual);
        }

        [TestCase(0, 2, 0)]
        [TestCase(1, 0, 4)]
        [TestCase(2, 2, 0)]
        public void SetTest(int ID, int idx, int val)
        {
            //arrange
            LinkList toTest = TestDataLinkList.GetListForSetTest(ID);
            LinkList expected = TestDataLinkList.GetExpectedListForSetTest(ID);
            //act
            toTest.Set(idx, val);
            int[] actual = toTest.ToArray();

            //assert
            Assert.AreEqual(expected.ToArray(), actual);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(22)]
        public void RemoveFirstTest(int ID)
        {
            //arrange
            LinkList toTest = TestDataLinkList.GetListForRemoveFirstLastAtTest(ID);
            LinkList expected = TestDataLinkList.GetExpectedListForRemoveFirstTest(ID);
            //act
            toTest.RemoveFirst();
            int[] actual = toTest.ToArray();

            //assert
            Assert.AreEqual(expected.ToArray(), actual);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(22)]
        public void RemoveLastTest(int ID)
        {
            //arrange
            LinkList toTest = TestDataLinkList.GetListForRemoveFirstLastAtTest(ID);
            LinkList expected = TestDataLinkList.GetExpectedListForRemoveLastTest(ID);
            //act
            toTest.RemoveLast();
            int[] actual = toTest.ToArray();

            //assert
            Assert.AreEqual(expected.ToArray(), actual);
        }

        [TestCase(0, 2)]
        [TestCase(1, 0)]
        [TestCase(2, 0)]
        [TestCase(3, 3)]
        [TestCase(22, 0)]
        public void RemoveAtTest(int ID, int idx)
        {
            //arrange
            LinkList toTest = TestDataLinkList.GetListForRemoveFirstLastAtTest(ID);
            LinkList expected = TestDataLinkList.GetExpectedListForRemoveAtTest(ID);
            //act
            toTest.RemoveAt(idx);
            int[] actual = toTest.ToArray();

            //assert
            Assert.AreEqual(expected.ToArray(), actual);
        }
    }
}