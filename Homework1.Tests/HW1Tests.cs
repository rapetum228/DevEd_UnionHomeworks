using NUnit.Framework;
using System;

namespace Homework1.Tests
{
    public class HW1Tests
    {
        private HW1 _hw1;
        [SetUp] //�������� - ������ �� ������ (����������)
                //�������� ��������� ������� ������
        public void Setup() //����������� ����� ������ ������
        {
            _hw1 = new HW1();
        }

        [TestCase(5, 9, 26.5)]
        public void FindASolutionUsingTheFormulaTest(double numberA, double numberB, 
            double expectedResult)
        {
            //arrange - ������� ����������

            //act - �������� ����� 
            double actualResult = _hw1.FindASolutionUsingTheFormula(numberA, numberB);

            //assert - ��������� ����������
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestCase(5, 5,
            "������. ������� �� ����... ����� �� ������ ���� �����")]
        public void FindASolutionUsingTheFormulaNegativeTest(
            double numberA, double numberB, string expectedMessage
            )
        {
            //arrange - ������� ����������

            //act - �������� ����� 
            Exception ex = Assert.Throws(typeof(DivideByZeroException), 
                () => _hw1.FindASolutionUsingTheFormula(numberA, numberB));

            //assert - ��������� ����������
            Assert.AreEqual(expectedMessage, ex.Message);
        }

        [TestCase(5, 9, 9)]
        public void SwapTheVariablesTest(double numberA, double numberB,
            double expectedResultA)
        {
            //arrange - ������� ����������

            //act - �������� ����� 
            _hw1.SwapTheVariables(ref numberA, ref numberB);

            //assert - ��������� ����������
            Assert.AreEqual(expectedResultA, numberA);
        }

        [TestCase(5, 5,
            "������. ������� �� ����... ����� �� ������ ���� �����")]
        public void FindASolutionUsingTheFormulaNegativeTest(
            double numberA, double numberB, string expectedMessage
            )
        {
            //arrange - ������� ����������

            //act - �������� ����� 
            Exception ex = Assert.Throws(typeof(DivideByZeroException), 
                () => _hw1.FindASolutionUsingTheFormula(numberA, numberB));

            //assert - ��������� ����������
            Assert.AreEqual(expectedMessage, ex.Message);
        }

        [TestCase(2, 3, 0)]
        [TestCase(-6, -3, 2)]
        [TestCase(0, 3, 0)]
        [TestCase(7, 3, 2)]
        public void CalculateTheWholePartOfTheDivisionTest(double numberA, double numberB,
           int expectedResult)
        {
            //arrange - ������� ����������

            //act - �������� ����� 
            int actualResult = _hw1.CalculateTheWholePartOfTheDivision(numberA, numberB);

            //assert - ��������� ����������
            Assert.AreEqual(expectedResult, actualResult);
        }

<<<<<<< HEAD
        [TestCase(5, 0,
            "������. ������� �� ����... ����� � �� ������ ���� ����� ����...")]
        public void CalculateTheWholePartOfTheDivisionNegativeTest(
            double numberA, double numberB, string expectedMessage
            )
=======
        [TestCase(2, 3, 0)]
        [TestCase(-6, -3, 2)]
        [TestCase(0, 3, 0)]
        [TestCase(7, 3, 2)]
        public void CalculateTheWholePartOfTheDivisionTest(double numberA, double numberB,
           int expectedResult)
>>>>>>> 702b390ac91cf9ac014bedcb4a87b245e9115d40
        {
            //arrange - ������� ����������

            //act - �������� ����� 
<<<<<<< HEAD
            Exception ex = Assert.Throws(typeof(OverflowException),
                () => _hw1.CalculateTheWholePartOfTheDivision(numberA, numberB));

            //assert - ��������� ����������
            Assert.AreEqual(expectedMessage, ex.Message);
        }

        [TestCase(2, 3, 2)]
        [TestCase(-6, -3, 0)]
        [TestCase(0, 3, 0)]
        [TestCase(7, 3, 1)]
        public void CalculateTheRemainderOfTheDivisionTest(double numberA, double numberB,
           int expectedResult)
        {
            //arrange - ������� ����������

            //act - �������� ����� 
            int actualResult = _hw1.CalculateTheRemainderOfTheDivision(numberA, numberB);

            //assert - ��������� ����������
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(5, 0,
            "������. ������� �� ����... ����� � �� ������ ���� ����� ����...")]
        public void CalculateTheRemainderOfTheDivisionNegativeTest(
            double numberA, double numberB, string expectedMessage
            )
        {
            //arrange - ������� ����������

            //act - �������� ����� 
            Exception ex = Assert.Throws(typeof(OverflowException),
                () => _hw1.CalculateTheRemainderOfTheDivision(numberA, numberB));

            //assert - ��������� ����������
            Assert.AreEqual(expectedMessage, ex.Message);
        }

        [TestCase(2, 3, 2, -0.5)]
        [TestCase(-5, 2, 2, 0)]
        public void SolveLinearEquationTest(double numberA, double numberB,
          double numberC, double expectedResult)
        {
            //arrange - ������� ����������

            //act - �������� ����� 
            double actualResult = _hw1.SolveLinearEquation(numberA, numberB, numberC);

            //assert - ��������� ����������
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(0, 1, 2,
             " ����� A �� ������ ���� ����� ����, ��� ��� ������� �������� �����" +
                    "� ����� ������ ����� ������ �� ���������� �� -Inf �� +Inf")]
        public void SolveLinearEquationNegativeTest(
            double numberA, double numberB, double numberC, string expectedMessage
            )
        {
            //arrange - ������� ����������

            //act - �������� ����� 
            Exception ex = Assert.Throws(typeof(OverflowException),
                () => _hw1.SolveLinearEquation(numberA, numberB, numberC));

            //assert - ��������� ����������
            Assert.AreEqual(expectedMessage, ex.Message);
        }

        [TestCase(2, 4, 1, 5, 2)]
        public void SearchForTheCoefficientAOfTheEquationOfTheStraightLineTest(
            double x1, double x2,
          double y1, double y2, double expectedResult)
        {
            //arrange - ������� ����������

            //act - �������� ����� 
            double actualResult = _hw1.SearchForTheCoefficientAOfTheEquationOfTheStraightLine(
                x1, x2, y1, y2);

            //assert - ��������� ����������
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(1, 1, 2, 3, 
             " ����� x1 �� ������ ���� ����� x2")]
        public void SearchForTheCoefficientAOfTheEquationOfTheStraightLineNegativeTest(
            double x1, double x2, double y1, double y2, string expectedMessage
            )
        {
            //arrange - ������� ����������

            //act - �������� ����� 
            Exception ex = Assert.Throws(typeof(OverflowException),
                () => _hw1.SearchForTheCoefficientAOfTheEquationOfTheStraightLine(
                    x1, x2, y1, y2));

            //assert - ��������� ����������
            Assert.AreEqual(expectedMessage, ex.Message);
        }

        [TestCase(2, 2, 4, 0)]
        public void SearchForTheCoefficientBOfTheEquationOfTheStraightLineTest(
            double A, double x1, double y1, double expectedResult)
        {
            //arrange - ������� ����������

            //act - �������� ����� 
            double actualResult = _hw1.SearchForTheCoefficientBOfTheEquationOfTheStraightLine(
                A, x1, y1);

            //assert - ��������� ����������
            Assert.AreEqual(expectedResult, actualResult);
=======
            int actualResult = _hw1.CalculateTheWholePartOfTheDivision(numberA, numberB);

            //assert - ��������� ����������
            Assert.AreEqual(expectedResult, actualResult);
            
>>>>>>> 702b390ac91cf9ac014bedcb4a87b245e9115d40
        }
    }
}