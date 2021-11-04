using ArrayListLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList.Tests
{
    public class TestDataArrList
    {
        public static ArrList GetArrListForGetLengthTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new ArrList(),
                1 => new ArrList(4),
                2 => new ArrList(new int[] {1, 2, 3, 4}),
                _ => new ArrList(),
            };
        }

        public static int[] GetArrListForToArrayTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new ArrList().ToArray(),
                1 => new ArrList(4).ToArray(),
                2 => new ArrList(new int[] { 1, 2, 3, 4 }).ToArray(),
                _ => new ArrList().ToArray(),
            };
        }

        public static ArrList GetArrListForAddFirstTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new ArrList(),
                1 => new ArrList(4),
                2 => new ArrList(new int[] { 1, 2, 3, 4 }),
                _ => new ArrList(),
            };
        }

        public static int[] GetExpectedArrListForAddFirstTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new ArrList(3).ToArray(),
                1 => new ArrList(new int[] {3, 4}).ToArray(),
                2 => new ArrList(new int[] {3, 1, 2, 3, 4 }).ToArray(),
                _ => new ArrList(3).ToArray(),
            };
        }

        public static int[] GetExpectedArrListForAddFirstArrTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new ArrList(3).ToArray(),
                1 => new ArrList(new int[] { 3, 4 }).ToArray(),
                2 => new int[] { 3, 1, 2, 3, 4 },
                _ => new ArrList(3).ToArray(),
            };
        }

        public static ArrList GetArrListForAddLastTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new ArrList(),
                1 => new ArrList(4),
                2 => new ArrList(new int[] { 1, 2, 3, 4 }),
                _ => new ArrList(),
            };
        }


        public static int[] GetAddArrListForAddLastTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new int[] { 1, 2, 3, 4 },
                1 => new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 },
                2 => new int[] { 0 },
                _ => new int[] { },
            };
        }
        public static int[] GetExpectedArrListForAddLastArrTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new int[] {1, 2, 3, 4 },
                1 => new int[] { 4, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 },
                2 => new int[] { 1, 2, 3, 4, 0 },
                _ => new int[] { },
            };
        }

        public static int[] GetExpectedArrListForAddLastTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new int[] { 4 },
                1 => new int[] { 4, 11 },
                2 => new int[] { 1, 2, 3, 4, 5 },
                _ => new int[] { },
            };
        }

        public static ArrList GetArrListForAddAtTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new ArrList(new int[] { 5, 6, 3 }),
                1 => new ArrList(4),
                2 => new ArrList(new int[] { 1, 2, 3, 4 }),
                _ => new ArrList(),
            };
        }

        public static int[] GetAddArrListForAddAtTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new int[] { 11, 2, 13, 24 },//L = 7
                1 => new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 },//L = 11
                2 => new int[] { 0 },//L = 5
                _ => new int[] { 1, 2, 3},//for negative
            };
        }

        public static int[] GetExpectedArrListForAddAtArrTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new int[] { 5, 11, 2, 13, 24, 6, 3 },
                1 => new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 4},
                2 => new int[] { 1, 2, 3, 0, 4 },
                _ => new int[] { },
            };
        }

        public static int[] GetExpectedArrListForAddAtTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new int[] { 5, 7, 6, 3 },
                1 => new int[] { 11, 4 },
                2 => new int[] { 1, 2, 5, 3, 4 },
                _ => new int[] { },
            };
        }

        public static ArrList GetArrListForSetTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new ArrList(new int[] { 5, 6, 3 }),
                1 => new ArrList(4),
                2 => new ArrList(new int[] { 1, 2, 3, 4 }),
                3 => new ArrList(new int[] {8, 9}),
                _ => new ArrList(),
            };
        }

        public static int[] GetExpectedArrListForSetTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new int[] { 5, 7, 3 },
                1 => new int[] { 11 },
                2 => new int[] { 1, 2, 5, 4 },
                3 => new int[] { 11, 9 },
                _ => new int[] { },
            };
        }

        public static ArrList GetArrListForRemoveFirstTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new ArrList(new int[] { 5, 6, 3 }),
                1 => new ArrList(4),
                2 => new ArrList(new int[] { 1, 2, 3, 4 }),
                3 => new ArrList(new int[] { 8, 9 }),
                _ => new ArrList(),
            };
        }

        public static int[] GetExpectedArrListForRemoveFirstTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new int[] { 6, 3 },
                1 => new int[] { },
                2 => new int[] { 2, 3, 4 },
                3 => new int[] { 9 },
                _ => new int[] { },
            };
        }

        public static ArrList GetArrListForRemoveLastTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new ArrList(new int[] { 5, 6, 3 }),
                1 => new ArrList(4),
                2 => new ArrList(new int[] { 1, 2, 3, 4 }),
                3 => new ArrList(new int[] { 8, 9 }),
                _ => new ArrList(),
            };
        }

        public static int[] GetExpectedArrListForRemoveLastTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new int[] { 5, 6},
                1 => new int[] { },
                2 => new int[] { 1, 2, 3},
                3 => new int[] { 8 },
                _ => new int[] { },
            };
        }

        public static ArrList GetArrListForRemoveAtTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new ArrList(new int[] { 5, 6, 3 }),
                1 => new ArrList(4),
                2 => new ArrList(new int[] { 1, 2, 3, 4 }),
                3 => new ArrList(new int[] { 8, 9 }),
                _ => new ArrList(),
            };
        }

        public static int[] GetExpectedArrListForRemoveAtTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new int[] { 6, 3 },
                1 => new int[] { },
                2 => new int[] { 1, 2, 4 },
                3 => new int[] { 8 },
                _ => new int[] { },
            };
        }

        public static ArrList GetArrListForRemoveFirstMultipleTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new ArrList(new int[] { 5, 6, 3, 98, 0, 100, 15 }),
                1 => new ArrList(4),
                2 => new ArrList(new int[] { 1, 2, 3, 4 }),
                _ => new ArrList(),
            };
        }

        public static int[] GetExpectedArrListForRemoveFirstMultipleTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new int[] { 98, 0, 100, 15 },
                1 => new int[] { },
                2 => new int[] { },
                _ => new int[] { },
            };
        }

        public static ArrList GetArrListForRemoveLastMultipleTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new ArrList(new int[] { 5, 6, 3, 98, 0, 100, 15 }),
                1 => new ArrList(4),
                2 => new ArrList(new int[] { 1, 2, 3, 4 }),
                _ => new ArrList(),
            };
        }

        public static int[] GetExpectedArrListForRemoveLastMultipleTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new int[] { 5, 6, 3, 98 },
                1 => new int[] { },
                2 => new int[] { },
                _ => new int[] { },
            };
        }

        public static ArrList GetArrListForRemoveAtMultipleTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new ArrList(new int[] { 5, 6, 3, 98, 0, 100, 15 }),
                1 => new ArrList(4),
                2 => new ArrList(new int[] { 1, 2, 3, 4 }),
                _ => new ArrList(),
            };
        }

        public static int[] GetExpectedArrListForRemoveAtMultipleTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new int[] { 5, 6, 100, 15 },
                1 => new int[] { },
                2 => new int[] { 1, 2, 3},
                _ => new int[] { },
            };
        }

        public static ArrList GetArrListForRemoveFirstOnValTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new ArrList(new int[] { 5, 98, 3, 98, 0, 100, 15 }),
                1 => new ArrList(4),
                2 => new ArrList(new int[] { 1, 2, 3, 4 }),
                _ => new ArrList(),
            };
        }

        public static int[] GetExpectedArrListForRemoveFirstOnValTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new int[] { 5, 3, 98, 0, 100, 15 },
                1 => new int[] { 4 },
                2 => new int[] { 1, 2, 3 },
                _ => new int[] { },
            };
        }

        public static ArrList GetArrListForRemoveAllTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new ArrList(new int[] { 5, 98, 3, 98, 0, 100, 15 }),
                1 => new ArrList(4),
                2 => new ArrList(new int[] { 1, 2, 3, 4 }),
                3 => new ArrList(new int[] { 5, 5, 5, 5 }),
                4 => new ArrList(new int[] { 3, 3, 1, 2, 3, 4, 5, 3, 8, 3 }),
                5 => new ArrList(new int[] { 3, 1, 2, 3, 3, 4, 5, 3, 3, 3, 8, 3 }),
                _ => new ArrList(),
            };
        }

        public static int[] GetExpectedArrListForRemoveAllTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new int[] { 5, 3, 0, 100, 15 },
                1 => new int[] { 4 },
                2 => new int[] { 1, 2, 3 },
                3 => new int[] { },
                4 => new int[] { 1, 2, 4, 5, 8 },
                5 => new int[] { 1, 2, 4, 5, 8 },
                _ => new int[] { },
            };
        }

        public static ArrList GetArrListForContainsTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new ArrList(new int[] { 5, 98, 3, 98, 0, 100, 15 }),
                1 => new ArrList(4),
                2 => new ArrList(new int[] { 1, 2, 3, 4 }),
                3 => new ArrList(new int[] { 5, 5, 5, 5 }),
                _ => new ArrList(),
            };
        }

        public static ArrList GetArrListForIndexOfTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new ArrList(new int[] { 5, 98, 3, 98, 0, 100, 15 }),
                1 => new ArrList(4),
                2 => new ArrList(new int[] { 1, 2, 3, 4 }),
                3 => new ArrList(new int[] { 5, 5, 5, 5 }),
                _ => new ArrList(),
            };
        }

        public static ArrList GetArrListForGetFirstAndLastAndGetTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new ArrList(new int[] { 5, 98, 3, 98, 0, 100, 15 }),
                1 => new ArrList(4),
                2 => new ArrList(new int[] { 1, 2, 3, 4 }),
                3 => new ArrList(new int[] { 5, 5, 5, 5 }),
                _ => new ArrList(),
            };
        }

        public static ArrList GetArrListForReverseTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new ArrList(new int[] { 5, 98, 3, 98, 0, 100, 15 }),
                1 => new ArrList(4),
                2 => new ArrList(new int[] { 1, 2, 3, 4 }),
                3 => new ArrList(new int[] { 5, 5, 5, 5 }),
                _ => new ArrList(),
            };
        }

        public static ArrList GetExpectedArrListForReverseTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new ArrList(new int[] { 15, 100, 0, 98, 3, 98, 5 }),
                1 => new ArrList(4),
                2 => new ArrList(new int[] { 4, 3, 2, 1 }),
                3 => new ArrList(new int[] { 5, 5, 5, 5 }),
                _ => new ArrList(),
            };
        }

        public static ArrList GetArrListForMaxAndMinAndTheirIndexesTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new ArrList(new int[] { 5, 98, 3, 98, 0, 100, 15 }),
                1 => new ArrList(4),
                2 => new ArrList(new int[] { 1, 2, 3, 4 }),
                3 => new ArrList(new int[] { 5, 5, 5, 5 }),
                _ => new ArrList(),
            };
        }

        public static ArrList GetArrListForSortAndSortDescTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new ArrList(new int[] { 5, 98, 3, 98, 0, 100, 15 }),
                1 => new ArrList(4),
                2 => new ArrList(new int[] { 1, 2, 3, 4 }),
                3 => new ArrList(new int[] { 4, 3, 2, 1 }),
                4 => new ArrList(new int[] { -4, 3, 9, -2, 1 }),
                5 => new ArrList(new int[] { 5, 5, 5, 5 }),
                _ => new ArrList(),
            };
        }

        public static ArrList GetExpectedArrListForSortTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new ArrList(new int[] { 0, 3, 5, 15, 98, 98, 100 }),
                1 => new ArrList(4),
                2 => new ArrList(new int[] { 1, 2, 3, 4 }),
                3 => new ArrList(new int[] { 1, 2, 3, 4 }),
                4 => new ArrList(new int[] { -4, -2, 1, 3, 9 }),
                5 => new ArrList(new int[] { 5, 5, 5, 5 }),
                _ => new ArrList(),
            };
        }

        public static ArrList GetExpectedArrListForSortDescTest(int arrayID)
        {
            return arrayID switch
            {
                0 => new ArrList(new int[] { 100, 98, 98, 15, 5, 3, 0 }),
                1 => new ArrList(4),
                2 => new ArrList(new int[] { 4, 3, 2, 1 }),
                3 => new ArrList(new int[] { 4, 3, 2, 1 }),
                4 => new ArrList(new int[] {9, 3, 1, -2, -4 }),
                5 => new ArrList(new int[] { 5, 5, 5, 5 }),
                _ => new ArrList(),
            };
        }
    }
}
