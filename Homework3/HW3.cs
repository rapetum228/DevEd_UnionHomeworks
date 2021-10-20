using Core;
using System;

namespace Homework3
{
    public class HW3
    {
        private readonly ForArrays _forArrays;

        public HW3()
        {
            _forArrays = new ForArrays();
        }
        public void SolveTask1()
        {
            Console.WriteLine("Пользователь вводит 2 числа (A и B). " +
                "Возвести число A в степень B.\n");
            int A = GetNumberFromUser("Введите число А: ");
            int B = GetNumberFromUser("Введите число В: ");

            double result = RaiseTheNumberToThePower(A, B);
            Console.WriteLine($"Результат задачи 1, домашки 3: \n {result}");
        }

        public int GetNumberFromUser(string message)
        {
            Console.WriteLine(message);
            int userNumber = Convert.ToInt32(Console.ReadLine());
            return userNumber;
        }
        public double RaiseTheNumberToThePower(int A, int B)
        {
            if (A == 0)
                return 0;

            double result = 1;
            if (B < 0)
            {
                for (int i = 0; i < Math.Abs(B); i++)
                    result /= A * 1.0;
            }
            else
            {
                for (int i = 0; i < B; i++)
                    result *= A;
            }
            return result;
        }

        public void SolveTask2()
        {
            Console.WriteLine("Пользователь вводит 1 число (A). " +
                "Вывести все числа от 1 до 1000, которые делятся на A.\n");
            try
            {
                int A = GetNumberFromUser("Введите число А: ");
                int[] result = DivisionByA(A);
                Console.WriteLine($"Результат задачи 2, домашки 2: \n");
                _forArrays.ShowMeAnArrayAnScreen(result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public int[] DivisionByA(int number)
        {
            
            if (number == 0)
            {
                throw new DivideByZeroException("На ноль делить нельзя");
            }
            int indexArr = 0;
            int[] dividedByA = new int[1000 / Math.Abs(number)];
            for (int i = 1; i <= 1000; i++)
            {
                if (i % number == 0)
                {
                    dividedByA[indexArr] = i;
                    indexArr++;
                }
            }

            return dividedByA;
        }

        public void SolveTask3()
        {
            Console.WriteLine("Пользователь вводит 1 число (A). " +
                "Найдите количество положительных целых " +
                "чисел, квадрат которых меньше A.\n");
            int A = GetNumberFromUser("Введите число А: ");

            try
            {
                int result = CalculatingTheNumbersLessSquarA(A);
                Console.WriteLine($"Результат задачи 3, домашки 3: \n {result}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public int CalculatingTheNumbersLessSquarA (int number)
        {
            if (number == 0)
            {
               return 0;
            }
            if (number < 0)
            {
                throw new ArgumentException("Введённое число должно быть положительным");
            }
            int squaredNumberLessA = 0;
            while (squaredNumberLessA * squaredNumberLessA < number)
                squaredNumberLessA++;
            return squaredNumberLessA-1;
        }

        public void SolveTask4()
        {
            Console.WriteLine("Пользователь вводит 1 число (A). " +
                "Вывести наибольший делитель (кроме самого A) числа A" + "\n");
            try
            {
                int A = GetNumberFromUser("Введите число А: ");
                int result = CalcGreatDividerA(A);
                Console.WriteLine($"Результат задачи 4, домашки 3: \n {result}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public int CalcGreatDividerA(int number)
        {
            int dividerA = 0;
            if (Math.Abs(number) <= 1) 
            {
                throw new ArgumentException("Число должно быть по модулю больше единицы");
            }

            for (int i = Math.Abs(number)-1; i > 0; i--)
            {
                if (number % i == 0 && number != i )
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
            int result = SumOfNumbersDividedBySeven(range);
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

        public int SumOfNumbersDividedBySeven(int[] range)
        {
            int sumDividedBySeven=0;
            for (int i = range[0]; i <= range[1]; i++)
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
            if (number < 0)
            {
                firstPrev = -1;
                secondPrev = -1;
            }
            
            int numberFibonacci = 0;

            while ((numberFibonacci <= number - firstPrev) && (number > 0) 
                || (numberFibonacci >= number - firstPrev) && (number < 0))
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
            try
            {
                int result = CalcTheGCDUsingEuclidsAlgorithm(firstNum, secondNum);
                Console.WriteLine($"Результат задачи 7, домашки 3: \n {result}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public int CalcTheGCDUsingEuclidsAlgorithm(int firstNum, int secondNum)
        {
            if (secondNum == 0 || firstNum == 0)
            {
                throw new ArgumentException("Числа должны быть не равны нулю");
            }
            int remainder;
            while (secondNum % firstNum != 0)
            {
                remainder = secondNum % firstNum;
                secondNum = firstNum;
                firstNum = remainder;
            }
            return Math.Abs(firstNum);
        }

        public void SolveTask8()
        {
            Console.WriteLine("Пользователь вводит целое положительное число, " +
                "которое является кубом целого числа N. " +
                "Найдите число N методом половинного деления.\n");

            int N = GetNumberFromUser("Bведите число, являющееся " +
                "кубом какого-то целого числа: ");
            try
            {
                int result = CalcWithHalfDivisionMethod(N);
                Console.WriteLine($"Результат задачи 8, домашки 3: \n {result}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public int CalcWithHalfDivisionMethod(int number)
        {
            if (number > 2580)
                throw new ArgumentException("Число слишком большое, могу посчитать" +
                    " числа не выше 2580");
            else if (number < 0)
                throw new ArgumentException("Число должно быть положительным");
            else if (number == 1)
                return 1;
            int start, end, middle;
            start = 0;
            end = number;
            middle = start + (end - start) / 2;
            int preMiddle = 0;

            int result;

            while (Math.Abs(middle * middle * middle - number) > 0)
            {
                middle = start + (end - start) / 2;
                if (preMiddle == middle)
                {
                    throw new ArgumentException("Данное число не куб целого числа((");
                }
              
                if (middle * middle * middle > number)
                    end = middle;
                else
                    start = middle;
                preMiddle = middle;
            }

            result = middle;
            return result;
        }

        public void SolveTask9()
        {
            Console.WriteLine("Пользователь вводит 1 число. " +
                "Найти количество нечетных цифр этого числа.\n");

            int N = GetNumberFromUser("Bведите число: ");

            int result = CalculateTheNumberOfOddDigitsOfANumber(N);
            Console.WriteLine($"Результат задачи 9, домашки 3: \n {result}");
        }

        public int CalculateTheNumberOfOddDigitsOfANumber(int number)
        {
            int remainder = 0;
            int counter = 0;
            while (number != 0)
            {
                remainder = number % 10;
                number /= 10;
                if (remainder % 2 == 1 || remainder % 2 == -1)
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
            int remainder;
            int mirrorImageOfNumber = 0;
            while (userNum != 0)
            {
                remainder = userNum % 10;
                userNum /= 10;
                mirrorImageOfNumber = mirrorImageOfNumber * 10 + remainder;
            }
            return mirrorImageOfNumber;
        }

        public void SolveTask11()
        {
            Console.WriteLine("Пользователь вводит целое положительное  число (N). " +
                "Выведите числа в диапазоне от 1 до N, сумма четных цифр которых " +
                "больше суммы нечетных. \n");

            int N = GetNumberFromUser("Bведите число: ");
            int[] resultArray = CalcNumbersSumEvenGreaterOdd(N);
            Console.WriteLine($"Результат задачи 11, домашки 3: \n");
            _forArrays.ShowMeAnArrayAnScreen(resultArray);
        }

        public int[] CalcNumbersSumEvenGreaterOdd(int userNum)
        {
            if (userNum < 0)
                throw new ArgumentException("Число должно быть положительным");
            int[] result = new int[userNum];
            int arrLenght = userNum;
            for (int i = 1; i <= userNum; i++)
            {
                int[] sumOddAndEvenDigits = CalculatedTheSumsOfEvenAndOddDigitsANumber(i);
                result [i-1] = FindNumWhereSumOfEvenDigitsIsGreaterThanOddDigits(
                    i, sumOddAndEvenDigits, ref arrLenght
                    );
            }
            int[] expResult = new int[arrLenght];
            int index = -1;
            foreach (var item in result)
            {
                if (item != 0)
                {
                    index++;
                    expResult[index] = item;
                }
            }
            return expResult;
        }

        public int[] CalculatedTheSumsOfEvenAndOddDigitsANumber(int i)
        {
            if (i <= 0)
                throw new ArgumentException("Число должно быть больше нуля");
            int[] counterOddEven = { 0, 0 };

            while (i != 0)
            {
                int remainder = i % 10;
                i/= 10;
                if (remainder % 2 == 1)
                    counterOddEven[0] += remainder;
                else counterOddEven[1] += remainder;
            }
            return counterOddEven;
        }
        public int FindNumWhereSumOfEvenDigitsIsGreaterThanOddDigits(int i, 
            int[] counterOddEven, ref int arrLength)
        {
            if (counterOddEven[1] > counterOddEven[0])
            {
                return i;
            }
            else 
            {
                arrLength--;
                return 0; 
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
            bool flag = false;
            int remainder1, remainder2;
            do
            {
                int copySecondNum = secondNum;
                remainder1 = firstNum % 10;
                firstNum /= 10;
                do
                {
                    remainder2 = copySecondNum % 10;
                    copySecondNum /= 10;
                    if (Math.Abs(remainder1) == Math.Abs(remainder2))
                        flag = true;
                } while (!flag && copySecondNum != 0);
            } while (!flag && firstNum != 0);

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
