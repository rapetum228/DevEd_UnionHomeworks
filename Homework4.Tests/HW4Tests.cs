using NUnit.Framework;
using System;

namespace Homework4.Tests
{
    public class HW4Tests
    {
        private HW4 _hw4;
        [SetUp]
        public void Setup()
        {
            _hw4 = new HW4();
        }

        [TestCase(0, 1)]
        [TestCase(1, -8)]
        [TestCase(2, 1)]
        [TestCase(3, 0)]
        public void SearchMinElementArrTest(int arrayID, int expected)
        {
            //arrange
            int[] arrayToTest = TestDataHW4.
                GetArrayForSearchMinAndMaxAndThemIndexesElementArrTest(arrayID);

            //act
            int actual = _hw4.SearchMinElementArr(arrayToTest);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(0, 3)]
        [TestCase(1, 10)]
        [TestCase(2, 1)]
        [TestCase(3, 0)]
        public void SearchMaxElementArrTest(int arrayID, int expected)
        {
            //arrange
            int[] arrayToTest = TestDataHW4.
                GetArrayForSearchMinAndMaxAndThemIndexesElementArrTest(arrayID);

            //act
            int actual = _hw4.SearchMaxElementArr(arrayToTest);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(0, 0)]
        [TestCase(1, 5)]
        [TestCase(2, 0)]
        [TestCase(3, 0)]
        public void SearchIndexMinElementArrTest(int arrayID, int expected)
        {
            //arrange
            int[] arrayToTest = TestDataHW4.
                GetArrayForSearchMinAndMaxAndThemIndexesElementArrTest(arrayID);

            //act
            int actual = _hw4.SearchIndexMinElementArr(arrayToTest);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 2)]
        [TestCase(1, 4)]
        [TestCase(2, 0)]
        [TestCase(3, 0)]
        public void SearchIndexMaxElementArrTest(int arrayID, int expected)
        {
            //arrange
            int[] arrayToTest = TestDataHW4.
                GetArrayForSearchMinAndMaxAndThemIndexesElementArrTest(arrayID);

            //act
            int actual = _hw4.SearchIndexMaxElementArr(arrayToTest);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 8)]
        [TestCase(1, 0)]
        [TestCase(2, 6)]
        [TestCase(3, 0)]
        public void CalculateTheSumOfTheElementsOfAnArrayWithOddIndicesTest(int arrayID, int expected)
        {
            //arrange
            int[] arrayToTest = TestDataHW4.
                GetArrForCalcTheSumOfElementsOfArrayWithOddIndicesTest(arrayID);

            //act
            int actual = _hw4.CalculateTheSumOfTheElementsOfAnArrayWithOddIndices(arrayToTest);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(1000)]
        public void ReverseTheArrayTest(int arrayID)
        {
            //arrange
            int[] arrayToTest = TestDataHW4.
                GetArrForReverseTheArrayTest(arrayID);
            int[] expected = TestDataHW4.
                GetExpextedArrForReverseTheArrayTest(arrayID);

            //act
            _hw4.ReverseTheArray(arrayToTest);
            //assert
            Assert.AreEqual(expected, arrayToTest);
        }

        [TestCase(0, 4)]
        [TestCase(1, 5)]
        [TestCase(2, 0)]
        [TestCase(3, 4)]
        [TestCase(4, 3)]
        [TestCase(5, 0)]
        [TestCase(115, 0)]
        public void CountTheNumberOfOddElementsInAnArrayTest(int arrayID, int expected)
        {
            //arrange
            int[] arrayToTest = TestDataHW4.
                GetArrCountTheNumberOfOddElementsInAnArrayTest(arrayID);

            //act
            int actual = _hw4.CountTheNumberOfOddElementsInAnArray(arrayToTest);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(1000)]
        public void ChangeHalfsOfArrayTest(int arrayID)
        {
            //arrange
            int[] arrayToTest = TestDataHW4.
                GetArrForChangeHalfsOfArrayTest(arrayID);
            int[] expected = TestDataHW4.
                GetExpextedArrForChangeHalfsOfArrayTest(arrayID);

            //act
            _hw4.ChangeHalfsOfArray(arrayToTest);
            //assert
            Assert.AreEqual(expected, arrayToTest);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(1000)]
        public void SortBubbleAscendingTest(int arrayID)
        {
            //arrange
            int[] arrayToTest = TestDataHW4.
                GetArrForSortTest(arrayID);
            int[] expected = TestDataHW4.
                GetExpextedArrForSortBubbleAscendingTest(arrayID);

            //act
            _hw4.SortBubbleAscending(arrayToTest);
            //assert
            Assert.AreEqual(expected, arrayToTest);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(1000)]
        public void SortInsertDescendingTest(int arrayID)
        {
            //arrange
            int[] arrayToTest = TestDataHW4.
                GetExpextedArrForSortInsertDescendingTest(arrayID);
            int[] expected = TestDataHW4.
                GetExpextedArrForSortInsertDescendingTest(arrayID);

            //act
            _hw4.SortInsertDescending(arrayToTest);
            //assert
            Assert.AreEqual(expected, arrayToTest);
        }
    }
}
