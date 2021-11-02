using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists.Tests
{
    class TestDataList
    {
        public static int[] GetArrayForToArrayAndGetLengthTest(int ID)
        {
            return ID switch
            {
                0 => new int[] { 1 },
                1 => new int[] { 4 },
                2 => new int[] { 1, 2, 3, 4 },
                3 => new int[] { 1, 3, -9, 12, 22 },
                _ => new int[] { },
            };
        }

        public static int[] GetExpectedArrayForToArrayTest(int ID)
        {
            return ID switch
            {
                0 => new int[] { 1 },
                1 => new int[] { 4 },
                2 => new int[] { 1, 2, 3, 4 },
                3 => new int[] { 1, 3, -9, 12, 22 },
                _ => new int[] { },
            };
        }

        public static int[] GetListForAddLastTest(int ID)
        {
            return ID switch
            {
                0 => new int[] { 1 },
                1 => new int[] { 4 },
                2 => new int[] { 1, 2, 3, 4 },
                _ => new int[] { },
            };
        }

        public static int[] GetExpectedArrayForAddLastTest(int ID)
        {
            return ID switch
            {
                0 => new int[] { 1, 2 },
                1 => new int[] { 4, 12 },
                2 => new int[] { 1, 2, 3, 4, 5 },
                _ => new int[] { 0 },
            };
        }

        public static int[] GetAddListForAddLastTest(int ID)
        {
            return ID switch
            {
                0 => new int[] { 1, 2, 3, 4 },
                1 => new int[] { },
                2 => new int[] { 1 },
                _ => new int[] { 4 },
            };
        }
        public static int[] GetExpectedListForAddLastTest(int ID)
        {
            return ID switch
            {
                0 => new int[] { 1, 1, 2, 3, 4 },
                1 => new int[] { 4 },
                2 => new int[] { 1, 2, 3, 4, 1 },
                _ => new int[] { 4 },
            };
        }

        public static int[] GetListForAddFirstTest(int ID)
        {
            return ID switch
            {
                0 => new int[] { 1 },
                1 => new int[] { 4 },
                2 => new int[] { 1, 2, 3, 4 },
                _ => new int[] { },
            };
        }

        public static int[] GetExpectedArrayForAddFirstTest(int ID)
        {
            return ID switch
            {
                0 => new int[] { 2, 1 },
                1 => new int[] { 12, 4 },
                2 => new int[] { 5, 1, 2, 3, 4 },
                _ => new int[] { 0 },
            };
        }

        public static int[] GetAddListForAddFirstTest(int ID)
        {
            return ID switch
            {
                0 => new int[] { 1, 2, 3, 4 },
                1 => new int[] { },
                2 => new int[] { 1 },
                _ => new int[] { 4 },
            };
        }
        public static int[] GetExpectedListForAddFirstTest(int ID)
        {
            return ID switch
            {
                0 => new int[] { 1, 2, 3, 4, 1 },
                1 => new int[] { 4 },
                2 => new int[] { 1, 1, 2, 3, 4 },
                _ => new int[] { 4 },
            };
        }

        public static int[] GetListForAddAtTest(int ID)
        {
            return ID switch
            {
                0 => new int[] { 1 },
                1 => new int[] { 4 },
                2 => new int[] { 1, 2, 3, 4 },
                3 => new int[] { 1, 2, 3, 4 },
                4 => new int[] { 1, 2, 3, 4 },
                5 => new int[] { 0, 1, 2, 3, 4 },
                6 => new int[] { 0, 1, 2, 0, 0 },
                _ => new int[] { },
            };
        }

        public static int[] GetExpectedArrayForAddAtTest(int ID)
        {
            return ID switch
            {
                0 => new int[] { 2, 1 },
                1 => new int[] { 12, 4 },
                2 => new int[] { 1, 2, 5, 3, 4 },
                3 => new int[] { 1, 2, 3, 0, 4 },
                4 => new int[] { 0, 1, 2, 3, 4 },
                5 => new int[] { 0, 1, 100, 2, 3, 4 },
                6 => new int[] { 0, 0, 1, 2, 0, 0 },
                _ => new int[] { 228 },
            };
        }

        public static int[] GetAddListForAddAtTest(int ID)
        {
            return ID switch
            {
                0 => new int[] { 1, 2, 3, 4 },
                1 => new int[] { },
                2 => new int[] { 1 },
                3 => new int[] { 11, 12 },
                4 => new int[] { 4, 5, 6 },
                5 => new int[] { 4, 5, 6 },
                6 => new int[] { 24, 35, 46, 57 },
                _ => new int[] { 4 },
            };
        }
        public static int[] GetExpectedListForAddAtTest(int ID)
        {
            return ID switch
            {
                0 => new int[] { 1, 2, 3, 4, 1 },
                1 => new int[] { 4 },
                2 => new int[] { 1, 1, 2, 3, 4 },
                3 => new int[] { 1, 2, 11, 12, 3, 4 },
                4 => new int[] { 4, 5, 6, 1, 2, 3, 4 },
                5 => new int[] { 0, 1, 2, 3, 4, 5, 6, 4 },
                6 => new int[] { 0, 1, 2, 24, 35, 46, 57, 0, 0 },
                _ => new int[] { 4 },
            };
        }


        public static int[] GetListForSetTest(int ID)
        {
            return ID switch
            {
                0 => new int[] { 1, 2, 3, 4 },
                1 => new int[] { 1 },
                _ => new int[] { },//for negative test
            };
        }
        public static int[] GetExpectedListForSetTest(int ID)
        {
            return ID switch
            {
                0 => new int[] { 1, 2, 0, 4 },
                1 => new int[] { 4 },
                2 => new int[] { 4, 5, 0 },
                _ => new int[] { 4 },
            };
        }

        public static int[] GetListForRemoveFirstLastAtTest(int ID)
        {
            return ID switch
            {
                0 => new int[] { 1, 2, 3, 4 },
                1 => new int[] { 1 },
                2 => new int[] { 4, 5, 6 },
                3 => new int[] { 1, 2, 3, 4 },
                _ => new int[] { },
            };
        }
        public static int[] GetExpectedListForRemoveFirstTest(int ID)
        {
            return ID switch
            {
                0 => new int[] { 2, 3, 4 },
                1 => new int[] {  },
                2 => new int[] { 5, 6 },
                _ => new int[] { },
            };
        }

        public static int[] GetExpectedListForRemoveLastTest(int ID)
        {
            return ID switch
            {
                0 => new int[] { 1, 2, 3 },
                1 => new int[] {  },
                2 => new int[] { 4, 5 },
                _ => new int[] { },
            };
        }

        public static int[] GetExpectedListForRemoveAtTest(int ID)
        {
            return ID switch
            {
                0 => new int[] { 1, 2, 4 },
                1 => new int[] {  },
                2 => new int[] { 5, 6 },
                3 => new int[] { 1, 2, 3 },
                _ => new int[] { },
            };
        }

        public static int[] GetListForRemoveFirstLastAtMultipleTest(int ID)
        {
            return ID switch
            {
                0 => new int[] { 1, 2, 3, 4, 5, 6, 7 },//удаляю просто
                1 => new int[] { 5, 6, 7 },//удаляю больше длины
                2 => new int[] { -1, -2, 3, -4 },//в количестве как в листе
                3 => new int[] { -1, 2, -3, 4, -5, 6, -7 },
                4 => new int[] { -1, -2, -3, -4, -5, -6, -7 },
                5 => new int[] { -1, -2, -3, -4, -5, -6, -7 },
                6 => new int[] { -1, -2, -3, -4, -5, -6, -7 },
                _ => new int[] {  },//просто
            };
        }

        public static int[] GetExpectedListForRemoveFirstMultipleTest(int ID)
        {
            return ID switch
            {
                0 => new int[] { 4, 5, 6, 7 },//3
                1 => new int[] { },//4
                2 => new int[] { },//4
                3 => new int[] { 2, -3, 4, -5, 6, -7 },
                4 => new int[] { -1, -2, -3, -4, -5, -6, -7 },
                5 => new int[] { -7 },
                6 => new int[] { -3, -4, -5, -6, -7 },
                _ => new int[] { },//1
            };
        }

        public static int[] GetExpectedListForRemoveLastMultipleTest(int ID)
        {
            return ID switch
            {
                0 => new int[] { 1, 2, 3, 4 },//3
                1 => new int[] { },//4
                2 => new int[] { -1, -2 },//2
                3 => new int[] { -1, 2, -3, 4, -5, 6 },
                4 => new int[] { -1, -2, -3, -4, -5, -6, -7 },
                5 => new int[] { -1 },
                6 => new int[] { -1, -2, -3, -4, -5 },
                _ => new int[] { },//1
            };
        }

        public static int[] GetExpectedListForRemoveAtMultipleTest(int ID)
        {
            return ID switch
            {
                0 => new int[] { 1, 2, 6, 7 },
                1 => new int[] { },
                2 => new int[] { -1, -2 },
                3 => new int[] { -1, 2, -3, 4, -5, 6, -7 },
                4 => new int[] { -1, -2, -3, -4, -5, -7 },
                5 => new int[] { -4, -5, -6, -7 },
                6 => new int[] { -1, -2, -3, -4 },
                _ => new int[] { },//1
            };
        }

        public static int[] GetListForRemoveFirstValAndAllTest(int ID)
        {
            return ID switch
            {
                0 => new int[] { 12, -6, 8, -9, 4, 8, 8, 10, 8 },
                1 => new int[] { 8, 8, 2, 3, 4, 8 },
                2 => new int[] { 8, 8, 8 },
                3 => new int[] { 5, 2, 1, 0 },
                _ => new int[] {  },//1
            };
        }

        public static int[] GetExpectedListForRemoveFirstValTest(int ID)
        {
            return ID switch
            {
                0 => new int[] { 12, -6, -9, 4, 8, 8, 10, 8 },
                1 => new int[] { 8, 2, 3, 4, 8 },
                2 => new int[] { 8, 8 },
                3 => new int[] { 5, 2, 1, 0 },
                _ => new int[] {  },
            };
        }

        public static int[] GetExpectedListForRemoveAllTest(int ID)
        {
            return ID switch
            {
                0 => new int[] { 12, -6, -9, 4, 10 },
                1 => new int[] { 2, 3, 4 },
                2 => new int[] { },
                3 => new int[] { 5, 2, 1, 0 },
                _ => new int[] {  },
            };
        }

        public static int[] GetListForGetFirstGetLastGetTest(int ID)
        {
            return ID switch
            {
                0 => new int[] { 12, -6, -9, 4, 8, 8, 10, 8 },
                1 => new int[] { 8, 2, 3, 4},
                2 => new int[] { 8, 8 },
                3 => new int[] { 5, 2, 1, 0 },
                4 => new int[] { 228 },
                _ => new int[] { },
            };
        }

        public static int[] GetListForReverseTest(int ID)
        {
            return ID switch
            {
                0 => new int[] { 12, -6, -9, 4, 10 },
                1 => new int[] { 2, 3, 4, 5 },
                2 => new int[] { 4 },
                3 => new int[] { 5, 5, 5 },
                _ => new int[] {  },
            };
        }

        public static int[] GetExpectedListForReverseTest(int ID)
        {
            return ID switch
            {
                0 => new int[] { 10, 4, -9, -6, 12 },
                1 => new int[] { 5, 4, 3, 2 },
                2 => new int[] { 4 },
                3 => new int[] { 5, 5, 5 },
                _ => new int[] {  },
            };
        }

        public static int[] GetListForMaxMinAndThisIndexesTest(int ID)
        {
            return ID switch
            {
                0 => new int[] { 10, -6, -9, 4, 12 },
                1 => new int[] { 2, 3, 4, 1 },
                2 => new int[] { 4 },
                3 => new int[] { 5, 5, 5 },
                _ => new int[] {  },
            };
        }

        public static int[] GetListForSortAndSortDescTest(int ID)
        {
            return ID switch
            {
                0 => new int[] { 10, -6, -9, 4, 12 },
                1 => new int[] { 2, 3, 4, 1 },
                2 => new int[] { 4 },
                3 => new int[] { 5, 5, 5 },
                4 => new int[] { 1, 2, 3, 4, 5 },
                5 => new int[] { -1, -2, -3, -4 },
                6 => new int[] { -1, -3, -2, -3, -3, -4 },
                _ => new int[] {  },
            };
        }

        public static int[] GetExpectedListForSortTest(int ID)
        {
            return ID switch
            {
                0 => new int[] { -9, -6, 4, 10, 12 },
                1 => new int[] { 1, 2, 3, 4 },
                2 => new int[] { 4 },
                3 => new int[] { 5, 5, 5 },
                4 => new int[] { 1, 2, 3, 4, 5 },
                5 => new int[] { -4, -3, -2, -1 },
                6 => new int[] { -4, -3, -3, -3, -2, -1 },
                _ => new int[] {  },
            };
        }

        public static int[] GetExpectedListForSortDescTest(int ID)
        {
            return ID switch
            {
                0 => new int[] { 12, 10, 4, -6, -9 },
                1 => new int[] { 4, 3, 2, 1 },
                2 => new int[] { 4 },
                3 => new int[] { 5, 5, 5 },
                4 => new int[] { 5, 4, 3, 2, 1 },
                5 => new int[] { -1, -2, -3, -4 },
                6 => new int[] { -1, -2, -3, -3, -3, -4 },
                _ => new int[] { },
            };
        }
    }
}
