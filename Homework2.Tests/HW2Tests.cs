using NUnit.Framework;
using System;

namespace Homework2.Tests
{
    public class HW2Tests
    {
        private HW2 _hw2;
        [SetUp]
        public void Setup()
        {
            _hw2 = new HW2();
        }

        [TestCase(3, 1, 4)]
        [TestCase(1, 3, -2)]
        [TestCase(-3, -3, 9)]
        public void CalculateTheValuesDependingOnTheEnteredNumbersTest(
            int A, int B, int expectedResult)
        {
            //arrange

            //act
            int actualResult = _hw2.CalculateTheValuesDependingOnTheEnteredNumbers(A, B);
            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(3, 1, 1)]
        [TestCase(-1, 3, 2)]
        [TestCase(-3, -3, 3)]
        [TestCase(3, -1, 4)]
        [TestCase(0, 3, 11)]
        [TestCase(-3, 0, 22)]
        [TestCase(0, 0, 0)]
        public void DetermineThePositionOnTheCoordinatePlaneTest(
            int A, int B, int expectedResult)
        {
            //arrange

            //act
            int actualResult = _hw2.DetermineThePositionOnTheCoordinatePlane(A, B);
            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(1, "в 1 четверти")]
        [TestCase(2, "в 2 четверти")]
        [TestCase(3, "в 3 четверти")]
        [TestCase(4, "в 4 четверти")]
        [TestCase(11, "на оси Y")]
        [TestCase(22, "на оси X")]
        [TestCase(0, "в центре")]
        [TestCase(-228, "данное число получено не из предыдущего условия :D")]
        public void ConvertNumbersFromConditionsToAStringTest(
            int numberFromCondition, string expectedResult)
        {
            //arrange

            //act
            string actualResult = _hw2.ConvertNumbersFromConditionsToAString(numberFromCondition);
            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("", 1, 2, 3, " 1, 2, 3")]
        [TestCase("", 3, 2, 1, " 1, 2, 3")]
        [TestCase("", 2, 1, 3, " 1, 2, 3")]
        [TestCase("", 1, 3, 2, " 1, 2, 3")]
        [TestCase("", 3, 1, 2, " 1, 2, 3")]
        [TestCase("", 3, 3, 3, " 3, 3, 3")]
        [TestCase("", 1, 3, 1, " 1, 1, 3")]
        [TestCase("", 3, 3, 1, " 1, 3, 3")]
        [TestCase("", 851, -345, 432, " -345, 432, 851")]
        public void OutputAscendingTest(
            string preResult, int A, int B, int C, string expectedResult)
        {
            //arrange
            string actualResult;
            //act
            actualResult = _hw2.OutputAscending(ref preResult, A, B, C);
            actualResult = _hw2.OutputAscending(ref preResult, B, A, C);
            actualResult = _hw2.OutputAscending(ref preResult, C, A, B);
            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(1, 6, 5, new double[] { -1, -5 })]
        [TestCase(4, 4, 1, new double[] { -0.5 })]
        [TestCase(10, 6, 5, new double[] { })]
        [TestCase(4, 4, 0, new double[] { 0, -1 })]
        [TestCase(-4, 0, 1, new double[] { -0.5, 0.5 })]
        [TestCase(4, 0, 0, new double[] { 0 })]
        public void SolveQuadraticEquationTest(
            int A, int B, int C, double[] expectedResult)
        {
            //arrange
            double[] actualResult;
            //act
            actualResult = _hw2.SolveQuadraticEquation(A, B, C);
            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(0, 0, 1, "Число А не должно быть равно 0, иначе это не " +
                    "квадратное уравнение")]
        public void SolveQuadraticEquationNegativeTest(
            int A, int B, int C, string expectedMessage)
        {
            //arrange
            
            //act

            Exception ex = Assert.Throws(typeof(ArgumentException),
                () => _hw2.SolveQuadraticEquation(A, B, C));

            //assert - проверяем результаты
            Assert.AreEqual(expectedMessage, ex.Message);
        }

        [TestCase(1, "один")]
        [TestCase(2, "два")]
        [TestCase(3, "три")]
        [TestCase(4, "четыре")]
        [TestCase(5, "пять")]
        [TestCase(6, "шесть")]
        [TestCase(7, "семь")]
        [TestCase(8, "восемь")]
        [TestCase(9, "девять")]
        [TestCase(0, "")]
        public void WriteAUnitsTest(int units, string expected)
        {
            //arrange

            //act
            string actual = _hw2.WriteAUnits(units);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(228, "Число не из главного метода")]
        public void WriteAUnitsNegativeTest(int units, string expected)
        {
            //arrange

            //act
            Exception ex = Assert.Throws(typeof(ArgumentException),
                () => _hw2.WriteAUnits(units));
            //assert
            Assert.AreEqual(expected, ex.Message);
        }

        [TestCase(10, "десять")]
        [TestCase(11, "одиннадцать")]
        [TestCase(12, "двенадцать")]
        [TestCase(13, "тринадцать")]
        [TestCase(14, "четырнадцать")]
        [TestCase(15, "пятнадцать")]
        [TestCase(16, "шестнадцать")]
        [TestCase(17, "семнадцать")]
        [TestCase(18, "восемнадцать")]
        [TestCase(19, "девятнадцать")]
        public void WriteTillTwentyTest(int number, string expected)
        {
            //arrange

            //act
            string actual = _hw2.WriteTillTwenty(number);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(228, "Число не из главного метода")]
        public void WriteTillTwentyNegativeTest(int number, string expected)
        {
            //arrange

            //act
            Exception ex = Assert.Throws(typeof(ArgumentException),
                () => _hw2.WriteTillTwenty(number));
            //assert
            Assert.AreEqual(expected, ex.Message);
        }



        [TestCase(2, "двадцать")]
        [TestCase(3, "тридцать")]
        [TestCase(4, "сорок")]
        [TestCase(5, "пятьдесят")]
        [TestCase(6, "шестьдесят")]
        [TestCase(7, "семьдесят")]
        [TestCase(8, "восемьдесят")]
        [TestCase(9, "девяносто")]
        public void WriteADozensTest(int number, string expected)
        {
            //arrange

            //act
            string actual = _hw2.WriteADozens(number);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(228, "Число не из главного метода")]
        public void WriteADozensNegativeTest(int number, string expected)
        {
            //arrange

            //act
            Exception ex = Assert.Throws(typeof(ArgumentException),
                () => _hw2.WriteADozens(number));
            //assert
            Assert.AreEqual(expected, ex.Message);
        }
    }
}