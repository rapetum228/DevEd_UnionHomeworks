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
            //arrange - готовим переменные

            //act - вызываем метод 
            int actualResult = _hw1.CalculateTheWholePartOfTheDivision(numberA, numberB);

            //assert - проверяем результаты
            Assert.AreEqual(expectedResult, actualResult);
            
        }
    }
}