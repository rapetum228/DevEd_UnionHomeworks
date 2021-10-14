using System;

namespace Homework4
{
    public class HW4
    {
        public void SolveTask1()
        {
            Console.WriteLine("Найти минимальный элемент массива\n");
            int[] arr = GetRandomArray("Введите длину массива: ");
            int result = SearchMinElementArr(arr);

            Console.WriteLine($"\nРезультат задачи 1, домашки 4: \n {result}");
        }

        public int[] GetRandomArray(string message)
        {
            Console.WriteLine(message);
            Random rnd = new Random();
            int lengthArr = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[lengthArr];

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
            int minElementArr = 0;

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
            int[] arr = GetRandomArray("Введите длину массива: ");
            int result = SearchMaxElementArr(arr);

            Console.WriteLine($"\nРезультат задачи 2, домашки 4: \n {result}");
        }

        public int SearchMaxElementArr(int[] arr)
        {
            int maxElementArr = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (maxElementArr < arr[i])
                    maxElementArr = arr[i];
            }
            return maxElementArr;
        }

        public void SolveTask3()
        {
            Console.WriteLine("Найти индекс маинимального элемента массива\n");
            int[] arr = GetRandomArray("Введите длину массива: ");
            int result = SearchIndexMinElementArr(arr);

            Console.WriteLine($"\nРезультат задачи 3, домашки 4: \n {result}");
        }

        public int SearchIndexMinElementArr(int[] arr)
        {
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
            int[] arr = GetRandomArray("Введите длину массива: ");
            int result = SearchIndexMaxElementArr(arr);

            Console.WriteLine($"\nРезультат задачи 4, домашки 4: \n {result}");
        }

        public int SearchIndexMaxElementArr(int[] arr)
        {
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
            int[] arr = GetRandomArray("Введите длину массива: ");
            int result = CalcSumOddIndexesArray(arr);

            Console.WriteLine($"\nРезультат задачи 5, домашки 4: \n {result}");
        }

        public int CalcSumOddIndexesArray(int[] arr)
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
            int[] arr = GetRandomArray("Введите длину массива: ");
            int[] result = ReverseArray(arr);
            Console.WriteLine($"\nРезультат задачи 6, домашки 4: \n");
            ArrayOnWindow(result);
        }

        public int[] ReverseArray(int[] arr)
        {
            for (int i = arr.Length - 1; i >= arr.Length / 2; i--)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
            return arr;
        }
        public void ArrayOnWindow(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]}\t");
            Console.WriteLine("\n");
        }

        public void SolveTask7()
        {
            Console.WriteLine("Посчитать количество нечетных элементов массива");
            int[] arr = GetRandomArray("Введите длину массива: ");
            int result = CalcNumberOddElementsOfArray(arr);
            Console.WriteLine($"\nРезультат задачи 7, домашки 4: {result}\n");

        }

        public int CalcNumberOddElementsOfArray(int[] arr)
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
            int[] arr = GetRandomArray("Введите длину массива: ");
            int[] result = ChangeHalfsOfArray(arr);
            Console.WriteLine($"\nРезультат задачи 8, домашки 4: \n");
            ArrayOnWindow(result);
        }

        public int[] ChangeHalfsOfArray(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - arr.Length / 2 + i];
                arr[arr.Length - arr.Length / 2 + i] = temp;
            }
            return arr;
        }

        public void SolveTask9()
        {
            Console.WriteLine("Отсортировать массив по возрастанию пузырьком(Bubble)");
            int[] arr = GetRandomArray("Введите длину массива: ");
            int[] result = SortBubble(arr);
            Console.WriteLine($"\nРезультат задачи 9, домашки 4: \n");
            ArrayOnWindow(result);
        }

        public int[] SortBubble(int[] arr)
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
            return arr;
        }

        public void SolveTask10()
        {
            Console.WriteLine("Отсортировать массив по убыванию вставками(Insert)");
            int[] arr = GetRandomArray("Введите длину массива: ");
            int[] result = SortInsert(arr);
            Console.WriteLine($"\nРезультат задачи 10, домашки 4: \n");
            ArrayOnWindow(result);
        }

        public int[] SortInsert(int[] arr)
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
            return arr;
        }
    }
}
