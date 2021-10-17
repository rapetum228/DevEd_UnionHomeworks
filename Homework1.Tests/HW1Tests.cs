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

        [Test]
        public void Test2()
        {
            Assert.Pass();
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
    }
}