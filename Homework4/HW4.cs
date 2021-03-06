using System;
using Core;

namespace Homework4
{
    public class HW4
    {
        private readonly Helper _helper;

        public HW4()
        {
            _helper = new Helper();
        }
        public void SolveTask1()
        {
            Console.WriteLine("Найти минимальный элемент массива\n");
            try
            {
                int[] arr = GetRandomArray("Введите длину массива: ");
                int result = SearchMinElementArr(arr);

                Console.WriteLine($"\nРезультат задачи 1, домашки 4: \n {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Длина массива должна быть числом");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public int[] GetRandomArray(string message)
        {
            Console.WriteLine(message);
            Random rnd = new Random();
            int lengthArr = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[lengthArr];
            if (lengthArr <= 0)
            {
                throw new Exception("Длина массива представляет положительно число больше нуля");
            }
            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-15, 15);
                Console.Write($"{arr[i]}\t");
            }
            return arr;
        }
        public int SearchMinElementArr(int[] arr)
        {
            if (arr.Length < 1)
            {
                throw new ArgumentException("Массив нулевой размерности");
            }
            int minElementArr = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (minElementArr > arr[i])
                    minElementArr = arr[i];
            }
            return minElementArr;
        }

        public void SolveTask2()
        {
            Console.WriteLine("Найти максимальный элемент массива\n");

            try
            {
                int[] arr = GetRandomArray("Введите длину массива: ");
                int result = SearchMaxElementArr(arr);
                Console.WriteLine($"\nРезультат задачи 2, домашки 4: \n {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Длина массива должна быть числом");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public int SearchMaxElementArr(int[] arr)
        {
            if (arr.Length < 1)
            {
                throw new ArgumentException("Массив нулевой размерности");
            }
            int maxElementArr = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (maxElementArr < arr[i])
                    maxElementArr = arr[i];
            }
            return maxElementArr;
        }

        public void SolveTask3()
        {
            Console.WriteLine("Найти индекс минимального элемента массива\n");

            try
            {
                int[] arr = GetRandomArray("Введите длину массива: ");
                int result = SearchIndexMinElementArr(arr);
                Console.WriteLine($"\nРезультат задачи 3, домашки 4: \n {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Длина массива должна быть числом");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public int SearchIndexMinElementArr(int[] arr)
        {
            if (arr.Length < 1)
            {
                throw new ArgumentException("Массив нулевой размерности");
            }
            int minElementArr = 0;
            int minIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (minElementArr > arr[i])
                {
                    minElementArr = arr[i];
                    minIndex = i;
                }
            }
            return minIndex;
        }

        public void SolveTask4()
        {
            Console.WriteLine("Найти индекс максимального элемента массива\n");
            try
            {
                int[] arr = GetRandomArray("Введите длину массива: ");
                int result = SearchIndexMaxElementArr(arr);
                Console.WriteLine($"\nРезультат задачи 4, домашки 4: \n {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Длина массива должна быть числом");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public int SearchIndexMaxElementArr(int[] arr)
        {
            if (arr.Length < 1)
            {
                throw new ArgumentException("Массив нулевой размерности");
            }
            int maxElementArr = 0;
            int maxIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (maxElementArr < arr[i])
                {
                    maxElementArr = arr[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        public void SolveTask5()
        {
            Console.WriteLine("Посчитать сумму элементов массива с нечетными индексами\n");

            try
            {
                int[] arr = GetRandomArray("Введите длину массива: ");
                int result = CalculateTheSumOfTheElementsOfAnArrayWithOddIndices(arr);
                Console.WriteLine($"\nРезультат задачи 5, домашки 4: \n {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Длина массива должна быть числом");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public int CalculateTheSumOfTheElementsOfAnArrayWithOddIndices(int[] arr)
        {
            int sumOddIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if ((i + 1) % 2 == 1)
                    sumOddIndex += arr[i];
            }
            return sumOddIndex;
        }
        public void SolveTask6()
        {
            Console.WriteLine("Сделать реверс массива (массив в обратном направлении)\n");
            try
            {
                int[] arr = GetRandomArray("Введите длину массива: ");
                ReverseTheArray(arr);
                Console.WriteLine($"\nРезультат задачи 6, домашки 4: \n");
                _helper.ShowMeAnArrayAnScreen(arr);
            }
            catch (FormatException)
            {
                Console.WriteLine("Длина массива должна быть числом");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        public void ReverseTheArray(int[] arr)
        {
            for (int i = arr.Length - 1; i >= arr.Length / 2; i--)
            {
                _helper.SwapTheVariables(ref arr[i], ref arr[arr.Length - 1 - i]);
            }

        }

        public void SolveTask7()
        {
            Console.WriteLine("Посчитать количество нечетных элементов массива");

            try
            {
                int[] arr = GetRandomArray("Введите длину массива: ");
                int result = CountTheNumberOfOddElementsInAnArray(arr);
                Console.WriteLine($"\nРезультат задачи 7, домашки 4: {result}\n");
            }
            catch (FormatException)
            {
                Console.WriteLine("Длина массива должна быть числом");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        public int CountTheNumberOfOddElementsInAnArray(int[] arr)
        {
            int itemArrOdd = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                    itemArrOdd++;
            }
            return itemArrOdd;
        }

        public void SolveTask8()
        {
            Console.WriteLine("Поменять местами первую и вторую половину массива, " +
                "например, для массива 1 2 3 4, результат 3 4 1 2,  " +
                "или для 12345 - 45312.\n");
            try
            {
                int[] arr = GetRandomArray("Введите длину массива: ");
                ChangeHalfsOfArray(arr);
                Console.WriteLine($"\nРезультат задачи 8, домашки 4: \n");
                _helper.ShowMeAnArrayAnScreen(arr);
            }
            catch (FormatException)
            {
                Console.WriteLine("Длина массива должна быть числом");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public void ChangeHalfsOfArray(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                _helper.SwapTheVariables(ref arr[i], ref arr[arr.Length - arr.Length / 2 + i]);
            }
        }

        public void SolveTask9()
        {
            Console.WriteLine("Отсортировать массив по возрастанию пузырьком(Bubble)");
           
            try
            {
                int[] arr = GetRandomArray("Введите длину массива: ");
                SortBubbleAscending(arr);
                Console.WriteLine($"\nРезультат задачи 9, домашки 4: \n");
                _helper.ShowMeAnArrayAnScreen(arr);
            }
            
            catch (FormatException)
            {
                Console.WriteLine("Длина массива должна быть числом");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void SortBubbleAscending(int[] arr)
        {
            int countExchange = 1;
            while (countExchange != 0)
            {
                countExchange = 0;
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    int firstOfPair, secondOfPair;
                    firstOfPair = arr[j];
                    secondOfPair = arr[j + 1];

                    if (secondOfPair < firstOfPair)
                    {
                        arr[j] = secondOfPair;
                        arr[j + 1] = firstOfPair;
                        countExchange++;
                    }
                }
            }
        }

        public void SolveTask10()
        {
            Console.WriteLine("Отсортировать массив по убыванию вставками(Insert)");
            try
            {
                int[] arr = GetRandomArray("Введите длину массива: ");
                SortInsertDescending(arr);
                Console.WriteLine($"\nРезультат задачи 10, домашки 4: \n");
                _helper.ShowMeAnArrayAnScreen(arr);
            }
            catch (FormatException)
            {
                Console.WriteLine("Длина массива должна быть числом");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void SortInsertDescending(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int temp = arr[i];
                for (int j = i - 1; j >= 0; j--)
                {
                    if (temp > arr[j])
                    {
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
    }
}
