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

        [TestCase(1, "� 1 ��������")]
        [TestCase(2, "� 2 ��������")]
        [TestCase(3, "� 3 ��������")]
        [TestCase(4, "� 4 ��������")]
        [TestCase(11, "�� ��� Y")]
        [TestCase(22, "�� ��� X")]
        [TestCase(0, "� ������")]
        [TestCase(-228, "������ ����� �������� �� �� ����������� ������� :D")]
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

        [TestCase(0, 0, 1, "����� � �� ������ ���� ����� 0, ����� ��� �� " +
                    "���������� ���������")]
        public void SolveQuadraticEquationNegativeTest(
            int A, int B, int C, string expectedMessage)
        {
            //arrange
            
            //act

            Exception ex = Assert.Throws(typeof(ArgumentException),
                () => _hw2.SolveQuadraticEquation(A, B, C));

            //assert - ��������� ����������
            Assert.AreEqual(expectedMessage, ex.Message);
        }

        [TestCase(1, "����")]
        [TestCase(2, "���")]
        [TestCase(3, "���")]
        [TestCase(4, "������")]
        [TestCase(5, "����")]
        [TestCase(6, "�����")]
        [TestCase(7, "����")]
        [TestCase(8, "������")]
        [TestCase(9, "������")]
        [TestCase(0, "")]
        public void WriteAUnitsTest(int units, string expected)
        {
            //arrange

            //act
            string actual = _hw2.WriteAUnits(units);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(228, "����� �� �� �������� ������")]
        public void WriteAUnitsNegativeTest(int units, string expected)
        {
            //arrange

            //act
            Exception ex = Assert.Throws(typeof(ArgumentException),
                () => _hw2.WriteAUnits(units));
            //assert
            Assert.AreEqual(expected, ex.Message);
        }

        [TestCase(10, "������")]
        [TestCase(11, "�����������")]
        [TestCase(12, "����������")]
        [TestCase(13, "����������")]
        [TestCase(14, "������������")]
        [TestCase(15, "����������")]
        [TestCase(16, "�����������")]
        [TestCase(17, "����������")]
        [TestCase(18, "������������")]
        [TestCase(19, "������������")]
        public void WriteTillTwentyTest(int number, string expected)
        {
            //arrange

            //act
            string actual = _hw2.WriteTillTwenty(number);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(228, "����� �� �� �������� ������")]
        public void WriteTillTwentyNegativeTest(int number, string expected)
        {
            //arrange

            //act
            Exception ex = Assert.Throws(typeof(ArgumentException),
                () => _hw2.WriteTillTwenty(number));
            //assert
            Assert.AreEqual(expected, ex.Message);
        }



        [TestCase(2, "��������")]
        [TestCase(3, "��������")]
        [TestCase(4, "�����")]
        [TestCase(5, "���������")]
        [TestCase(6, "����������")]
        [TestCase(7, "���������")]
        [TestCase(8, "�����������")]
        [TestCase(9, "���������")]
        public void WriteADozensTest(int number, string expected)
        {
            //arrange

            //act
            string actual = _hw2.WriteADozens(number);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(228, "����� �� �� �������� ������")]
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