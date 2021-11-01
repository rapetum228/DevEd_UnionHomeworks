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
        [TestCase(3)]
        [TestCase(20)]
        public void ToArrayTest(int ID)
        {
            //arrange
            int[] toTest = TestDataLinkList.GetArrayForToArrayAndGetLengthTest(ID);
            LinkList toTestList = new LinkList(toTest);
            int[] expected = TestDataLinkList.GetExpectedArrayForToArrayTest(ID);
            //act
            int[] actual = toTestList.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 1)]
        [TestCase(1, 1)]
        [TestCase(2, 4)]
        [TestCase(3, 5)]
        [TestCase(20, 0)]
        public void GetLengthTest(int ID, int expected)
        {
            //arrange
            int[] toTest = TestDataLinkList.GetArrayForToArrayAndGetLengthTest(ID);
            LinkList toTestList = new LinkList(toTest);
            //act
            int actual = toTestList.GetLength();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 2)]
        [TestCase(1, 12)]
        [TestCase(2, 5)]
        [TestCase(20, 0)]
        public void AddLastTest(int ID, int value)
        {
            //arrange
            int[] toTest = TestDataLinkList.GetListForAddLastTest(ID);
            LinkList toTestList = new LinkList(toTest);
            int[] expected = TestDataLinkList.GetExpectedArrayForAddLastTest(ID);
            //act
            toTestList.AddLast(value);
            int[] actual = toTestList.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }

        
        
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(20)]
        public void AddLastListTest(int ID)
        {
            //arrange
            int[] toTest = TestDataLinkList.GetListForAddLastTest(ID);
            LinkList toTestList = new LinkList(toTest);
            int[] addArray = TestDataLinkList.GetAddListForAddLastTest(ID);
            LinkList add = new LinkList(addArray);
            int[] expected = TestDataLinkList.GetExpectedListForAddLastTest(ID);
            //act
            toTestList.AddLast(add);
            int[] actual = toTestList.ToArray();
            
            //assert
            Assert.AreEqual(expected, actual);
        }

        
        
        [TestCase(0, 2)]
        [TestCase(1, 12)]
        [TestCase(2, 5)]
        [TestCase(20, 0)]
        public void AddFirstTest(int ID, int value)
        {
            //arrange
            int[] toTestArray = TestDataLinkList.GetListForAddFirstTest(ID);
            LinkList toTest = new LinkList(toTestArray);
            int[] expected = TestDataLinkList.GetExpectedArrayForAddFirstTest(ID);
            //act
            toTest.AddFirst(value);
            int[] actual = toTest.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }

        
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(20)]
        [TestCase(2)]
        public void AddFirstListTest(int ID)
        {
            //arrange
            int[] toTestArray = TestDataLinkList.GetListForAddFirstTest(ID);
            LinkList toTest = new LinkList(toTestArray);
            int[] addArray = TestDataLinkList.GetAddListForAddFirstTest(ID);
            LinkList add = new LinkList(addArray);
            int[] expected = TestDataLinkList.GetExpectedListForAddFirstTest(ID);

            //act
            toTest.AddFirst(add);
            int[] actual = toTest.ToArray();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0, 2)]
        [TestCase(1, 0, 12)]
        [TestCase(2, 2, 5)]
        [TestCase(3, 3, 0)]
        [TestCase(4, 0, 0)]
        public void AddAtTest(int ID, int idx, int value)
        {
            //arrange
            int[] toTestArray = TestDataLinkList.GetListForAddAtTest(ID);
            LinkList toTest = new LinkList(toTestArray);
            int[] expected = TestDataLinkList.GetExpectedArrayForAddAtTest(ID);
            //act
            toTest.AddAt(idx, value);
            int[] actual = toTest.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(100, 1, 2, "Index out of range list length")]
        [TestCase(1, 10, 2, "Index out of range list length")]
        public void AddAtNegativeTest(int ID, int idx, int value,
            string expectedMessage)
        {
            //arrange
            int[] toTestArray = TestDataLinkList.GetListForAddAtTest(ID);
            LinkList toTest = new LinkList(toTestArray);

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
            int[] toTestArray = TestDataLinkList.GetListForAddAtTest(ID);
            LinkList toTest = new LinkList(toTestArray);
            int[] addArray = TestDataLinkList.GetAddListForAddAtTest(ID);
            LinkList add = new LinkList(addArray);
            int[] expected = TestDataLinkList.GetExpectedListForAddAtTest(ID);
            //act
            toTest.AddAt(idx, add);
            int[] actual = toTest.ToArray();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(100, 0, "Index out of range list length")]
        [TestCase(1, 10, "Index out of range list length")]
        public void AddAtListNegativeTest(int ID, int idx,
            string expectedMessage)
        {
            //arrange
            int[] toTestArray = TestDataLinkList.GetListForAddAtTest(ID);
            LinkList toTest = new LinkList(toTestArray);
            int[] addArray = TestDataLinkList.GetAddListForAddAtTest(ID);
            LinkList add = new LinkList(addArray);
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
            int[] toTestArray = TestDataLinkList.GetListForSetTest(ID);
            LinkList toTest = new(toTestArray);
            int[] expected = TestDataLinkList.GetExpectedListForSetTest(ID);
            //act
            toTest.Set(idx, val);
            int[] actual = toTest.ToArray();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 10, 2, "Index out of range list length")]
        [TestCase(22, 0, 2, "Index out of range list length")]
        public void SetNegativeTest(int ID, int idx, int value,
            string expectedMessage)
        {
            //arrange
            int[] toTestArray = TestDataLinkList.GetListForSetTest(ID);
            LinkList toTest = new(toTestArray);

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
            int[] toTestArray = TestDataLinkList.GetListForRemoveFirstLastAtTest(ID);
            LinkList toTest = new(toTestArray);
            int[] expected = TestDataLinkList.GetExpectedListForRemoveFirstTest(ID);
            //act
            toTest.RemoveFirst();
            int[] actual = toTest.ToArray();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(22)]
        public void RemoveLastTest(int ID)
        {
            //arrange
            int[] toTestArray = TestDataLinkList.GetListForRemoveFirstLastAtTest(ID);
            LinkList toTest = new(toTestArray);
            int[] expected = TestDataLinkList.GetExpectedListForRemoveLastTest(ID);
            //act
            toTest.RemoveLast();
            int[] actual = toTest.ToArray();

            //assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestCase(0, 2)]
        [TestCase(1, 0)]
        [TestCase(2, 0)]
        [TestCase(3, 3)]
        public void RemoveAtTest(int ID, int idx)
        {
            //arrange
            int[] toTestArray = TestDataLinkList.GetListForRemoveFirstLastAtTest(ID);
            LinkList toTest = new(toTestArray);
            int[] expected = TestDataLinkList.GetExpectedListForRemoveAtTest(ID);
            //act
            toTest.RemoveAt(idx);
            int[] actual = toTest.ToArray();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 10, "Index out of range list length")]
        [TestCase(22, 0, "Index out of range list length")]
        public void RemoveAtNegativeTest(int ID, int idx,
            string expectedMessage)
        {
            //arrange
            int[] toTestArray = TestDataLinkList.GetListForRemoveFirstLastAtTest(ID);
            LinkList toTest = new(toTestArray);

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
            int[] toTestArray = TestDataLinkList.GetListForRemoveFirstLastAtMultipleTest(ID);
            LinkList toTest = new LinkList(toTestArray);
            int[] expected = TestDataLinkList.GetExpectedListForRemoveFirstMultipleTest(ID);
            //act
            toTest.RemoveFirstMultiple(n);
            int[] actual = toTest.ToArray();

            //assert
            Assert.AreEqual(expected, actual);
        }

        
        [TestCase(0, 3)]
        [TestCase(1, 4)]
        [TestCase(2, 2)]
        [TestCase(23, 1)]
        public void RemoveLastMultipleTest(int ID, int n)
        {
            //arrange
            int[] toTestArray = TestDataLinkList.GetListForRemoveFirstLastAtMultipleTest(ID);
            LinkList toTest = new LinkList(toTestArray);
            int[] expected = TestDataLinkList.GetExpectedListForRemoveLastMultipleTest(ID);
            //act
            toTest.RemoveLastMultiple(n);
            int[] actual = toTest.ToArray();

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        
        [TestCase(0, 2, 3)]
        [TestCase(1, 0, 4)]
        [TestCase(2, 2, 5)]
        public void RemoveAtMultipleTest(int ID, int idx, int n)
        {
            //arrange
            int[] toTestArray = TestDataLinkList.GetListForRemoveFirstLastAtMultipleTest(ID);
            LinkList toTest = new LinkList(toTestArray);
            int[] expected = TestDataLinkList.GetExpectedListForRemoveAtMultipleTest(ID);
            //act
            toTest.RemoveAtMultiple(idx, n);
            int[] actual = toTest.ToArray();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 10, 2, "Index out of range list length")]
        [TestCase(22, 0, 2, "Index out of range list length")]
        public void RemoveAtMultipleNegativeTest(int ID, int idx, int n,
            string expectedMessage)
        {
            //arrange
            int[] toTestArray = TestDataLinkList.GetListForRemoveFirstLastAtMultipleTest(ID);
            LinkList toTest = new LinkList(toTestArray);

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
            int[] arrayToTest = TestDataLinkList.GetListForRemoveFirstValAndAllTest(ID);
            LinkList toTest = new LinkList(arrayToTest);
            int[] expected = TestDataLinkList.GetExpectedListForRemoveFirstValTest(ID);
            //act
            int actualIndex = toTest.RemoveFirst(val);
            int[] actual = toTest.ToArray();

            //assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedIndex, actualIndex);
        }

        
        [TestCase(0, 8, 4)]
        [TestCase(1, 8, 3)]
        [TestCase(2, 8, 3)]
        [TestCase(3, 8, 0)]
        [TestCase(11, 8, 0)]
        public void RemoveAllTest(int ID, int val, int expectedRemoveNumbers)
        {
            //arrange
            int[] arrayToTest = TestDataLinkList.GetListForRemoveFirstValAndAllTest(ID);
            LinkList toTest = new LinkList(arrayToTest);
            int[] expected = TestDataLinkList.GetExpectedListForRemoveAllTest(ID);
            //act
            int actualRemoveNumbers = toTest.RemoveAll(val);
            int[] actual = toTest.ToArray();

            //assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedRemoveNumbers, actualRemoveNumbers);
        }

        
        [TestCase(0, 8, true)]
        [TestCase(1, 8, true)]
        [TestCase(2, 8, true)]
        [TestCase(3, 8, false)]
        [TestCase(11, 8, false)]
        public void ContainsTest(int ID, int val, bool expected)
        {
            //arrange
            int[] arrToTest = TestDataLinkList.GetListForGetFirstGetLastGetTest(ID);
            LinkList toTest = new LinkList(arrToTest);
            //act
            bool actual = toTest.Contains(val);


            //assert
            Assert.AreEqual(expected, actual);
        }

        
        [TestCase(0, 8, 4)]
        [TestCase(1, 8, 0)]
        [TestCase(2, 8, 0)]
        [TestCase(3, 8, -1)]
        [TestCase(11, 8, -1)]
        public void IndexOfTest(int ID, int val, int expected)
        {
            //arrange
            int[] arrToTest = TestDataLinkList.GetListForGetFirstGetLastGetTest(ID);
            LinkList toTest = new LinkList(arrToTest);

            //act
            int actual = toTest.IndexOf(val);


            //assert
            Assert.AreEqual(expected, actual);
        }

        
        [TestCase(0, 12)]
        [TestCase(1, 8)]
        [TestCase(2, 8)]
        [TestCase(3, 5)]
        [TestCase(4, 228)]
        public void GetFirstTest(int ID, int expected)
        {
            //arrange
            int[] arrToTest = TestDataLinkList.GetListForGetFirstGetLastGetTest(ID);
            LinkList toTest = new LinkList(arrToTest);

            //act
            int actual = toTest.GetFirst();


            //assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestCase(22, "List is empty")]
        public void GetFirstNegativeTest(int ID, string expectedMessage)
        {
            //arrange
            int[] arrToTest = TestDataLinkList.GetListForGetFirstGetLastGetTest(ID);
            LinkList toTest = new LinkList(arrToTest);

            //act
            Exception ex = Assert.Throws(typeof(IndexOutOfRangeException),
                () => toTest.GetFirst());

            //assert
            Assert.AreEqual(expectedMessage, ex.Message);
        }
        
        [TestCase(0, 8)]
        [TestCase(1, 4)]
        [TestCase(2, 8)]
        [TestCase(3, 0)]
        [TestCase(4, 228)]
        public void GetLastTest(int ID, int expected)
        {
            //arrange
            int[] arrToTest = TestDataLinkList.GetListForGetFirstGetLastGetTest(ID);
            LinkList toTest = new LinkList(arrToTest);

            //act
            int actual = toTest.GetLast();


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(22, "List is empty")]
        public void GetLastNegativeTest(int ID, string expectedMessage)
        {
            //arrange
            int[] arrToTest = TestDataLinkList.GetListForGetFirstGetLastGetTest(ID);
            LinkList toTest = new LinkList(arrToTest);

            //act
            Exception ex = Assert.Throws(typeof(IndexOutOfRangeException),
                () => toTest.GetLast());

            //assert
            Assert.AreEqual(expectedMessage, ex.Message);
        }

        
        [TestCase(0, 2, -9)]
        [TestCase(1, 2, 3)]
        [TestCase(2, 0, 8)]
        [TestCase(3, 2, 1)]
        [TestCase(4, 0, 228)]
        public void GetTest(int ID, int idx,  int expected)
        {
            //arrange
            int[] arrToTest = TestDataLinkList.GetListForGetFirstGetLastGetTest(ID);
            LinkList toTest = new LinkList(arrToTest);
            //act
            int actual = toTest.Get(idx);
            //assert
            Assert.AreEqual(expected, actual);
        }

        
        [TestCase(1, 14, "Entry index out of range length list")]
        [TestCase(22, 1, "List is empty")]
        public void GetNegativeTest(int ID, int idx, string expectedMessage)
        {
            //arrange
            int[] arrToTest = TestDataLinkList.GetListForGetFirstGetLastGetTest(ID);
            LinkList toTest = new LinkList(arrToTest);

            //act
            Exception ex = Assert.Throws(typeof(IndexOutOfRangeException),
                () => toTest.Get(idx));

            //assert
            Assert.AreEqual(expectedMessage, ex.Message);
        }

        
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(11)]
        public void ReverseTest(int ID)
        {
            //arrange
            int[] arrToTest = TestDataLinkList.GetListForReverseTest(ID);
            LinkList toTest = new LinkList(arrToTest);
            int[] expected = TestDataLinkList.GetExpectedListForReverseTest(ID);
            //act
            toTest.Reverse();
            //assert
            Assert.AreEqual(expected, toTest.ToArray());
        }

        
        [TestCase(0, 12, 4)]
        [TestCase(1, 4, 2)]
        [TestCase(2, 4, 0)]
        [TestCase(3, 5, 0)]
        public void MaxAndIndexMaxTest(int ID, int expected, int expectedIndex)
        {
            //arrange
            int[] arrToTest = TestDataLinkList.GetListForMaxMinAndThisIndexesTest(ID);
            LinkList toTest = new LinkList(arrToTest);
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
            int[] arrToTest = TestDataLinkList.GetListForMaxMinAndThisIndexesTest(ID);
            LinkList toTest = new LinkList(arrToTest);

            //act
            Exception exMax = Assert.Throws(typeof(IndexOutOfRangeException),
                () => toTest.Max());
            Exception exIndexMax = Assert.Throws(typeof(IndexOutOfRangeException),
                () => toTest.IndexOfMax());

            //assert
            Assert.AreEqual(expectedMessage, exMax.Message, exIndexMax.Message);
        }

        
        [TestCase(0, -9, 2)]
        [TestCase(1, 1, 3)]
        [TestCase(2, 4, 0)]
        [TestCase(3, 5, 0)]
        public void MinAndIndexMinTest(int ID, int expected, int expectedIndex)
        {
            //arrange
            int[] arrToTest = TestDataLinkList.GetListForMaxMinAndThisIndexesTest(ID);
            LinkList toTest = new LinkList(arrToTest);
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
            int[] arrToTest = TestDataLinkList.GetListForMaxMinAndThisIndexesTest(ID);
            LinkList toTest = new LinkList(arrToTest);

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
            int[] arrToTest = TestDataLinkList.GetListForSortAndSortDescTest(ID);
            LinkList toTest = new LinkList(arrToTest);
            int[] expected = TestDataLinkList.GetExpectedListForSortTest(ID);
            //act
            toTest.Sort();
            //assert
            Assert.AreEqual(expected, toTest.ToArray());
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
            int[] arrToTest = TestDataLinkList.GetListForSortAndSortDescTest(ID);
            LinkList toTest = new LinkList(arrToTest);
            int[] expected = TestDataLinkList.GetExpectedListForSortDescTest(ID);
            //act
            toTest.SortDesc();
            //assert
            Assert.AreEqual(expected, toTest.ToArray());
        }
    }
}