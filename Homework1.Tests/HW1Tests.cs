using NUnit.Framework;

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

        [Test]
        public void FindASolutionUsingTheFormulaTest()
        {
            //arrange - готовим переменные
            double numberA = 5;
            double numberB = 9;
            double expectedResult = 26.5;

            //act - вызываем метод 
            double actualResult = _hw1.FindASolutionUsingTheFormula(numberA, numberB);

            //assert - проверяем результаты
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Test2()
        {
            Assert.Pass();
        }

        [Test]
        public void Test3()
        {
            Assert.Pass();
        }
    }
}