using System;

namespace Homework2
{
    public class HW2
    {
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

            string result = DetermineThePositionOnTheCoordinatePlane(X, Y);
            Console.WriteLine($"Результат задачи 2, домашки 2: \n {result}");
        }

        public string DetermineThePositionOnTheCoordinatePlane(int X, int Y)
        {
            string quarter = "1";
            if (X > 0 && Y > 0)
                quarter = "в 1 четверти";
            else if (X < 0 && Y > 0)
                quarter = "в 2 четверти";
            else if (X < 0 && Y < 0)
                quarter = "в 3 четверти";
            else if (X > 0 && Y < 0)
                quarter = "в 4 четверти";
            else if (X == 0 && Y != 0)
                quarter = "на оси Y";
            else if (X != 0 && Y == 0)
                quarter = "на оси X";

            return $"Точка имеет координаты ({X}, {Y}), " +
                $"а значит расположена {quarter}";
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
            

            if (result=="" && num1 <= num2 && num1 <= num2)
            {
                if (num2 <= num3)
                    result = $" {num1}, {num2}, {num3}";
                else result = $" {num1}, {num3}, {num2}";
            }
            return result;
            ;
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
            SolveQuadraticEquation(A, B, C);
        }

       
        public void SolveQuadraticEquation (int A, int B, int C) 
        {
            double D = B * B - 4 * A * C;
            
            if (D > 0)
            {
                CalculateIfTheDiscriminantIsGreaterThanZero(D, B, A);
            }
            else if (D == 0)
            {
                CalculateIfTheDiscriminantIsEqualsZero(B, A);
            }
            else CalculateIfTheDiscriminantIsLessThanZero(D);

            
        }

        public void CalculateIfTheDiscriminantIsLessThanZero( double D)
        {
            Console.WriteLine($"{D} < 0, значит уравнение не имеет решений "); 
        }
        public void CalculateIfTheDiscriminantIsEqualsZero(double B, double A)
        {
            double rootX = -B / (2 * A);
            Console.WriteLine($"Дискриминант = 0, значит уравнение имеет один корень - {rootX}");
        }
        public void CalculateIfTheDiscriminantIsGreaterThanZero(double D, double B, double A)
        {
            double firstRootX = (-B + Math.Sqrt(D)) / (2 * A);
            double secondRootX = (-B - Math.Sqrt(D)) / (2 * A);
            Console.WriteLine($"{D} > 0, значит уравнение имеет два корня. " +
                $"Первый: {firstRootX}, второй: { secondRootX}");
        }
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
            else wordTwoDigitNumber = "Зайди правильно!!!!!";

            return wordTwoDigitNumber;
        }

        public string WriteADozens(int dozens)
        {
            string dozenWord;
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
            string unitsWord;
            unitsWord = units switch
            {
                0 => "",
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
