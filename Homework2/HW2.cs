using Core;
using System;

namespace Homework2
{
    public class HW2
    {
        private readonly Helper _helper;

        public HW2()
        {
            _helper = new Helper();
        }
        public void SolveTask1()
        {
            Console.WriteLine("Пользователь вводит 2 числа (A и B). " +
                "Если A>B, подсчитать A+B, если A=B, подсчитать A*B, если A<B, " +
                "подсчитать A-B.\n");
            int A = GetNumberFromUser("Введите число А: ");
            int B = GetNumberFromUser("Введите число В: ");

            int result = CalculateTheValuesDependingOnTheEnteredNumbers(A, B);
            Console.WriteLine($"Результат задачи 1, домашки 2: \n {result}");
        }

        public int GetNumberFromUser(string message)
        {
            Console.WriteLine(message);
            int userNumber = Convert.ToInt32(Console.ReadLine());
            return userNumber;
        }

        public int CalculateTheValuesDependingOnTheEnteredNumbers(int A, int B)
        {
            int result;
            if (A > B)
                result = A + B;
            else if (A == B)
                result = A * B;
            else
                result = A - B;

            return result;
        }

        public void SolveTask2()
        {
            Console.WriteLine("Пользователь вводит 2 числа (X и Y). " +
                "Определить какой четверти принадлежит точка с координатами (X,Y).\n");
            int X = GetNumberFromUser("Введите число X: ");
            int Y = GetNumberFromUser("Введите число Y: ");

            int numberQuarter = DetermineThePositionOnTheCoordinatePlane(X, Y);
            string result = ConvertNumbersFromConditionsToAString(numberQuarter);
            Console.WriteLine($"Результат задачи 2, домашки 2: \n {result}");
            Console.WriteLine($"Точка имеет координаты ({X}, {Y}), " +
                $"а значит расположена {result}");
        }

        public int DetermineThePositionOnTheCoordinatePlane(int X, int Y)
        {
            int quarter;
            if (X > 0 && Y > 0)
                quarter = 1;
            else if (X < 0 && Y > 0)
                quarter = 2;
            else if (X < 0 && Y < 0)
                quarter = 3;
            else if (X > 0 && Y < 0)
                quarter = 4;
            else if (X == 0 && Y != 0)
                quarter = 11;
            else if (X != 0 && Y == 0)
                quarter = 22;
            else 
                quarter = 0;

            return quarter;
        }

        public string ConvertNumbersFromConditionsToAString (int numberFromCondition)
        {
                string stringFromNumber = numberFromCondition switch
            {
                1 => "в 1 четверти",
                2 => "в 2 четверти",
                3 => "в 3 четверти",
                4 => "в 4 четверти",
                11 => "на оси Y",
                22 => "на оси X",
                0 => "в центре",
                _ => "данное число получено не из предыдущего условия :D",
            };

            return stringFromNumber;
        }

        public void SolveTask3()
        {
            Console.WriteLine("Пользователь вводит 3 числа (A, B и С). " +
                "Выведите их в консоль в порядке возрастания.\n");
            int A = GetNumberFromUser("Введите число А: ");
            int B = GetNumberFromUser("Введите число В: ");
            int C = GetNumberFromUser("Введите число C: ");
            string result = "";
            result = OutputAscending(ref result, A, B, C);
            result = OutputAscending(ref result, B, A, C);
            result = OutputAscending(ref result, C, A, B);

            Console.WriteLine($"Результат задачи 3, домашки 2: \n {result}");
        }

        public string OutputAscending(ref string result, int num1, int num2, int num3)
        {
            if (result=="" && num1 <= num2 && num1 <= num3)
            {
                if (num2 <= num3)
                    result = $" {num1}, {num2}, {num3}";
                else result = $" {num1}, {num3}, {num2}";
            }
            return result;

        }

        public void SolveTask4()
        {
            Console.WriteLine("Пользователь вводит 3 числа (A, B и С). " +
                "Выведите в консоль решение(значения X) квадратного уравнения " +
                "стандартного вида, где AX^2+BX+C=0.\n");
            int A = GetNumberFromUser("Введите число А: ");
            int B = GetNumberFromUser("Введите число В: ");
            int C = GetNumberFromUser("Введите число C: ");

            Console.WriteLine($"Результат задачи 4, домашки 2: \n");
            double [] result = SolveQuadraticEquation(A, B, C);
            if (result.Length == 0)
               Console.WriteLine("Корней нет");
            else
            {
                foreach (var item in result)
                {
                    Console.WriteLine($"Корень: {item}");
                }
            }
            
        }

       
        public double[] SolveQuadraticEquation (int A, int B, int C) 
        {
            if (A == 0)
            {
                throw new ArgumentException("Число А не должно быть равно 0, иначе это не " +
                    "квадратное уравнение");
            }
            double D = B * B - 4 * A * C;
            double[] result;
            if (D > 0)
            {
                result = new double[] { 
                    (-B + Math.Sqrt(D))*1.0 / (2 * A), 
                    (-B - Math.Sqrt(D))*1.0 / (2 * A) };
            }
            else if (D == 0)
            {
                result = new double[] { (-B*1.0 / (2 * A)) };
            }
            else 
            { 
                result = Array.Empty<double>(); 
            }

            return result;

        }
        /*
        public double[] CalculateIfTheDiscriminantIsEqualsZero(double B, double A)
        {
            if (A == 0)
            {
                throw new ArgumentException("Число А не должно быть равно 0, иначе это не " +
                    "квадратное уравнение");
            }
            double[] rootX = { -B / (2 * A) };
            return rootX;
        }
        public double[] CalculateIfTheDiscriminantIsGreaterThanZero(double D, double B, double A)
        {
            if (A == 0)
            {
                throw new ArgumentException("Число А не должно быть равно 0, иначе это не " +
                    "квадратное уравнение");
            }
            double firstRootX = (-B + Math.Sqrt(D)) / (2 * A);
            double secondRootX = (-B - Math.Sqrt(D)) / (2 * A);
            double[] roots = { firstRootX, secondRootX };
            return roots;
        }
        */
        public void SolveTask5()
        {
            Console.WriteLine("Пользователь вводит двузначное число. " +
                "Выведите в консоль прописную запись этого числа. " +
                "Например при вводе “25” в консоль будет выведено “двадцать пять”.\n");
            int userTwoDigitNumber = GetNumberFromUser("Введите число: ");
            

            string result = WriteATwoDigitNumberInWords(userTwoDigitNumber);
            Console.WriteLine($"Результат задачи 5, домашки 2: \n{result}");
        }
        public string WriteATwoDigitNumberInWords (int number)
        {
            int dozens = number / 10;
            int units = number % 10;
            string wordTwoDigitNumber;

            if (dozens >= 2 && dozens < 10)
            {
                wordTwoDigitNumber = $"{WriteADozens(dozens)} {WriteAUnits(units)}";
            }
            else if (dozens == 1)
            {
                wordTwoDigitNumber = $"{WriteTillTwenty(number)}";
            }
            else wordTwoDigitNumber = "Число не двузначное";

            return wordTwoDigitNumber;
        }

        public string WriteADozens(int dozens)
        {
            string dozenWord;
            if (dozens > 9 || dozens < 2)
            {
                throw new ArgumentException("Число не из главного метода");
            }
            dozenWord = dozens switch
            {
                2 => "двадцать",
                3 => "тридцать",
                4 => "сорок",
                5 => "пятьдесят",
                6 => "шестьдесят",
                7 => "семьдесят",
                8 => "восемьдесят",
                9 => "девяносто",
                _ => "",
            };
            return dozenWord;
        }

        public string WriteAUnits(int units)
        {
            if (units < 0 || units > 9)
            {
                throw new ArgumentException("Число не из главного метода");
            }
            string unitsWord;
            unitsWord = units switch
            {
                1 => "один",
                2 => "два",
                3 => "три",
                4 => "четыре",
                5 => "пять",
                6 => "шесть",
                7 => "семь",
                8 => "восемь",
                9 => "девять",
                _ => "",
            };
            return unitsWord;
        }

        public string WriteTillTwenty(int number)
        {
            if (number < 10 || number > 19)
            {
                throw new ArgumentException("Число не из главного метода");
            }
            string wordTillTwenty = number switch
            {
                10 => "десять",
                11 => "одиннадцать",
                12 => "двенадцать",
                13 => "тринадцать",
                14 => "четырнадцать",
                15 => "пятнадцать",
                16 => "шестнадцать",
                17 => "семнадцать",
                18 => "восемнадцать",
                19 => "девятнадцать",
                _ => "",
            };
            return wordTillTwenty;
        }
    }
}
