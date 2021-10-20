using NUnit.Framework;
using System;

namespace Homework3.Tests
{
    public class HW3Tests
    {
        HW3 _hw3;
        [SetUp]
        public void Setup()
        {
            _hw3 = new HW3();
        }

        [TestCase(0, 0, 0)]
        [TestCase(0, 3, 0)]
        [TestCase(1, 23, 1)]
        [TestCase(-5, 3, -125)]
        [TestCase(2, 6, 64)]
        [TestCase(-2, 8, 256)]
        [TestCase(2, -2, 0.25)]
        [TestCase(-5, -2, 0.04)]
        [TestCase(-5, -3, -0.008)]
        public void RaiseTheNumberToThePowerTest(int numberRaisedToAPower, 
            int numberDegree,
            double expected)
        {
            //arrange

            //act
            double actual = _hw3.RaiseTheNumberToThePower(numberRaisedToAPower, numberDegree);
            //asert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(250, new int[] {250, 500, 750, 1000 })]
        [TestCase(333, new int[] { 333, 666, 999 })]
        [TestCase(-444, new int[] { 444, 888 })]
        [TestCase(1500, new int[] {})]
        public void DivisionByATest(int divider,
            int[] expected)
        {
            //arrange

            //act
            int[] actual = _hw3.DivisionByA(divider);
            //asert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, "На ноль делить нельзя")]
        public void DivisionByANegativeTest(int divider,
            string expected)
        {
            //arrange

            //act
            Exception ex = Assert.Throws(typeof(DivideByZeroException),
                () => _hw3.DivisionByA(divider));
            //asert
            Assert.AreEqual(expected, ex.Message);
        }

        [TestCase(10, 3)]
        [TestCase(16, 3)]
        [TestCase(17, 4)]
        [TestCase(0,0)]
        [TestCase(126, 11)]
        public void CalculatingTheNumbersLessSquarATest(int numberA,
            int expected)
        {
            //arrange

            //act
            int actual = _hw3.CalculatingTheNumbersLessSquarA(numberA);
            //asert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-100, "Введённое число должно быть положительным")]
        public void CalculatingTheNumbersLessSquarANegativeTest(int numberA,
            string expected)
        {
            //arrange

            //act
            Exception ex = Assert.Throws(typeof(ArgumentException),
                () => _hw3.CalculatingTheNumbersLessSquarA(numberA));
            //asert
            Assert.AreEqual(expected, ex.Message);
        }

        [TestCase(10, 5)]
        [TestCase(16, 8)]
        [TestCase(17, 1)]
        [TestCase(-228, 114)]
        public void CalcGreatDividerATest(int numberA,
            int expected)
        {
            //arrange

            //act
            int actual = _hw3.CalcGreatDividerA(numberA);
            //asert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, "Число должно быть по модулю больше единицы")]
        [TestCase(0, "Число должно быть по модулю больше единицы")]
        [TestCase(-1, "Число должно быть по модулю больше единицы")]
        public void CalcGreatDividerANegativeTest(int numberA,
            string expected)
        {
            //arrange

            //act
            Exception ex = Assert.Throws(typeof(ArgumentException),
                () => _hw3.CalcGreatDividerA(numberA));
            //asert
            Assert.AreEqual(expected, ex.Message);
        }

        [TestCase(10, 5, new int[] {5, 10})]
        [TestCase(5, 18, new int[] { 5, 18})]
        [TestCase(-228, 114, new int[] { -228, 114 })]
        [TestCase(-118, -214, new int[] { -214, -118 })]
        [TestCase(-118, -118, new int[] { -118, -118 })]
        public void SearchForRangeBoundariesTest(int numberA, int numberB,
            int[] expected)
        {
            //arrange

            //act
            int[] actual = _hw3.SearchForRangeBoundaries(numberA, numberB);
            //asert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 5, 18 }, 21)]
        [TestCase(new int[] { -228, -200 }, -854)]
        [TestCase(new int[] { -10, 7 }, 0)]
        [TestCase(new int[] { -2, 5 }, 0)]
        [TestCase(new int[] { 6, 7 }, 7)]
        [TestCase(new int[] { -7, -7 }, -7)]
        public void SumOfNumbersDividedBySevenTest(int[] range, int expected)
        {
            //arrange

            //act
            int actual = _hw3.SumOfNumbersDividedBySeven(range);
            //asert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(144, 144)]
        [TestCase(-21, -21)]
        [TestCase(-228, -144)]
        [TestCase(228, 144)]
        [TestCase(0, 0)]
        public void CalcNumberFibonacciTest(int number, int expected)
        {
            //arrange

            //act
            int actual = _hw3.CalcNumberFibonacci(number);
            //asert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(12, 144, 12)]
        [TestCase(13, 144, 1)]
        [TestCase(13, 13, 13)]
        [TestCase(-13, 13, 13)]
        [TestCase(-10, -125, 5)]
        [TestCase(144, 12, 12)]
        [TestCase(1, -1, 1)]
        [TestCase(1, 1, 1)]
        public void CalcTheGCDUsingEuclidsAlgorithmTest(int firstNumber,
            int secondNumber, int expected)
        {
            //arrange

            //act
            int actual = _hw3.CalcTheGCDUsingEuclidsAlgorithm(firstNumber, secondNumber);
            //asert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 0, "Числа должны быть не равны нулю")]
        [TestCase(0, 1, "Числа должны быть не равны нулю")]
        [TestCase(0, 0, "Числа должны быть не равны нулю")]
        public void CalcTheGCDUsingEuclidsAlgorithmNegativeTest(int firstNumber,
            int secondNumber, string expected)
        {
            //arrange

            //act
            Exception ex = Assert.Throws(typeof(ArgumentException),
                () => _hw3.CalcTheGCDUsingEuclidsAlgorithm(firstNumber, secondNumber));
            //asert
            Assert.AreEqual(expected, ex.Message);
        }

        [TestCase(2197, 13)]
        [TestCase(64, 4)]
        [TestCase(125, 5)]
        [TestCase(27, 3)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void CalcWithHalfDivisionMethodTest(int number, int expected)
        {
            //arrange

            //act
            int actual = _hw3.CalcWithHalfDivisionMethod(number);
            //asert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2585, "Число слишком большое, могу посчитать числа не выше 2580")]
        [TestCase(-27, "Число должно быть положительным")]
        [TestCase(461, "Данное число не куб целого числа((")]
        public void CalcWithHalfDivisionMethodNegativeTest(int number, string expected)
        {
            //arrange

            //act
            Exception ex = Assert.Throws(typeof(ArgumentException),
                () => _hw3.CalcWithHalfDivisionMethod(number));
            //asert
            Assert.AreEqual(expected, ex.Message);
        }

        [TestCase(123, 2)]
        [TestCase(2222, 0)]
        [TestCase(111, 3)]
        [TestCase(-137, 3)]
        [TestCase(-200, 0)]
        [TestCase(145, 2)]
        [TestCase(-201, 1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void CalculateTheNumberOfOddDigitsOfANumberTest(int number, int expected)
        {
            //arrange

            //act
            int actual = _hw3.CalculateTheNumberOfOddDigitsOfANumber(number);
            //asert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-123, -321)]
        [TestCase(-2222, -2222)]
        [TestCase(123, 321)]
        [TestCase(2222, 2222)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(200, 2)]
        [TestCase(21000, 12)]
        public void CalcMirrorImageOfNumberTest(int number, int expected)
        {
            //arrange

            //act
            int actual = _hw3.CalcMirrorImageOfNumber(number);
            //asert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, new int[] { 2, 4, 6, 8 })]
        [TestCase(35, new int[] { 2, 4, 6, 8, 12, 14, 16, 18, 20, 21, 22, 24, 26, 28, 34 })]
        public void CalcNumbersSumEvenGreaterOddTest(int number, int[] expected)
        {
            //arrange

            //act
            int[] actual = _hw3.CalcNumbersSumEvenGreaterOdd(number);
            //asert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(-10, "Число должно быть положительным")]
        public void CalcNumbersSumEvenGreaterOddNegativeTest(int number, string expected)
        {
            //arrange

            //act
            Exception ex = Assert.Throws(typeof(ArgumentException),
                () => _hw3.CalcNumbersSumEvenGreaterOdd(number));
            //asert
            Assert.AreEqual(expected, ex.Message);
        }

        [TestCase(1, new int[] { 1, 0 })]
        [TestCase(35, new int[] { 8, 0 })]
        [TestCase(2, new int[] { 0, 2 })]
        [TestCase(163, new int[] { 4, 6 })]
        [TestCase(4569, new int[] { 14, 10 })]
        public void CalculatedTheSumsOfEvenAndOddDigitsANumberTest(int i, int[] expected)
        {
            //arrange

            //act
            int[] actual = _hw3.CalculatedTheSumsOfEvenAndOddDigitsANumber(i);
            //asert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(-10, "Число должно быть больше нуля")]
        public void CalculatedTheSumsOfEvenAndOddDigitsANumberNegativeTest(int i, 
            string expected)
        {
            //arrange

            //act
            Exception ex = Assert.Throws(typeof(ArgumentException),
                () => _hw3.CalculatedTheSumsOfEvenAndOddDigitsANumber(i));
            //asert
            Assert.AreEqual(expected, ex.Message);
        }
        
        [TestCase(163, new int[] { 4, 6 }, 163, 163, 163)]
        [TestCase(1, new int[] { 1, 0 }, 1, 0, 0)]
        [TestCase(35, new int[] { 8, 0 }, 35, 0, 34)]
        [TestCase(2, new int[] { 0, 2 }, 2, 2, 2)]
        [TestCase(4569, new int[] { 14, 10 }, 4569, 0, 4568)]
        [TestCase(8565, new int[] { 10, 14 }, 8565, 8565, 8565)]
        [TestCase(0, new int[] { 0, 0 }, 0, 0, -1)]
        public void FindNumWhereSumOfEvenDigitsIsGreaterThanOddDigitsTest(
            int i, int[] counterOddEven, ref int arrLength, 
            int expectedResNum, int expectedLengthArray)
        {
            //arrange

            //act
            int actual = _hw3.FindNumWhereSumOfEvenDigitsIsGreaterThanOddDigits(i,
                counterOddEven, ref arrLength);
            //asert
            Assert.AreEqual(expectedResNum, actual);
            Assert.AreEqual(expectedLengthArray, arrLength);
        }
       
        [TestCase(100, 202, true)]
        [TestCase(100, 222, false)]
        [TestCase(100, 0, true)]
        [TestCase(0, 10111, true)]
        [TestCase(-123, 501, true)]
        [TestCase(-123, -456, false)]
        [TestCase(123, -45676, false)]
        [TestCase(121893, -4976, true)]
        [TestCase(0, 0, true)]
        public void SearchEqualDigitsTest(int firstNum, int secondNum, bool expected)
        {
            //arrange

            //act
            bool actual = _hw3.SearchEqualDigits(firstNum, secondNum);
            //asert
            Assert.AreEqual(expected, actual);
        }
    }
}