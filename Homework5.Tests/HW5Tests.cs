using NUnit.Framework;
using System;

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


        [TestCase(33, "Ìàññèâ ïóñòîé")]
        public void SearchMinElementTwoDimArrNegativeTest(int arrayID, string expectedMessage)
        {
            //arrange
            int[,] arrayToTest = TestDataHW5.
                GetArraysForSearchMinAndMaxElementsAndThisIndexesTwoDimArrTest(arrayID);

            //act
            Exception ex= Assert.Throws(typeof(ArgumentException),
                ()=>_hw5.SearchMinElementTwoDimArr(arrayToTest));
            //assert
            Assert.AreEqual(expectedMessage, ex.Message);
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

        [TestCase(33, "Ìàññèâ ïóñòîé")]
        public void SearchMaxElementTwoDimArrNegativeTest(int arrayID, string expectedMessage)
        {
            //arrange
            int[,] arrayToTest = TestDataHW5.
                GetArraysForSearchMinAndMaxElementsAndThisIndexesTwoDimArrTest(arrayID);

            //act
            Exception ex = Assert.Throws(typeof(ArgumentException),
                () => _hw5.SearchMaxElementTwoDimArr(arrayToTest));
            //assert
            Assert.AreEqual(expectedMessage, ex.Message);
        }
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void SearchIndexMinElementMatrixTest(int arrayID)
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

        [TestCase(33, "Ìàññèâ ïóñòîé")]
        public void SearchIndexMinElementMatrixNegativeTest(int arrayID, string expectedMessage)
        {
            //arrange
            int[,] arrayToTest = TestDataHW5.
                GetArraysForSearchMinAndMaxElementsAndThisIndexesTwoDimArrTest(arrayID);

            //act
            Exception ex = Assert.Throws(typeof(ArgumentException),
                () => _hw5.SearchIndexMinElementMatrix(arrayToTest));
            //assert
            Assert.AreEqual(expectedMessage, ex.Message);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void SearchIndexMaxElementMatrixTest(int arrayID)
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

        [TestCase(33, "Ìàññèâ ïóñòîé")]
        public void SearchIndexMaxElementMatrixNegativeTest(int arrayID, string expectedMessage)
        {
            //arrange
            int[,] arrayToTest = TestDataHW5.
                GetArraysForSearchMinAndMaxElementsAndThisIndexesTwoDimArrTest(arrayID);

            //act
            Exception ex = Assert.Throws(typeof(ArgumentException),
                () => _hw5.SearchIndexMaxElementMatrix(arrayToTest));
            //assert
            Assert.AreEqual(expectedMessage, ex.Message);
        }

        [TestCase(0, 1)]
        [TestCase(1, 4)]
        [TestCase(2, 0)]
        [TestCase(3, 0)]
        [TestCase(312, 0)]
        public void ÑountTheNumberOfElementsThatAreLargerThanAllTheirNeighborsAtTheSameTimeTest(int arrayID, int expected)
        {
            //arrange
            int[,] arrayToTest = TestDataHW5.
                GetArraysForÑountTheNumberOfElementsThatAreLargerThanAllTheirNeighborsAtTheSameTimeTest(arrayID);

            //act
            int actual = _hw5.ÑountTheNumberOfElementsThatAreLargerThanAllTheirNeighborsAtTheSameTime(arrayToTest);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(228)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        
        public void TransponseTheMatrixTest(int arrayID)
        {
            //arrange
            int[,] arrayToTest = TestDataHW5.
                GetArraysForTransponseTheMatrixTest(arrayID);
            int[,] expected = TestDataHW5.
                GetExpectedArraysForTransponseTheMatrixTest(arrayID);

            //act
            _hw5.TransponseTheMatrix(arrayToTest);
            //assert
            Assert.AreEqual(expected, arrayToTest);
        }

        [TestCase(4, "Ìàòğèöà äîëæíà áûòü êâàäğàòíîé")]
        [TestCase(5, "Ìàòğèöà äîëæíà áûòü êâàäğàòíîé")]
        public void TransponseTheMatrixNegativeTest(int arrayID, string expectedMessage)
        {
            //arrange
            int[,] arrayToTest = TestDataHW5.
                GetArraysForTransponseTheMatrixTest(arrayID);

            //act
            Exception ex = Assert.Throws(typeof(IncorrectMatrixDimension),
                () => _hw5.TransponseTheMatrix(arrayToTest));
            //assert
            Assert.AreEqual(expectedMessage, ex.Message);
        }


    }
}