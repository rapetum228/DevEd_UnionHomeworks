using Lists;
using NUnit.Framework;
using System;

namespace ArrayList.Tests
{
    public class ArrayListTests
    {
        
        [SetUp]
        public void Setup()
        {
            
        }

        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 4)]
        public void GetLengthTest(int arrayID, int expected)
        {
            //arrange
            ArrList arrToTest = TestDataArrList.GetArrListForGetLengthTest(arrayID);
            //act
            int actual = arrToTest.GetLength();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, new int[] { })]
        [TestCase(1, new int[] { 4 })]
        [TestCase(2, new int[] { 1, 2, 3, 4 })]
        public void ToArrayTest(int arrayID, int[] expected)
        {
            //arrange
            int[] arrToTest = TestDataArrList.GetArrListForToArrayTest(arrayID);
            //act

            //assert
            Assert.AreEqual(expected, arrToTest);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        public void AddFirstTest(int arrayID)
        {
            //arrange
            ArrList arrToTest = TestDataArrList.GetArrListForAddFirstTest(arrayID);
            int[] expected = TestDataArrList.GetExpectedArrListForAddFirstTest(arrayID);
            //act
            arrToTest.AddFirst(3);
            int[] actual = arrToTest.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
     
        }

        [TestCase(0, new int[] {1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 }, 5)]
        [TestCase(1, new int[] {1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5, 4 }, 6)]
        [TestCase(2, new int[] {1, 2, 3, 4, 5, 6, 7, 8}, 
            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 1, 2, 3, 4 }, 12)]
        public void AddFirstArrTest(int arrayID, int[] addFirstArr, int[] expected, int expectedLength)
        {
            //arrange
            ArrList arrToTest = TestDataArrList.GetArrListForAddFirstTest(arrayID);
            //act
            arrToTest.AddFirst(addFirstArr);
            int[] actual = arrToTest.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedLength, arrToTest.GetLength());
        }

        [TestCase(0, 4)]
        [TestCase(1, 11)]
        [TestCase(2, 5)]
        [TestCase(12, 0)]
        public void AddLastArrTest(int arrayID, int expectedLength)
        {
            //arrange
            ArrList arrToTest = TestDataArrList.GetArrListForAddLastTest(arrayID);
            int[] expected = TestDataArrList.GetExpectedArrListForAddLastArrTest(arrayID);
            //act
            arrToTest.AddLast(TestDataArrList.GetAddArrListForAddLastTest(arrayID));
            int[] actual = arrToTest.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedLength, arrToTest.GetLength());
        }

        [TestCase(0, 4, 1)]
        [TestCase(1, 11, 2)]
        [TestCase(2, 5, 5)]
        public void AddLastTest(int arrayID, int addLastElement, int expectedLength)
        {
            //arrange
            ArrList arrToTest = TestDataArrList.GetArrListForAddLastTest(arrayID);
            int[] expected = TestDataArrList.GetExpectedArrListForAddLastTest(arrayID);
            //act
            arrToTest.AddLast(addLastElement);
            int[] actual = arrToTest.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedLength, arrToTest.GetLength());
        }

        [TestCase(0, 1, 7)]
        [TestCase(1, 0, 11)]
        [TestCase(2, 3, 5)]
        public void AddAtArrTest(int arrayID, int idx, int expectedLength)
        {
            //arrange
            ArrList arrToTest = TestDataArrList.GetArrListForAddAtTest(arrayID);
            int[] addArr = TestDataArrList.GetAddArrListForAddAtTest(arrayID);
            int[] expected = TestDataArrList.GetExpectedArrListForAddAtArrTest(arrayID);
            //act
            arrToTest.AddAt(idx, addArr);
            int[] actual = arrToTest.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedLength, arrToTest.GetLength());
        }

        [TestCase(0, 6, "Entry index out of range array list")]
        [TestCase(1, -1, "Entry index out of range array list")]
        [TestCase(12, 0, "Entry index out of range array list")]
        public void AddAtArrNegativeTest(int arrayID, int idx, string expectedMessage)
        {
            //arrange
            ArrList arrToTest = TestDataArrList.GetArrListForAddAtTest(arrayID);
            int[] addArr = TestDataArrList.GetAddArrListForAddAtTest(arrayID);
            //act
            Exception ex = Assert.Throws(typeof(IndexOutOfRangeException),
                () => arrToTest.AddAt(idx, addArr));
            //assert
            Assert.AreEqual(expectedMessage, ex.Message);
        }

        [TestCase(0, 1, 7, 4)]
        [TestCase(1, 0, 11, 2)]
        [TestCase(2, 2, 5, 5)]
        public void AddAtTest(int arrayID, int idx, int val, int expectedLength)
        {
            //arrange
            ArrList arrToTest = TestDataArrList.GetArrListForAddAtTest(arrayID);
            int[] expected = TestDataArrList.GetExpectedArrListForAddAtTest(arrayID);

            //act
            arrToTest.AddAt(idx, val);
            int[] actual = arrToTest.ToArray();

            //assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedLength, arrToTest.GetLength());
        }

        [TestCase(0, 6, 4, "Entry index out of range array list")]
        [TestCase(1, -1, 4, "Entry index out of range array list")]
        [TestCase(12, 0, 4, "Entry index out of range array list")]
        public void AddAtNegativeTest(int arrayID, int idx, int val, string expectedMessage)
        {
            //arrange
            ArrList arrToTest = TestDataArrList.GetArrListForAddAtTest(arrayID);
            //act
            Exception ex = Assert.Throws(typeof(IndexOutOfRangeException),
                () => arrToTest.AddAt(idx, val));
            //assert
            Assert.AreEqual(expectedMessage, ex.Message);
        }

        [TestCase(0, 1, 7, 3)]
        [TestCase(1, 0, 11, 1)]
        [TestCase(2, 2, 5, 4)]
        [TestCase(3, 0, 11, 2)]
        public void SetTest(int arrayID, int idx, int val, int expectedLength)
        {
            //arrange
            ArrList arrToTest = TestDataArrList.GetArrListForSetTest(arrayID);
            int[] expected = TestDataArrList.GetExpectedArrListForSetTest(arrayID);

            //act
            arrToTest.Set(idx, val);
            int[] actual = arrToTest.ToArray();

            //assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedLength, arrToTest.GetLength());
        }

        [TestCase(0, 3, 4, "Entry index out of range array list")]
        [TestCase(1, -1, 4, "Entry index out of range array list")]
        [TestCase(12, 0, 4, "Entry index out of range array list")]
        public void SetNegativeTest(int arrayID, int idx, int val, string expectedMessage)
        {
            //arrange
            ArrList arrToTest = TestDataArrList.GetArrListForSetTest(arrayID);
            //act
            Exception ex = Assert.Throws(typeof(IndexOutOfRangeException),
                () => arrToTest.Set(idx, val));
            //assert
            Assert.AreEqual(expectedMessage, ex.Message);
        }

        [TestCase(0, 2)]
        [TestCase(1, 0)]
        [TestCase(2, 3)]
        [TestCase(3, 1)]
        public void RemoveFirstTest(int arrayID, int expectedLength)
        {
            //arrange
            ArrList arrToTest = TestDataArrList.GetArrListForRemoveFirstTest(arrayID);
            int[] expected = TestDataArrList.GetExpectedArrListForRemoveFirstTest(arrayID);

            //act
            arrToTest.RemoveFirst();
            int[] actual = arrToTest.ToArray();

            //assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedLength, arrToTest.GetLength());
        }

        [TestCase(0, 2)]
        [TestCase(1, 0)]
        [TestCase(2, 3)]
        [TestCase(3, 1)]
        public void RemoveLastTest(int arrayID, int expectedLength)
        {
            //arrange
            ArrList arrToTest = TestDataArrList.GetArrListForRemoveLastTest(arrayID);
            int[] expected = TestDataArrList.GetExpectedArrListForRemoveLastTest(arrayID);

            //act
            arrToTest.RemoveLast();
            int[] actual = arrToTest.ToArray();

            //assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedLength, arrToTest.GetLength());
        }

        [TestCase(0, 0, 2)]
        [TestCase(1, 0, 0)]
        [TestCase(2, 2, 3)]
        [TestCase(3, 1, 1)]
        public void RemoveAtTest(int arrayID, int idx, int expectedLength)
        {
            //arrange
            ArrList arrToTest = TestDataArrList.GetArrListForRemoveAtTest(arrayID);
            int[] expected = TestDataArrList.GetExpectedArrListForRemoveAtTest(arrayID);

            //act
            arrToTest.RemoveAt(idx);
            int[] actual = arrToTest.ToArray();

            //assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedLength, arrToTest.GetLength());
        }

        [TestCase(0, 3, "Entry index out of range array list")]
        [TestCase(1, -1, "Entry index out of range array list")]
        [TestCase(12, 0, "Array list is empty")]
        public void RemoveAtNegativeTest(int arrayID, int idx, string expectedMessage)
        {
            //arrange
            ArrList arrToTest = TestDataArrList.GetArrListForRemoveAtTest(arrayID);
            if (arrayID < 2)
            {
                //act
                Exception ex = Assert.Throws(typeof(IndexOutOfRangeException),
                    () => arrToTest.RemoveAt(idx));
                //assert
                Assert.AreEqual(expectedMessage, ex.Message);
            }
            else
            {
                //act
                Exception ex = Assert.Throws(typeof(Exception),
                    () => arrToTest.RemoveAt(idx));
                //assert
                Assert.AreEqual(expectedMessage, ex.Message);
            }
        }

        [TestCase(0, 3, 4)]
        [TestCase(1, 1, 0)]
        [TestCase(2, 6, 0)]
        public void RemoveFirstMultipleTest(int arrayID, int n, int expectedLength)
        {
            //arrange
            ArrList arrToTest = TestDataArrList.GetArrListForRemoveFirstMultipleTest(arrayID);
            int[] expected = TestDataArrList.GetExpectedArrListForRemoveFirstMultipleTest(arrayID);

            //act
            arrToTest.RemoveFirstMultiple(n);
            int[] actual = arrToTest.ToArray();

            //assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedLength, arrToTest.GetLength());
        }

        [TestCase(0, 3, 4)]
        [TestCase(1, 1, 0)]
        [TestCase(2, 6, 0)]
        public void RemoveLastMultipleTest(int arrayID, int n, int expectedLength)
        {
            //arrange
            ArrList arrToTest = TestDataArrList.GetArrListForRemoveLastMultipleTest(arrayID);
            int[] expected = TestDataArrList.GetExpectedArrListForRemoveLastMultipleTest(arrayID);

            //act
            arrToTest.RemoveLastMultiple(n);
            int[] actual = arrToTest.ToArray();

            //assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedLength, arrToTest.GetLength());
        }

        [TestCase(0, 2, 3, 4)]
        [TestCase(1, 0, 5, 0)]
        [TestCase(2, 3, 5, 3)]
        public void RemoveAtMultipleTest(int arrayID, int idx, int n, int expectedLength)
        {
            //arrange
            ArrList arrToTest = TestDataArrList.GetArrListForRemoveAtMultipleTest(arrayID);
            int[] expected = TestDataArrList.GetExpectedArrListForRemoveAtMultipleTest(arrayID);

            //act
            arrToTest.RemoveAtMultiple(idx, n);
            int[] actual = arrToTest.ToArray();

            //assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedLength, arrToTest.GetLength());
        }

        [TestCase(0, 10, 4, "Entry index out of range array list")]
        [TestCase(1, -1, 4, "Entry index out of range array list")]
        public void RemoveAtMultipleNegativeTest(int arrayID, int idx, int n, string expectedMessage)
        {
            //arrange
            ArrList arrToTest = TestDataArrList.GetArrListForRemoveAtMultipleTest(arrayID);
            //act
            Exception ex = Assert.Throws(typeof(IndexOutOfRangeException),
                () => arrToTest.RemoveAtMultiple(idx, n));
            //assert
            Assert.AreEqual(expectedMessage, ex.Message);
        }

        [TestCase(0, 98, 6)]
        [TestCase(1, 3, 1)]
        [TestCase(2, 4, 3)]
        
        public void RemoveFirstOnValTest(int arrayID, int val, int expectedLength)
        {
            //arrange
            ArrList arrToTest = TestDataArrList.GetArrListForRemoveFirstOnValTest(arrayID);
            int[] expected = TestDataArrList.GetExpectedArrListForRemoveFirstOnValTest(arrayID);

            //act
            arrToTest.RemoveFirst(val);
            int[] actual = arrToTest.ToArray();

            //assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedLength, arrToTest.GetLength());
        }
        [TestCase(4, 4, "Array list is empty")]
        public void RemoveFirstAndRemoveLastAndRemoveAtNegativeTest(int arrayID, int val, string expectedMessage)
        {
            //arrange
            ArrList arrToTest = TestDataArrList.GetArrListForRemoveAtTest(arrayID);
            //act
            Exception exRemoveFirstVal = Assert.Throws(typeof(Exception),
                () => arrToTest.RemoveFirst(val));
            Exception exRemoveFirst = Assert.Throws(typeof(Exception),
                () => arrToTest.RemoveFirst());
            Exception exRemoveLast = Assert.Throws(typeof(Exception),
                () => arrToTest.RemoveLast());
            Exception exRemoveAt = Assert.Throws(typeof(Exception),
                () => arrToTest.RemoveAt(2));
            //assert
            Assert.AreEqual(expectedMessage, exRemoveFirstVal.Message);
            Assert.AreEqual(expectedMessage, exRemoveFirst.Message);
            Assert.AreEqual(expectedMessage, exRemoveLast.Message);
            Assert.AreEqual(expectedMessage, exRemoveAt.Message);
        }

        [TestCase(4, 4, "Array list is empty")]
        public void IndexOfContainsRemoveMultipleNegativeTest(int arrayID, int val, string expectedMessage)
        {
            //arrange
            ArrList arrToTest = TestDataArrList.GetArrListForRemoveAtTest(arrayID);
            //act
            Exception exIndexOf = Assert.Throws(typeof(Exception),
                () => arrToTest.IndexOf(val));
            Exception exContains = Assert.Throws(typeof(Exception),
                () => arrToTest.Contains(val));
            Exception exRemoveLastMultiple = Assert.Throws(typeof(Exception),
                () => arrToTest.RemoveLastMultiple(5));
            Exception exRemoveAtMultiple = Assert.Throws(typeof(Exception),
                () => arrToTest.RemoveAtMultiple(0, 5));
            Exception exRemoveFirsttMultiple = Assert.Throws(typeof(Exception),
                () => arrToTest.RemoveFirstMultiple(5));
            //assert
            Assert.AreEqual(expectedMessage, exIndexOf.Message);
            Assert.AreEqual(expectedMessage, exContains.Message);
            Assert.AreEqual(expectedMessage, exRemoveLastMultiple.Message);
            Assert.AreEqual(expectedMessage, exRemoveAtMultiple.Message);
            Assert.AreEqual(expectedMessage, exRemoveFirsttMultiple.Message);
        }
        [TestCase(0, 98, 5)]
        [TestCase(1, 3, 1)]
        [TestCase(2, 4, 3)]
        [TestCase(3, 5, 0)]
        [TestCase(4, 3, 5)]
        [TestCase(5, 3, 5)]
        public void RemoveAllTest(int arrayID, int val, int expectedLength)
        {
            //arrange
            ArrList arrToTest = TestDataArrList.GetArrListForRemoveAllTest(arrayID);
            int[] expected = TestDataArrList.GetExpectedArrListForRemoveAllTest(arrayID);

            //act
            arrToTest.RemoveAll(val);
            int[] actual = arrToTest.ToArray();

            //assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedLength, arrToTest.GetLength());
        }

        [TestCase(0, 98, true)]
        [TestCase(1, 3, false)]
        [TestCase(2, 4, true)]
        [TestCase(3, 5, true)]
        public void ContainsTest(int arrayID, int val, bool expected)
        {
            //arrange
            ArrList arrToTest = TestDataArrList.GetArrListForContainsTest(arrayID);

            //act
            bool actual = arrToTest.Contains(val);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 98, 1)]
        [TestCase(1, 3, -1)]
        [TestCase(2, 4, 3)]
        [TestCase(3, 5, 0)]
        public void IndexOfTest(int arrayID, int idx, int expected)
        {
            //arrange
            ArrList arrToTest = TestDataArrList.GetArrListForIndexOfTest(arrayID);

            //act
            int actual = arrToTest.IndexOf(idx);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(0, 5)]
        [TestCase(1, 4)]
        [TestCase(2, 1)]
        [TestCase(3, 5)]
        public void GetFirstTest(int arrayID,  int expected)
        {
            //arrange
            ArrList arrToTest = TestDataArrList.GetArrListForGetFirstAndLastAndGetTest(arrayID);

            //act
            int actual = arrToTest.GetFirst();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 15)]
        [TestCase(1, 4)]
        [TestCase(2, 4)]
        [TestCase(3, 5)]
        public void GetLastTest(int arrayID, int expected)
        {
            //arrange
            ArrList arrToTest = TestDataArrList.GetArrListForGetFirstAndLastAndGetTest(arrayID);

            //act
            int actual = arrToTest.GetLast();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 4, 0)]
        [TestCase(1, 0, 4)]
        [TestCase(2, 1, 2)]
        [TestCase(3, 3, 5)]
        public void GetTest(int arrayID, int idx, int expected)
        {
            //arrange
            ArrList arrToTest = TestDataArrList.GetArrListForGetFirstAndLastAndGetTest(arrayID);

            //act
            int actual = arrToTest.Get(idx);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 10, "Entry index out of range array list")]
        [TestCase(1, -1, "Entry index out of range array list")]
        [TestCase(12, 0, "Entry index out of range array list")]
        public void GetNegativeTest(int arrayID, int idx,string expectedMessage)
        {
            //arrange
            ArrList arrToTest = TestDataArrList.GetArrListForGetFirstAndLastAndGetTest(arrayID);
            //act
            Exception ex = Assert.Throws(typeof(IndexOutOfRangeException),
                () => arrToTest.Get(idx));
            //assert
            Assert.AreEqual(expectedMessage, ex.Message);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void ReverseTest(int arrayID)
        {
            //arrange
            ArrList arrToTest = TestDataArrList.GetArrListForReverseTest(arrayID);
            ArrList expected = TestDataArrList.GetExpectedArrListForReverseTest(arrayID);

            //act
            arrToTest.Reverse();

            //assert
            Assert.AreEqual(expected.ToArray(), arrToTest.ToArray());
        }

        [TestCase(0, 100)]
        [TestCase(1, 4)]
        [TestCase(2, 4)]
        [TestCase(3, 5)]
        public void MaxTest(int arrayID, int expected)
        {
            //arrange
            ArrList arrToTest = TestDataArrList.GetArrListForMaxAndMinAndTheirIndexesTest(arrayID);

            //act
            int actual = arrToTest.Max();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0)]
        [TestCase(1, 4)]
        [TestCase(2, 1)]
        [TestCase(3, 5)]
        public void MinTest(int arrayID, int expected)
        {
            //arrange
            ArrList arrToTest = TestDataArrList.GetArrListForMaxAndMinAndTheirIndexesTest(arrayID);

            //act
            int actual = arrToTest.Min();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 5)]
        [TestCase(1, 0)]
        [TestCase(2, 3)]
        [TestCase(3, 0)]
        public void IndexOfMaxTest(int arrayID, int expected)
        {
            //arrange
            ArrList arrToTest = TestDataArrList.GetArrListForMaxAndMinAndTheirIndexesTest(arrayID);

            //act
            int actual = arrToTest.IndexOfMax();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 4)]
        [TestCase(1, 0)]
        [TestCase(2, 0)]
        [TestCase(3, 0)]
        public void IndexOfMinTest(int arrayID, int expected)
        {
            //arrange
            ArrList arrToTest = TestDataArrList.GetArrListForMaxAndMinAndTheirIndexesTest(arrayID);

            //act
            int actual = arrToTest.IndexOfMin();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        public void SortTest(int arrayID)
        {
            //arrange
            ArrList arrToTest = TestDataArrList.GetArrListForSortAndSortDescTest(arrayID);
            ArrList expected = TestDataArrList.GetExpectedArrListForSortTest(arrayID);

            //act
            arrToTest.Sort();

            //assert
            Assert.AreEqual(expected.ToArray(), arrToTest.ToArray());
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        public void SortDescTest(int arrayID)
        {
            //arrange
            ArrList arrToTest = TestDataArrList.GetArrListForSortAndSortDescTest(arrayID);
            ArrList expected = TestDataArrList.GetExpectedArrListForSortDescTest(arrayID);

            //act
            arrToTest.SortDesc();

            //assert
            Assert.AreEqual(expected.ToArray(), arrToTest.ToArray());
        }
    }
}