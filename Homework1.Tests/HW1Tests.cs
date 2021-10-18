using NUnit.Framework;
using System;

namespace Homework1.Tests
{
    public class HW1Tests
    {
        private HW1 _hw1;
        [SetUp] //атрибуты - данные от данных (метаданные)
                //помогают правильно описать методы
        public void Setup() //выполняется перед каждым тестом
        {
            _hw1 = new HW1();
        }

        [TestCase(5, 9, 26.5)]
        public void FindASolutionUsingTheFormulaTest(double numberA, double numberB, 
            double expectedResult)
        {
            //arrange - готовим переменные

            //act - вызываем метод 
            double actualResult = _hw1.FindASolutionUsingTheFormula(numberA, numberB);

            //assert - проверяем результаты
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestCase(5, 5,
            "Ошибка. Деление на ноль... Числа не должны быть равны")]
        public void FindASolutionUsingTheFormulaNegativeTest(
            double numberA, double numberB, string expectedMessage
            )
        {
            //arrange - готовим переменные

            //act - вызываем метод 
            Exception ex = Assert.Throws(typeof(DivideByZeroException), 
                () => _hw1.FindASolutionUsingTheFormula(numberA, numberB));

            //assert - проверяем результаты
            Assert.AreEqual(expectedMessage, ex.Message);
        }

        [TestCase(5, 9, 9)]
        public void SwapTheVariablesTest(double numberA, double numberB,
            double expectedResultA)
        {
            //arrange - готовим переменные

            //act - вызываем метод 
            _hw1.SwapTheVariables(ref numberA, ref numberB);

            //assert - проверяем результаты
            Assert.AreEqual(expectedResultA, numberA);
        }

        [TestCase(5, 5,
            "Ошибка. Деление на ноль... Числа не должны быть равны")]
        public void FindASolutionUsingTheFormulaNegativeTest(
            double numberA, double numberB, string expectedMessage
            )
        {
            //arrange - готовим переменные

            //act - вызываем метод 
            Exception ex = Assert.Throws(typeof(DivideByZeroException), 
                () => _hw1.FindASolutionUsingTheFormula(numberA, numberB));

            //assert - проверяем результаты
            Assert.AreEqual(expectedMessage, ex.Message);
        }

        [TestCase(2, 3, 0)]
        [TestCase(-6, -3, 2)]
        [TestCase(0, 3, 0)]
        [TestCase(7, 3, 2)]
        public void CalculateTheWholePartOfTheDivisionTest(double numberA, double numberB,
           int expectedResult)
        {
            //arrange - готовим переменные

            //act - вызываем метод 
            int actualResult = _hw1.CalculateTheWholePartOfTheDivision(numberA, numberB);

            //assert - проверяем результаты
            Assert.AreEqual(expectedResult, actualResult);
        }

<<<<<<< HEAD
        [TestCase(5, 0,
            "Ошибка. Деление на ноль... Число В не должно быть равно нулю...")]
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
            //arrange - готовим переменные

            //act - вызываем метод 
<<<<<<< HEAD
            Exception ex = Assert.Throws(typeof(OverflowException),
                () => _hw1.CalculateTheWholePartOfTheDivision(numberA, numberB));

            //assert - проверяем результаты
            Assert.AreEqual(expectedMessage, ex.Message);
        }

        [TestCase(2, 3, 2)]
        [TestCase(-6, -3, 0)]
        [TestCase(0, 3, 0)]
        [TestCase(7, 3, 1)]
        public void CalculateTheRemainderOfTheDivisionTest(double numberA, double numberB,
           int expectedResult)
        {
            //arrange - готовим переменные

            //act - вызываем метод 
            int actualResult = _hw1.CalculateTheRemainderOfTheDivision(numberA, numberB);

            //assert - проверяем результаты
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(5, 0,
            "Ошибка. Деление на ноль... Число В не должно быть равно нулю...")]
        public void CalculateTheRemainderOfTheDivisionNegativeTest(
            double numberA, double numberB, string expectedMessage
            )
        {
            //arrange - готовим переменные

            //act - вызываем метод 
            Exception ex = Assert.Throws(typeof(OverflowException),
                () => _hw1.CalculateTheRemainderOfTheDivision(numberA, numberB));

            //assert - проверяем результаты
            Assert.AreEqual(expectedMessage, ex.Message);
        }

        [TestCase(2, 3, 2, -0.5)]
        [TestCase(-5, 2, 2, 0)]
        public void SolveLinearEquationTest(double numberA, double numberB,
          double numberC, double expectedResult)
        {
            //arrange - готовим переменные

            //act - вызываем метод 
            double actualResult = _hw1.SolveLinearEquation(numberA, numberB, numberC);

            //assert - проверяем результаты
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(0, 1, 2,
             " Число A не должно быть равно нулю, так как область значения корня" +
                    "в таком случае будет лежать на промежутке от -Inf до +Inf")]
        public void SolveLinearEquationNegativeTest(
            double numberA, double numberB, double numberC, string expectedMessage
            )
        {
            //arrange - готовим переменные

            //act - вызываем метод 
            Exception ex = Assert.Throws(typeof(OverflowException),
                () => _hw1.SolveLinearEquation(numberA, numberB, numberC));

            //assert - проверяем результаты
            Assert.AreEqual(expectedMessage, ex.Message);
        }

        [TestCase(2, 4, 1, 5, 2)]
        public void SearchForTheCoefficientAOfTheEquationOfTheStraightLineTest(
            double x1, double x2,
          double y1, double y2, double expectedResult)
        {
            //arrange - готовим переменные

            //act - вызываем метод 
            double actualResult = _hw1.SearchForTheCoefficientAOfTheEquationOfTheStraightLine(
                x1, x2, y1, y2);

            //assert - проверяем результаты
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(1, 1, 2, 3, 
             " Число x1 не должно быть равно x2")]
        public void SearchForTheCoefficientAOfTheEquationOfTheStraightLineNegativeTest(
            double x1, double x2, double y1, double y2, string expectedMessage
            )
        {
            //arrange - готовим переменные

            //act - вызываем метод 
            Exception ex = Assert.Throws(typeof(OverflowException),
                () => _hw1.SearchForTheCoefficientAOfTheEquationOfTheStraightLine(
                    x1, x2, y1, y2));

            //assert - проверяем результаты
            Assert.AreEqual(expectedMessage, ex.Message);
        }

        [TestCase(2, 2, 4, 0)]
        public void SearchForTheCoefficientBOfTheEquationOfTheStraightLineTest(
            double A, double x1, double y1, double expectedResult)
        {
            //arrange - готовим переменные

            //act - вызываем метод 
            double actualResult = _hw1.SearchForTheCoefficientBOfTheEquationOfTheStraightLine(
                A, x1, y1);

            //assert - проверяем результаты
            Assert.AreEqual(expectedResult, actualResult);
=======
            int actualResult = _hw1.CalculateTheWholePartOfTheDivision(numberA, numberB);

            //assert - проверяем результаты
            Assert.AreEqual(expectedResult, actualResult);
            
>>>>>>> 702b390ac91cf9ac014bedcb4a87b245e9115d40
        }
    }
}