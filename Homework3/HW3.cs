using System;

namespace Homework3
{
    public class HW3
    {
        public void SolveTask1()
        {
            Console.WriteLine("Пользователь вводит 2 числа (A и B). " +
                "Возвести число A в степень B.\n");
            int A = GetNumberFromUser("Введите число А: ");
            int B = GetNumberFromUser("Введите число В: ");

            int result = NumberOfThePower(A, B);
            Console.WriteLine($"Результат задачи 1, домашки 3: \n {result}");
        }

        public int GetNumberFromUser(string message)
        {
            Console.WriteLine(message);
            int userNumber = Convert.ToInt32(Console.ReadLine());
            return userNumber;
        }
        public int NumberOfThePower(int A, int B)
        {
            int result = 1;
            for (int i = 0; i < B; i++)
                result *= A;
            return result;
        }

        public void SolveTask2()
        {
            Console.WriteLine("Пользователь вводит 1 число (A). " +
                "Вывести все числа от 1 до 1000, которые делятся на A.\n");
            int A = GetNumberFromUser("Введите число А: ");
            Console.WriteLine($"Результат задачи 2, домашки 2: \n");
            DivisionByA(A);
            
        }
        public void DivisionByA(int number)
        {
            int dividedByA;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % number == 0)
                {
                    dividedByA = i;
                    Console.WriteLine($"Число {dividedByA} делится " +
                        $"на {number} с результатом {i / number}");
                }
            }
        }

        public void SolveTask3()
        {
            Console.WriteLine("Пользователь вводит 1 число (A). " +
                "Найдите количество положительных целых " +
                "чисел, квадрат которых меньше A.\n");
            int A = GetNumberFromUser("Введите число А: ");


            int result = CalculatingTheNumbersLessSquarA(A);
            Console.WriteLine($"Результат задачи 3, домашки 3: \n {result}");
        }
        public int CalculatingTheNumbersLessSquarA (int number)
        {
            int squaredNumberLessA = 1;
            while (squaredNumberLessA * squaredNumberLessA < number)
                squaredNumberLessA++;
            return squaredNumberLessA;
        }

        public void SolveTask4()
        {
            Console.WriteLine("Пользователь вводит 1 число (A). " +
                "Вывести наибольший делитель (кроме самого A) числа A" + "\n");
            int A = GetNumberFromUser("Введите число А: ");

            int result = CalcGreatDividerA(A);
            Console.WriteLine($"Результат задачи 4, домашки 3: \n {result}");
        }

        public int CalcGreatDividerA(int number)
        {
            int dividerA = 0;

            for (int i = number - 1; i > 0; i--)
            {
                if (number % i == 0 && number != i)
                {
                    dividerA = i;
                    break;
                }
            }

            return dividerA;
        }

        public void SolveTask5()
        {
            Console.WriteLine("Пользователь вводит 2 числа (A и B). " +
                "Вывести сумму всех чисел из диапазона от A до B, " +
                "которые делятся без остатка на 7. " +
                "(Учтите, что при вводе B может оказаться меньше A)" + "\n");

            int A = GetNumberFromUser("Введите число А: ");
            int B = GetNumberFromUser("Введите число B: ");
            int[] range = SearchForRangeBoundaries(A, B);
            int result = SumOfNumbersDividedBySeven(range[0], range[1]);
            Console.WriteLine($"Результат задачи 5, домашки 3: \n {result}");
        }

        public int[] SearchForRangeBoundaries(int numberA, int numberB)
        {
            int[] range = new int[2];
            
            if (numberA < numberB)
            {
                range[0] = numberA;
                range[1] = numberB;
            }
            else
            {
                range[0] = numberB;
                range[1] = numberA;
            }
            return range;
        }

        public int SumOfNumbersDividedBySeven(int rangeStart, int rangeEnd)
        {
            int sumDividedBySeven=0;
            for (int i = rangeStart; i <= rangeEnd; i++)
            {
                if (i % 7 == 0)
                    sumDividedBySeven += i;
            }
            return sumDividedBySeven;
        }

        public void SolveTask6()
        {
            Console.WriteLine("Пользователь вводит 1 число (N). " +
                "Выведите N-ое число ряда фибоначчи. " +
                "В ряду фибоначчи каждое следующее число является суммой двух предыдущих. " +
                "Первое и второе считаются равными 1. \n");
            int N = GetNumberFromUser("Введите число N: ");

            int result = CalcNumberFibonacci(N);
            Console.WriteLine($"Результат задачи 6, домашки 3: \n {result}");
        }

        public int CalcNumberFibonacci(int number)
        {
            int firstPrev = 1;
            int secondPrev = 1;
            int numberFibonacci = 0;

            while (numberFibonacci < number - firstPrev)
            {
                numberFibonacci = firstPrev + secondPrev;
                firstPrev = secondPrev;
                secondPrev = numberFibonacci;
            }

            return numberFibonacci;
        }

        public void SolveTask7()
        {
            Console.WriteLine("Пользователь вводит 2 числа. " +
                "Найти их наибольший общий делитель используя алгоритм Евклида.\n");

            int firstNum = GetNumberFromUser("Введите первое число: ");
            int secondNum = GetNumberFromUser("Введите второе число: ");
            int[] maxAndMin = SearchMaxAndMin(firstNum, secondNum);

            int result = CalcNODEvclid(maxAndMin[0], maxAndMin[1]);
            Console.WriteLine($"Результат задачи 7, домашки 3: \n {result}");
        }

        public int[] SearchMaxAndMin(int firstNum, int secondNum)
        {
            int[] minMax = new int[2];

            if (firstNum < secondNum)
            {
                minMax[0] = firstNum;
                minMax[1] = secondNum;
            }
            else
            {
                minMax[0] = secondNum;
                minMax[1] = firstNum;
            }
            return minMax;
        }

        public int CalcNODEvclid(int min, int max)
        {
            int remainder;
            while (max % min != 0)
            {
                remainder = max % min;
                max = min;
                min = remainder;
            }
            return min;
        }

        public void SolveTask8()
        {
            Console.WriteLine("Пользователь вводит целое положительное число, " +
                "которое является кубом целого числа N. " +
                "Найдите число N методом половинного деления.\n");

            int N = GetNumberFromUser("Bведите число, являющееся " +
                "кубом какого-то целого числа: ");

            int result = CalcWithHalfDivisionMethod(N);
            Console.WriteLine($"Результат задачи 8, домашки 3: \n {result}");
        }

        public int CalcWithHalfDivisionMethod(int number)
        {
            double start, end, middle;
            start = 0;
            end = 1.0 * number;
            middle = 0;
            int result;

            while (Math.Abs(middle * middle * middle - number) > 0.00001)
            {
                middle = start + (end - start) / 2;

                if (middle * middle * middle > number)
                    end = middle;
                else
                    start = middle;
            }

            result = (int)Math.Round(middle);
            return result;
        }

        public void SolveTask9()
        {
            Console.WriteLine("Пользователь вводит 1 число. " +
                "Найти количество нечетных цифр этого числа.\n");

            int N = GetNumberFromUser("Bведите число: ");

            int result = CalcOddNumber(N);
            Console.WriteLine($"Результат задачи 9, домашки 3: \n {result}");
        }

        public int CalcOddNumber(int number)
        {
            int remainder = 0;
            int counter = 0;
            while (number != 0)
            {
                remainder = number % 10;
                number /= 10;
                if (remainder % 2 == 1)
                    counter++;
            }
            return counter;
        }

        public void SolveTask10()
        {
            Console.WriteLine("Пользователь вводит 1 число. Найти число, которое является " +
                "зеркальным отображением последовательности цифр заданного числа, " +
                "например, задано число 123, вывести 321. \n");

            int N = GetNumberFromUser("Bведите число: ");

            int result = CalcMirrorImageOfNumber(N);
            Console.WriteLine($"Результат задачи 10, домашки 3: \n {result}");
        }

        public int CalcMirrorImageOfNumber(int userNum)
        {
            int remainder = 0;
            int counter = 0;
            while (userNum != 0)
            {
                remainder = userNum % 10;
                userNum /= 10;
                counter = counter * 10 + remainder;
            }
            return counter;
        }

        public void SolveTask11()
        {
            Console.WriteLine("Пользователь вводит целое положительное  число (N). " +
                "Выведите числа в диапазоне от 1 до N, сумма четных цифр которых " +
                "больше суммы нечетных. \n");

            int N = GetNumberFromUser("Bведите число: ");
            Console.WriteLine($"Результат задачи 11, домашки 3: \n");
            CalcNumbersSumEvenGreaterOdd(N);
            
        }

        public void CalcNumbersSumEvenGreaterOdd(int userNum)
        {
            int remainder = 0;
            for (int i = 1; i <= userNum; i++)
            {
                int counterEven = 0;
                int counterOdd = 0;
                int iCopy = i;
                while (iCopy != 0)
                {
                    remainder = iCopy % 10;
                    iCopy /= 10;
                    if (remainder % 2 == 1)
                        counterOdd += remainder;
                    else counterEven += remainder;
                }
                if (counterEven > counterOdd)
                    Console.WriteLine($"Число {i}. Cумма чётных - {counterEven}" +
                        $", сумма нечётных - {counterOdd}");
            }
        }

        public void SolveTask12()
        {
            Console.WriteLine("Пользователь вводит 2 числа. Сообщите, есть ли " +
                "в написании двух чисел одинаковые цифры. Например, для пары 123 и 3456789, " +
                "ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ” \n");

            int firstNumber = GetNumberFromUser("Bведите первое число: ");
            int secondNumber = GetNumberFromUser("Введите второе число: ");
            bool fLag = SearchEqualDigits(firstNumber, secondNumber);
            string result = YesOrNo(fLag);
            Console.WriteLine($"Результат задачи 12, домашки 3: \n {result}");
        }

        public bool SearchEqualDigits(int firstNum, int secondNum)
        {
            bool flag = true;
            int remainder1, remainder2;
            while (flag && firstNum != 0)
            {
                int copySecondNum = secondNum;
                remainder1 = firstNum % 10;
                secondNum /= 10;
                while (flag && copySecondNum != 0)
                {
                    remainder2 = copySecondNum % 10;
                    copySecondNum /= 10;
                    if (remainder1 == remainder2)
                        flag = !flag;
                }
            }
            return flag;
        }

        public string YesOrNo(bool flag)
        {
            if (flag)
                return "\nНЕТ";
            else
                return "\nДА";
        }
    }
}
