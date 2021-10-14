using System;

namespace Homework1
{
    public class HW1
    {
        public void SolveTask1()
        {
            double A = GetNumberFromUser("Введите число А: ");
            double B = GetNumberFromUser("Введите число В: ");
            double result = CalcFormula(A, B);
            Console.WriteLine($"Результат задачи 1, домашки 1: {result}");
        }

        public double GetNumberFromUser(string message)
        {
            Console.WriteLine(message);
            double userNumber = Convert.ToDouble(Console.ReadLine());
            return userNumber;
        }
        public double CalcFormula(double numberA, double numberB)
        {
            double calcRes = (5 * numberA + Math.Pow(numberB, 2)) 
                / (numberB - numberA);
            return calcRes;
        }

        public void SolveTask2()
        {
            double A = GetNumberFromUser("Введите число А: ");
            double B = GetNumberFromUser("Введите число В: ");
            double[] result = SwapVariables(A, B);
            Console.WriteLine($"Результат задачи 2, домашки 1: \n" +
                $"Число А теперь: {result[0]}, число B: {result[1]}");
        }

        public double[] SwapVariables (double A, double B)
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
            int resultDivision = DivisionNumber(A, B);
            int remainder = CalcRemainder(A, B);
            Console.WriteLine($"Результат задачи 3, домашки 1: \n" +
                $"Результат деления: {resultDivision}, остаток: {remainder}");
        }

        public int DivisionNumber (double A, double B)
        {
            int result = (int)Math.Floor(A / B);
            return result;
        }
        public int CalcRemainder(double A, double B)
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
            double resultX = SolveLinearEquation( A, B, C);
            Console.WriteLine($"Результат задачи 4, домашки 1: \n" +
                $"Решение уравнения: {resultX}");
        }

        public double SolveLinearEquation (double A, double B, double C)
        {
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

            string result = EquationOfAStraightLine(X1, X2, Y1, Y2);
            Console.WriteLine($"Результат задачи 5, домашки 1: \n" +
                $"Уравнение: {result}");
        }

        public string EquationOfAStraightLine(double x1, double x2, double y1, double y2)
        {
            double A = (y2 - y1) / (x2 - x1);
            double B = -A * x1 + y1;
            return $"Y = {A}*X + {B}";
        }


    }
}
