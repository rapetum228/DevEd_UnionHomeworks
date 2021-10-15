using System;

namespace Homework1
{
    public class HW1
    {
        public void SolveTask1()
        {
            double A = GetNumberFromUser("Введите число А: ");
            double B = GetNumberFromUser("Введите число В: ");
            try 
            { 
                double result = FindASolutionUsingTheFormula(A, B);
                Console.WriteLine($"Результат задачи 1, домашки 1: {result}");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            
        }

        public double GetNumberFromUser(string message)
        {
            Console.WriteLine(message);
            double userNumber = Convert.ToDouble(Console.ReadLine());
            return userNumber;
        }
        public double FindASolutionUsingTheFormula(double numberA, double numberB)
        {
            if (numberA == numberB)
            {
                throw new DivideByZeroException("Ошибка. Деление на ноль..." +
                    " Числа не должны быть равны");
            }
            double calcRes = (5 * numberA + Math.Pow(numberB, 2)) 
                / (numberB - numberA);
            return calcRes;
        }

        public void SolveTask2()
        {
            double A = GetNumberFromUser("Введите число А: ");
            double B = GetNumberFromUser("Введите число В: ");
            double[] result = SwapTheVariables(A, B);
            Console.WriteLine($"Результат задачи 2, домашки 1: \n" +
                $"Число А теперь: {result[0]}, число B: {result[1]}");
        }

        public double[] SwapTheVariables (double A, double B)
        {
            double copyA = A;
            A = B;
            B = copyA;
            double[] result = { A, B };
            return result;
        }

        public void SolveTask3()
        {
            double A = GetNumberFromUser("Введите число А: ");
            double B = GetNumberFromUser("Введите число В: ");
            try
            {
                int resultDivision = CalculateTheWholePartOfTheDivision(A, B);
                int remainder = CalculateTheRemainderOfTheDivision(A, B);
                Console.WriteLine($"Результат задачи 3, домашки 1: \n" +
                $"Результат деления: {resultDivision}, остаток: {remainder}");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            
            
        }

        public int CalculateTheWholePartOfTheDivision(double A, double B)
        {
            if (B == 0)
            {
                throw new DivideByZeroException("Ошибка. Деление на ноль..." +
                    " Число В не должно быть равно нулю...");
            }
            int result = (int)Math.Floor(A / B);
            return result;
        }
        public int CalculateTheRemainderOfTheDivision(double A, double B)
        {
            int result = Convert.ToInt32(A % B);
            return result;
        }

        public void SolveTask4()
        {
            Console.WriteLine("Пользователь вводит 3 не равных 0 числа (A, B и С). " +
                "Выведите в консоль решение(значение X) линейного уравнения " +
                "стандартного вида, где A*X+B=C.\n");
            double A = GetNumberFromUser("Введите число А: ");
            double B = GetNumberFromUser("Введите число В: ");
            double C = GetNumberFromUser("Введите число C: ");
            try
            {
                double resultX = SolveLinearEquation(A, B, C);
                Console.WriteLine($"Результат задачи 4, домашки 1: \n" +
                    $"Решение уравнения: {resultX}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public double SolveLinearEquation (double A, double B, double C)
        {
            if (A == 0 )
            {
                throw new DivideByZeroException("Ошибка. Деление на ноль..." +
                    " Число A не должно быть равно нулю, так как область значения корня" +
                    "в таком случае будет лежать на промежутке от -Inf до +Inf");
            }
            double result = (C - B) / A;
            return result;
        }

        public void SolveTask5()
        {
            Console.WriteLine("Пользователь вводит 4 числа (X1, Y1, X2, Y2), " +
                "описывающие координаты 2-х точек на координатной плоскости. " +
                "Выведите уравнение прямой в формате Y=AX+B, " +
                "проходящей через эти точки.\n");
            double X1 = GetNumberFromUser("Введите число X1: ");
            double X2 = GetNumberFromUser("Введите число X2: ");
            double Y1 = GetNumberFromUser("Введите число Y1: ");
            double Y2 = GetNumberFromUser("Введите число Y2: ");

            double A = SearchForTheCoefficientAOfTheEquationOfTheStraightLine(X1, X2, Y1, Y2);
            double B = SearchForTheCoefficientBOfTheEquationOfTheStraightLine(A, X1, Y1);
            Console.WriteLine($"Результат задачи 5, домашки 1: \n" +
                $"Уравнение: {A}*X + {B}");
        }

        public double SearchForTheCoefficientAOfTheEquationOfTheStraightLine(
            double x1, double x2, double y1, double y2
            )
        {
            double A = (y2 - y1) / (x2 - x1);
            double B = -A * x1 + y1;
            return A;
        }

        public double SearchForTheCoefficientBOfTheEquationOfTheStraightLine(
            double A, double x1, double y1
            )
        {
            double B = -A * x1 + y1;
            return B;
        }
    }
}
