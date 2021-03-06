using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5.Tests
{
    public class TestDataHW5
    {
        public static int[,] GetArraysForSearchMinAndMaxElementsAndThisIndexesTwoDimArrTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } },
                1 => new int[,] { { 4, 8, -3, 15 }, { 9, -911, 60, -10 }, { 56, 45, 9, -10 } },
                2 => new int[,] { { 4, 4, 4, 4 }, { 4, 4, 4, 4 }, { 4, 4, 4, 4 } },
                3 => new int[,] { { 4 } },
                _ => new int[,] { { } },
            };
        }

        public static int[] GetExpectedArraysForSearchIndexMinElementMatrixTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new int[]  { 0, 0 }, 
                1 => new int[]  { 1, 1 }, 
                2 => new int[]  { 0, 0 }, 
                3 => new int[]  { 0, 0 },
                _ => new int[]  { },
            };
        }
        public static int[] GetExpectedArraysForSearchIndexMaxElementMatrixTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new int[] { 2, 2 },
                1 => new int[] { 1, 2 },
                2 => new int[] { 0, 0 },
                3 => new int[] { 0, 0 },
                _ => new int[] { },
            };
        }

        public static int[,] GetArraysForСountTheNumberOfElementsThatAreLargerThanAllTheirNeighborsAtTheSameTimeTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new int[,] { { 1, 2, 3 }, 
                                  { 4, 5, 6 }, 
                                  { 7, 8, 9 } },
                1 => new int[,] { { 4, 8, -3, 15 }, 
                                  { 9, -911, 60, -10 },
                                   { 56, 45, 9, -10 } },
                2 => new int[,] { { 4, 4, 4, 4 }, { 4, 4, 4, 4 }, { 4, 4, 4, 4 } }, 
                3 => new int[,] { { 4 } }, 

                _ => new int[,] { { } },
            };
        }

        public static int[,] GetArraysForTransponseTheMatrixTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new int[,] { { 1, 2, 3 },
                                  { 4, 5, 6 },
                                  { 7, 8, 9 } },
                1 => new int[,] { { 1, 2, 3, 4 },
                                  { 5, 6, 7, 8 },
                                  { 9, 0, -20, 38 },
                                  { 0, 1, -46, 14 } },
                2 => new int[,] { { 4, 4, 4, 4 }, { 4, 4, 4, 4 }, { 4, 4, 4, 4 }, { 4, 4, 4, 4 } }, 
                3 => new int[,] { { 4 } },
                4 => new int[,]{ { 4, 8, -3, 15 },
                                { 9, -911, 60, -10 },
                                 { 56, 45, 9, -10 }},
                5 => new int[,] { { } },
                _ => new int[,] {  },
            };
        }

        public static int[,] GetExpectedArraysForTransponseTheMatrixTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new int[,] { { 1, 4, 7 },
                                  { 2, 5, 8 },
                                  { 3, 6, 9 } },
                1 => new int[,] { { 1, 5, 9, 0 },
                                  { 2, 6, 0, 1 },
                                  { 3, 7, -20, -46 },
                                  { 4, 8, 38, 14 } },
                2 => new int[,] { { 4, 4, 4, 4 }, { 4, 4, 4, 4 }, { 4, 4, 4, 4 }, { 4, 4, 4, 4 } },
                3 => new int[,] { { 4 } }, 

                _ => new int[,] { },
            };
        }
    }
}
