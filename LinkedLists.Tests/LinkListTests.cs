using NUnit.Framework;
using System;

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

        [TestCase(100, 0, 2, "Index out of range list length")]
        [TestCase(1, 10, 2, "Index out of range list length")]
        public void AddAtNegativeTest(int ID, int idx, int value,
            string expectedMessage)
        {
            //arrange
            LinkList toTest = TestDataLinkList.GetListForAddAtTest(ID);
            
            //act
            Exception ex = Assert.Throws(typeof(IndexOutOfRangeException), 
                () =>toTest.AddAt(idx, value));
            
            //assert
            Assert.AreEqual(expectedMessage, ex.Message);
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

        [TestCase(100, 0, "Index out of range list length")]
        [TestCase(1, 10, "Index out of range list length")]
        public void AddAtListNegativeTest(int ID, int idx,
            string expectedMessage)
        {
            //arrange
            LinkList toTest = TestDataLinkList.GetListForAddAtTest(ID);
            LinkList add = TestDataLinkList.GetAddListForAddAtTest(ID);
            //act
            Exception ex = Assert.Throws(typeof(IndexOutOfRangeException),
                () => toTest.AddAt(idx, add));

            //assert
            Assert.AreEqual(expectedMessage, ex.Message);
        }

        [TestCase(0, 2, 0)]
        [TestCase(1, 0, 4)]
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

        [TestCase(1, 10, 2, "Index out of range list length")]
        [TestCase(22, 0, 2, "Index out of range list length")]
        public void SetNegativeTest(int ID, int idx, int value,
            string expectedMessage)
        {
            //arrange
            LinkList toTest = TestDataLinkList.GetListForSetTest(ID);
            
            //act
            Exception ex = Assert.Throws(typeof(IndexOutOfRangeException),
                () => toTest.Set(idx,value));

            //assert
            Assert.AreEqual(expectedMessage, ex.Message);
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

        [TestCase(1, 10, "Index out of range list length")]
        [TestCase(22, 0, "Index out of range list length")]
        public void RemoveAtNegativeTest(int ID, int idx,
            string expectedMessage)
        {
            //arrange
            LinkList toTest = TestDataLinkList.GetListForRemoveFirstLastAtTest(ID);

            //act
            Exception ex = Assert.Throws(typeof(IndexOutOfRangeException),
                () => toTest.RemoveAt(idx));

            //assert
            Assert.AreEqual(expectedMessage, ex.Message);
        }

        [TestCase(0, 3)]
        [TestCase(1, 4)]
        [TestCase(2, 4)]
        [TestCase(23, 1)]
        public void RemoveFirstMultipleTest(int ID, int n)
        {
            //arrange
            LinkList toTest = TestDataLinkList.GetListForRemoveFirstLastAtMultipleTest(ID);
            LinkList expected = TestDataLinkList.GetExpectedListForRemoveFirstMultipleTest(ID);
            //act
            toTest.RemoveFirstMultiple(n);
            int[] actual = toTest.ToArray();

            //assert
            Assert.AreEqual(expected.ToArray(), actual);
        }

        [TestCase(0, 3)]
        [TestCase(1, 4)]
        [TestCase(2, 4)]
        [TestCase(23, 1)]
        public void RemoveLastMultipleTest(int ID, int n)
        {
            //arrange
            LinkList toTest = TestDataLinkList.GetListForRemoveFirstLastAtMultipleTest(ID);
            LinkList expected = TestDataLinkList.GetExpectedListForRemoveLastMultipleTest(ID);
            //act
            toTest.RemoveLastMultiple(n);
            int[] actual = toTest.ToArray();

            //assert
            Assert.AreEqual(expected.ToArray(), actual);
        }


        [TestCase(0, 2, 3)]
        [TestCase(1, 0, 4)]
        [TestCase(2, 2, 5)]
        public void RemoveAtMultipleTest(int ID, int idx, int n)
        {
            //arrange
            LinkList toTest = TestDataLinkList.GetListForRemoveFirstLastAtMultipleTest(ID);
            LinkList expected = TestDataLinkList.GetExpectedListForRemoveAtMultipleTest(ID);
            //act
            toTest.RemoveAtMultiple(idx, n);
            int[] actual = toTest.ToArray();

            //assert
            Assert.AreEqual(expected.ToArray(), actual);
        }

        [TestCase(1, 10, 2, "Index out of range list length")]
        [TestCase(22, 0, 2, "Index out of range list length")]
        public void RemoveAtMultipleNegativeTest(int ID, int idx, int n,
            string expectedMessage)
        {
            //arrange
            LinkList toTest = TestDataLinkList.GetListForRemoveFirstLastAtMultipleTest(ID);

            //act
            Exception ex = Assert.Throws(typeof(IndexOutOfRangeException),
                () => toTest.RemoveAtMultiple(idx, n));

            //assert
            Assert.AreEqual(expectedMessage, ex.Message);
        }

        [TestCase(0, 8, 2)]
        [TestCase(1, 8, 0)]
        [TestCase(2, 8, 0)]
        [TestCase(3, 8, -1)]
        [TestCase(11, 8, -1)]
        public void RemoveFirstValTest(int ID, int val, int expectedIndex)
        {
            //arrange
            LinkList toTest = TestDataLinkList.GetListForGetFiestGetLastGetTest(ID);
            LinkList expected = TestDataLinkList.GetExpectedListForRemoveFirstValTest(ID);
            //act
            int actualIndex = toTest.RemoveFirst(val);
            int[] actual = toTest.ToArray();

            //assert
            Assert.AreEqual(expected.ToArray(), actual);
            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [TestCase(2, 8, 3)]
        [TestCase(3, 8, 0)]
        [TestCase(0, 8, 4)]
        [TestCase(1, 8, 3)]
        [TestCase(11, 8, 0)]
        public void RemoveAllTest(int ID, int val, int expectedRemoveNumbers)
        {
            //arrange
            LinkList toTest = TestDataLinkList.GetListForGetFiestGetLastGetTest(ID);
            LinkList expected = TestDataLinkList.GetExpectedListForRemoveAllTest(ID);
            //act
            int actualRemoveNumbers = toTest.RemoveAll(val);
            int[] actual = toTest.ToArray();

            //assert
            Assert.AreEqual(expected.ToArray(), actual);
            Assert.AreEqual(expectedRemoveNumbers, actualRemoveNumbers);
        }

        [TestCase(2, 8, true)]
        [TestCase(3, 8, false)]
        [TestCase(0, 8, true)]
        [TestCase(1, 8, true)]
        [TestCase(11, 8, false)]
        public void ContainsTest(int ID, int val, bool expected)
        {
            //arrange
            LinkList toTest = TestDataLinkList.GetListForGetFiestGetLastGetTest(ID);
            
            //act
            bool actual = toTest.Contains(val);


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 8, 0)]
        [TestCase(3, 8, -1)]
        [TestCase(0, 8, 2)]
        [TestCase(1, 8, 0)]
        [TestCase(11, 8, -1)]
        public void IndexOfTest(int ID, int val, int expected)
        {
            //arrange
            LinkList toTest = TestDataLinkList.GetListForGetFiestGetLastGetTest(ID);

            //act
            int actual = toTest.IndexOf(val);


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 4)]
        [TestCase(3, 5)]
        [TestCase(0, 12)]
        [TestCase(1, 2)]
        public void GetFirstTest(int ID, int expected)
        {
            //arrange
            LinkList toTest = TestDataLinkList.GetListForGetFirstGetLastGetTest(ID);

            //act
            int actual = toTest.GetFirst();


            //assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestCase(22, "List is empty")]
        public void GetFirstNegativeTest(int ID, string expectedMessage)
        {
            //arrange
            LinkList toTest = TestDataLinkList.GetListForGetFirstGetLastGetTest(ID);

            //act
            Exception ex = Assert.Throws(typeof(IndexOutOfRangeException),
                () => toTest.GetFirst());

            //assert
            Assert.AreEqual(expectedMessage, ex.Message);
        }
        [TestCase(2, 4)]
        [TestCase(3, 5)]
        [TestCase(0, 10)]
        [TestCase(1, 4)]
        public void GetLastTest(int ID, int expected)
        {
            //arrange
            LinkList toTest = TestDataLinkList.GetListForGetFirstGetLastGetTest(ID);

            //act
            int actual = toTest.GetLast();


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(22, "List is empty")]
        public void GetLastNegativeTest(int ID, string expectedMessage)
        {
            //arrange
            LinkList toTest = TestDataLinkList.GetListForGetFirstGetLastGetTest(ID);

            //act
            Exception ex = Assert.Throws(typeof(IndexOutOfRangeException),
                () => toTest.GetLast());

            //assert
            Assert.AreEqual(expectedMessage, ex.Message);
        }

        [TestCase(2, 0, 4)]
        [TestCase(3, 2, 5)]
        [TestCase(0, 2, -9)]
        [TestCase(1, 2, 4)]
        public void GetTest(int ID, int idx,  int expected)
        {
            //arrange
            LinkList toTest = TestDataLinkList.GetListForGetFirstGetLastGetTest(ID);
            //act
            int actual = toTest.Get(idx);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(22, 1, "List is empty")]
        [TestCase(1, 4, "Entry index out of range length list")]
        public void GetNegativeTest(int ID, int idx, string expectedMessage)
        {
            //arrange
            LinkList toTest = TestDataLinkList.GetListForGetFirstGetLastGetTest(ID);

            //act
            Exception ex = Assert.Throws(typeof(IndexOutOfRangeException),
                () => toTest.Get(idx));

            //assert
            Assert.AreEqual(expectedMessage, ex.Message);
        }

        [TestCase(2)]
        [TestCase(3)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(11)]
        public void ReverseTest(int ID)
        {
            //arrange
            LinkList toTest = TestDataLinkList.GetListForReverseTest(ID);
            LinkList expected = TestDataLinkList.GetExpectedListForReverseTest(ID);
            //act
            toTest.Reverse();
            //assert
            Assert.AreEqual(expected.ToArray(), toTest.ToArray());
        }

        [TestCase(2, 4, 0)]
        [TestCase(3, 5, 0)]
        [TestCase(0, 12, 4)]
        [TestCase(1, 4, 2)]
        public void MaxAndIndexMaxTest(int ID, int expected, int expectedIndex)
        {
            //arrange
            LinkList toTest = TestDataLinkList.GetListForMaxMinAndThisIndexesTest(ID);
            //act
            int actual = toTest.Max();
            int actualIndex = toTest.IndexOfMax();
            //assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [TestCase(22, "List is empty")]
        public void MaxAndIndexMaxNegativeTest(int ID, string expectedMessage)
        {
            //arrange
            LinkList toTest = TestDataLinkList.GetListForMaxMinAndThisIndexesTest(ID);

            //act
            Exception exMax = Assert.Throws(typeof(IndexOutOfRangeException),
                () => toTest.Max());
            Exception exIndexMax = Assert.Throws(typeof(IndexOutOfRangeException),
                () => toTest.IndexOfMax());

            //assert
            Assert.AreEqual(expectedMessage, exMax.Message, exIndexMax.Message);
        }

        [TestCase(2, 4, 0)]
        [TestCase(3, 5, 0)]
        [TestCase(0, -9, 2)]
        [TestCase(1, 1, 3)]
        public void MinAndIndexMinTest(int ID, int expected, int expectedIndex)
        {
            //arrange
            LinkList toTest = TestDataLinkList.GetListForMaxMinAndThisIndexesTest(ID);
            //act
            int actual = toTest.Min();
            int actualIndex = toTest.IndexOfMin();
            //assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [TestCase(22, "List is empty")]
        public void MinAndIndexMinNegativeTest(int ID, string expectedMessage)
        {
            //arrange
            LinkList toTest = TestDataLinkList.GetListForMaxMinAndThisIndexesTest(ID);

            //act
            Exception exMin = Assert.Throws(typeof(IndexOutOfRangeException),
                () => toTest.Min());
            Exception exIndexMin = Assert.Throws(typeof(IndexOutOfRangeException),
                () => toTest.IndexOfMin());

            //assert
            Assert.AreEqual(expectedMessage, exMin.Message, exIndexMin.Message);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(55)]
        public void SortTest(int ID)
        {
            //arrange
            LinkList toTest = TestDataLinkList.GetListForSortAndSortDescTest(ID);
            LinkList expected = TestDataLinkList.GetExpectedListForSortTest(ID);
            //act
            toTest.Sort();
            //assert
            Assert.AreEqual(expected.ToArray(), toTest.ToArray());
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(55)]
        public void SortDescTest(int ID)
        {
            //arrange
            LinkList toTest = TestDataLinkList.GetListForSortAndSortDescTest(ID);
            LinkList expected = TestDataLinkList.GetExpectedListForSortDescTest(ID);
            //act
            toTest.SortDesc();
            //assert
            Assert.AreEqual(expected.ToArray(), toTest.ToArray());
        }
    }
}