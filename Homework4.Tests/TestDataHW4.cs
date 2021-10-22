using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Tests
{
    public class TestDataHW4
    {
        public static int[] GetArrayForSearchMinAndMaxAndThemIndexesElementArrTest(int arrayID)
        {
            switch (arrayID)
            {
                case 0:
                    return new int[] { 1, 2, 3 };
                    break;
                case 1:
                    return new int[] { 2, 4, 1, 0, 10, -8 };
                    break;
                case 2:
                    return new int[] { 1, 1, 1, 1, 1, 1 };
                    break;
                case 3:
                    return new int[] { 0 };
                    break;
                default:
                    return new int[] {  };
                    break;
            }
        }

        public static int[] GetArrForCalcTheSumOfElementsOfArrayWithOddIndicesTest(int arrayID)
        {
            switch (arrayID)
            {
                case 0:
                    return new int[] { 1, 2, 3, 0, 4, 19 }; //8
                    break;
                case 1:
                    return new int[] { -21, 6, 4, 16, 17, -8, 0, 1 }; //0
                    break;
                case 2:
                    return new int[] { 2, 1, 1, 1, 3, 1 }; //6
                case 3:
                    return new int[] { 0, 2, 0, -6 }; //0
                    break;
                default:
                    return new int[] { }; //0
                    break;
            }
        }

        public static int[] GetArrForReverseTheArrayTest(int arrayID)
        {
            switch (arrayID)
            {
                case 0:
                    return new int[] { 1, 2, 3, 4, 5, 6, 7, 8};
                    break;
                case 1:
                    return new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1}; 
                    break;
                case 2:
                    return new int[] { 0 }; 
                case 3:
                    return new int[] { 5, 5, 5, 5 }; 
                    break;
                case 4:
                    return new int[] { -21, 6, 4, 16, 17, -8, 0, 1 }; 
                    break;
                default:
                    return new int[] { };
                    break;
            }
        }

        public static int[] GetExpextedArrForReverseTheArrayTest(int arrayID)
        {
            switch (arrayID)
            {
                case 0:
                    return new int[] { 8, 7, 6, 5, 4, 3, 2, 1 };
                    break;
                case 1:
                    return new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                    break;
                case 2:
                    return new int[] { 0 }; 
                case 3:
                    return new int[] { 5, 5, 5, 5 };
                    break;
                case 4:
                    return new int[] { 1, 0, -8, 17, 16, 4, 6, -21};
                    break;
                default:
                    return new int[] { };
                    break;
            }
        }

        public static int[] GetArrCountTheNumberOfOddElementsInAnArrayTest(int arrayID)
        {
            switch (arrayID)
            {
                case 0:
                    return new int[] { 8, 7, 6, 5, 4, 3, 2, 1 }; //4
                    break;
                case 1:
                    return new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; //5
                    break;
                case 2:
                    return new int[] { 0 };//0
                case 3:
                    return new int[] { 5, 5, 5, 5 };//4
                    break;
                case 4:
                    return new int[] { 1, 0, -8, 17, 16, 4, 6, -21 }; //3
                    break;
                case 5:
                    return new int[] { 2, 0, -8, 4, 16, 500, 6, 80 }; //0
                    break;
                default:
                    return new int[] { }; //0
                    break;
            }
        }

        public static int[] GetArrForSortTest(int arrayID)
        {
            switch (arrayID)
            {
                case 0:
                    return new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
                    break;
                case 1:
                    return new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
                    break;
                case 2:
                    return new int[] { 0 };
                case 3:
                    return new int[] { 5, 5, 5, 5 };
                    break;
                case 4:
                    return new int[] { -21, 6, 4, 16, 17, -8, 0, 1 };
                    break;
                case 5:
                    return new int[] { -26, 11, -10, 1, 170, -81, 16, -170, 3 };
                    break;
                default:
                    return new int[] { };
                    break;
            }
        }

        public static int[] GetExpextedArrForSortBubbleAscendingTest(int arrayID)
        {
            switch (arrayID)
            {
                case 0:
                    return new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
                    break;
                case 1:
                    return new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                    break;
                case 2:
                    return new int[] { 0 };
                case 3:
                    return new int[] { 5, 5, 5, 5 };
                    break;
                case 4:
                    return new int[] {-21, -8, 0, 1, 4, 6, 16, 17 };
                    break;
                case 5:
                    return new int[] { -170, -81, -26, -10, 1, 3, 11, 16, 170 };
                    break;
                default:
                    return new int[] { };
                    break;
            }
        }

        public static int[] GetExpextedArrForSortInsertDescendingTest(int arrayID)
        {
            switch (arrayID)
            {
                case 0:
                    return new int[] { 8, 7, 6, 5, 4, 3, 2, 1 };
                    break;
                case 1:
                    return new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
                    break;
                case 2:
                    return new int[] { 0 };
                case 3:
                    return new int[] { 5, 5, 5, 5 };
                    break;
                case 4:
                    return new int[] {17, 16, 6, 4, 1, 0, -8, -21 };
                    break;
                case 5:
                    return new int[] { 170, 16, 11, 3, 1, -10, -26, -81, -170 };
                    break;
                default:
                    return new int[] { };
                    break;
            }
        }


        public static int[] GetArrForChangeHalfsOfArrayTest(int arrayID)
        {
            switch (arrayID)
            {
                case 0:
                    return new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
                    break;
                case 1:
                    return new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
                    break;
                case 2:
                    return new int[] { 0 };
                case 3:
                    return new int[] { 5, 5, 5, 5 };
                    break;
                case 4:
                    return new int[] { -21, 6, 4, 16, -21, 6, 4, 16 };
                    break;
                case 5:
                    return new int[] { -26, 11, -10, 1, 170, -26, 11, -10, 1 };
                    break;
                case 6:
                    return new int[] { -81, 16, -170, 3, 170, -26, 11, -10, 1 };
                    break;
                default:
                    return new int[] { };
                    break;
            }
        }

        public static int[] GetExpextedArrForChangeHalfsOfArrayTest(int arrayID)
        {
            switch (arrayID)
            {
                case 0:
                    return new int[] { 5, 6, 7, 8, 1, 2, 3, 4};
                    break;
                case 1:
                    return new int[] { 4, 3, 2, 1, 5, 9, 8, 7, 6 };
                    break;
                case 2:
                    return new int[] { 0 };
                case 3:
                    return new int[] { 5, 5, 5, 5 };
                    break;
                case 4:
                    return new int[] { -21, 6, 4, 16, -21, 6, 4, 16 };
                    break;
                case 5:
                    return new int[] { -26, 11, -10, 1, 170, -26, 11, -10, 1 };
                    break;
                case 6:
                    return new int[] { -26, 11, -10, 1, 170, -81, 16, -170, 3 };
                    break;
                default:
                    return new int[] { };
                    break;
            }
        }
    }
}
