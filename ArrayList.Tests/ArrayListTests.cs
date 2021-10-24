using ArrayListLibrary;
using NUnit.Framework;

namespace ArrayList.Tests
{
    public class ArrayListTests
    {
        private ArrList _arrList; 
        [SetUp]
        public void Setup()
        {
            _arrList = new ArrList();
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

        [TestCase(0, 1, 7, 3)]
        [TestCase(1, 0, 11, 1)]
        [TestCase(2, 2, 5, 4)]
        [TestCase(3, 2, 11, 2)]
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

        [TestCase(0, 3, 3)]
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
        [TestCase(1, 3, 1, 1)]
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

        [TestCase(0, 98, 5)]
        [TestCase(1, 3, 1)]
        [TestCase(2, 4, 3)]
        [TestCase(3, 5, 0)]
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
    }
}