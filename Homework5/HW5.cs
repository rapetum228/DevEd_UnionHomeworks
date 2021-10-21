using System;

namespace Homework5
{
    public class HW5
    {
        public void SolveTask1()
        {
            Console.WriteLine("Найти минимальный элемент массива\n");

            try
            {
                int[,] arr = GetRandomTwoDimArray();
                int result = SearchMinElementTwoDimArr(arr);
                Console.WriteLine($"\nРезультат задачи 1, домашки 5: \n {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Размерности массива должны быть числами");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public int[,] GetRandomTwoDimArray()
        {
            Console.WriteLine("Введите количество строк массива: ");
            int lengthArrRow = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            Console.WriteLine("Введите количество столбцов массива: ");
            int lengthArrColumn = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[lengthArrRow, lengthArrColumn];
            if (lengthArrRow <= 0 || lengthArrColumn <= 0)
            {
                throw new Exception("Размерности массива должны быть положительным числом" +
                    "больше нуля");
            }
            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(-150, 150);
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine();
            }
            return arr;
        }
        public int SearchMinElementTwoDimArr(int[,] arr)
        {
            int minElementArr = arr[0, 0];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (minElementArr > arr[i, j])
                        minElementArr = arr[i, j];
                }
            }
            return minElementArr;
        }

        public void SolveTask2()
        {
            Console.WriteLine("Найти максимальный элемент массива\n");
            try
            {
                int[,] arr = GetRandomTwoDimArray();
                int result = SearchMaxElementTwoDimArr(arr);
                Console.WriteLine($"\nРезультат задачи 2, домашки 5: \n {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Размерности массива должны быть числами");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public int SearchMaxElementTwoDimArr(int[,] arr)
        {
            int maxElementArr = arr[0,0];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (maxElementArr < arr[i, j])
                        maxElementArr = arr[i, j];
                }
            }
            return maxElementArr;
        }

        public void SolveTask3()
        {
            Console.WriteLine("Найти индекс минимального элемента массива\n");
            try
            {
                int[,] arr = GetRandomTwoDimArray();
                int[] result = SearchIndexMinElementMatrix(arr);
                Console.WriteLine($"\nРезультат задачи 3, домашки 5: \n");
                ShowMeAnArrayAnScreen(result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Размерности массива должны быть числами");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void ShowMeAnArrayAnScreen(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]}\t");
            Console.WriteLine("\n");
        }
        public int[] SearchIndexMinElementMatrix(int[,] arr)
        {
            int minElementArr = arr[0, 0];
            int minRowInd = 0;
            int minColumnInd = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (minElementArr > arr[i, j])
                    {
                        minRowInd = i;
                        minColumnInd = j;
                        minElementArr = arr[i, j];
                    }
                }
            }
            int[] minIndexes = { minRowInd, minColumnInd };
            return minIndexes;
        }

        public void SolveTask4()
        {
            Console.WriteLine("Найти индекс максимального элемента массива\n");
            try
            {
                int[,] arr = GetRandomTwoDimArray();
                int[] result = SearchIndexMaxElementMatrix(arr);
                Console.WriteLine($"\nРезультат задачи 4, домашки 5: \n");
                ShowMeAnArrayAnScreen(result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Размерности массива должны быть числами");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public int[] SearchIndexMaxElementMatrix(int[,] arr)
        {
            int maxElementArr = arr[0, 0];
            int maxRowInd = 0;
            int maxColumnInd = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (maxElementArr < arr[i, j])
                    {
                        maxRowInd = i;
                        maxColumnInd = j;
                        maxElementArr = arr[i, j];
                    }
                }
            }
            int[] maxIndexes = { maxRowInd, maxColumnInd };
            return maxIndexes;
        }

        public void SolveTask5()
        {
            Console.WriteLine("Найти количество элементов массива, " +
                "которые больше всех своих соседей одновременно");
            try
            {
                int[,] arr = GetRandomTwoDimArray();
                int result = IteratingOverArray(arr);
                Console.WriteLine($"\nРезультат задачи 6, домашки 5: {result}\n ");
            }
            catch (FormatException)
            {
                Console.WriteLine("Размерности массива должны быть числами");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public int IteratingOverArray(int[,] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    count += CountTheNumbersOfGreaterItems(i, j, arr.GetLength(0),
            arr.GetLength(1), arr);
                }
            }
            return count;
        }
        public int CountTheNumbersOfGreaterItems(int i, int j, int arrLenghtRow, 
            int arrLenghtColumn, int[,] arr)
        {
            bool rowPlus, rowMinus, columnPlus, columnMinus;
            int count = 0;
            rowPlus = (i + 1 > arrLenghtRow - 1) || (arr[i, j] >= arr[i + 1, j]);
            columnPlus = (j + 1 > arrLenghtColumn - 1) || (arr[i, j] >= arr[i, j + 1]);
            rowMinus = (i - 1 < 0) || (arr[i, j] >= arr[i - 1, j]);
            columnMinus = (j - 1 < 0) || (arr[i, j] >= arr[i, j - 1]);

            if (rowPlus && rowMinus && columnPlus && columnMinus)
                count = 1;

            return count;
        }

        public void SolveTask6()
        {
            Console.WriteLine("Отразите массив относительно его главной диагонали\n");
            try
            {
                int[,] arr = GetRandomTwoDimArray();
                TransponseTheMatrix(arr);
                Console.WriteLine($"\nРезультат задачи 6, домашки 5: \n ");
                MatrixOnWindow(arr);
            }
            catch (FormatException)
            {
                Console.WriteLine("Размерности массива должны быть числами");
            }
            catch(IncorrectMatrixDimension ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void TransponseTheMatrix(int[,] arr)
        {
            if (arr.GetLength(0) != arr.GetLength(1))
            {
                throw new IncorrectMatrixDimension("Матрица должна быть квадратной");
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = i; j < arr.GetLength(1); j++)
                {
                    int temp = arr[i, j];
                    arr[i, j] = arr[j, i];
                    arr[j, i] = temp;
                }
            }
        }
        public void MatrixOnWindow(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {

                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        public void SolveAddTask()
        {
            Console.WriteLine("Сделать красивый вывод массива\n");
            try
            {
                int[,] arr = GetRandomTwoDimArray();
                int maxElArr = SearchMaxElementTwoDimArr(arr);

                Console.WriteLine($"\nРезультат дополнительной задачи, домашки 5: \n ");
                DoBeautifulArray(arr, maxElArr);
            }
            catch (FormatException)
            {
                Console.WriteLine("Размерности массива должны быть числами");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DoBeautifulArray(int[,] arr, int maxElementArr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    CreatingABeautyCondition(arr[i, j], maxElementArr);
                }
                Console.WriteLine();
            }
        }

        public void CreatingABeautyCondition(int elementArr, int maxElementArr)
        {
            int tempMax = maxElementArr;
            string probel = "";
            int temp = elementArr;
            while (temp != 0)
            {
                tempMax /= 10;
                temp /= 10;
            }
            while (tempMax != 0)
            {
                tempMax /= 10;
                probel += " ";
            }
            if (elementArr >= 0)
                probel += " ";

            Console.Write($"{probel}{elementArr}\t");
        }
    }

    class IncorrectMatrixDimension : Exception
    {
        public IncorrectMatrixDimension(string message)
            : base(message)
        { }
    }
}
