using NUnit.Framework;

namespace Homework5.Tests
{
    public class HW5Tests
    {
        private HW5 _hw5;
        [SetUp]
        public void Setup()
        {
            _hw5 = new HW5();
        }

        [TestCase(0, 1)]
        [TestCase(1, -911)]
        [TestCase(2, 4)]
        [TestCase(3, 4)]
        public void SearchMinElementTwoDimArrTest(int arrayID, int expected)
        {
            //arrange
            int[,] arrayToTest = TestDataHW5.
                GetArraysForSearchMinAndMaxElementsAndThisIndexesTwoDimArrTest(arrayID);

            //act
            int actual = _hw5.SearchMinElementTwoDimArr(arrayToTest);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(0, 9)]
        [TestCase(1, 60)]
        [TestCase(2, 4)]
        [TestCase(3, 4)]
        public void SearchMaxElementArrTest(int arrayID, int expected)
        {
            //arrange
            int[,] arrayToTest = TestDataHW5.
                GetArraysForSearchMinAndMaxElementsAndThisIndexesTwoDimArrTest(arrayID);

            //act
            int actual = _hw5.SearchMaxElementTwoDimArr(arrayToTest);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void SearchIndexMinElementArrTest(int arrayID)
        {
            //arrange
            int[,] arrayToTest = TestDataHW5.
                GetArraysForSearchMinAndMaxElementsAndThisIndexesTwoDimArrTest(arrayID);
            int[] expected = TestDataHW5.
                GetExpectedArraysForSearchIndexMinElementMatrixTest(arrayID);
            //act
            int[] actual = _hw5.SearchIndexMinElementMatrix(arrayToTest);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void SearchIndexMaxElementArrTest(int arrayID)
        {
            //arrange
            int[,] arrayToTest = TestDataHW5.
                GetArraysForSearchMinAndMaxElementsAndThisIndexesTwoDimArrTest(arrayID);
            int[] expected = TestDataHW5.
                GetExpectedArraysForSearchIndexMaxElementMatrixTest(arrayID);

            //act
            int[] actual = _hw5.SearchIndexMaxElementMatrix(arrayToTest);
            //assert
            Assert.AreEqual(expected, actual);
        }


    }
}