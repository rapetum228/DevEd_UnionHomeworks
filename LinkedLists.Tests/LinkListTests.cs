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
            LinkList toTest = TestDataLinkList.GetListForToArrayTest(ID);
            int[] expected = TestDataLinkList.GetExpectedArrayForToArrayTest(ID);
            //act
            int[] actual = toTest.ToArray();
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


    }
}