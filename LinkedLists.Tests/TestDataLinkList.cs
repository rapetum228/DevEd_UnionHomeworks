using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists.Tests
{
    class TestDataLinkList
    {
        public static LinkList GetListForToArrayAndGetLengthTest(int ID)
        {
            return ID switch
            {
                0 => new LinkList(new LinkList(1)),
                1 => new LinkList( 4 ),
                2 => new LinkList(new int[] { 1, 2, 3, 4 }),
                _ => new LinkList(),
            };
        }

        public static int[] GetExpectedArrayForToArrayTest(int ID)
        {
            return ID switch
            {
                0 => new int[] { 1 },
                1 => new int[] { 4 },
                2 => new int[] { 1, 2, 3, 4 },
                _ => new int[] { },
            };
        }

        public static LinkList GetListForAddLastTest(int ID)
        {
            return ID switch
            {
                0 => new LinkList(new LinkList(1)),
                1 => new LinkList(4),
                2 => new LinkList(new int[] { 1, 2, 3, 4 }),
                _ => new LinkList(),
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

        public static LinkList GetAddListForAddLastTest(int ID)
        {
            return ID switch
            {
                0 => new LinkList(new LinkList(new int[] { 1, 2, 3, 4 })),
                1 => new LinkList(),
                2 => new LinkList(1),
                _ => new LinkList(new LinkList(new int[] { 4 })),
            };
        }
        public static LinkList GetExpectedListForAddLastTest(int ID)
        {
            return ID switch
            {
                0 => new LinkList(new LinkList(new int[] { 1, 1, 2, 3, 4 })),
                1 => new LinkList(4),
                2 => new LinkList(new int[] { 1, 2, 3, 4, 1 }),
                _ => new LinkList(4),
            };
        }

        public static LinkList GetListForAddFirstTest(int ID)
        {
            return ID switch
            {
                0 => new LinkList(new LinkList(1)),
                1 => new LinkList(4),
                2 => new LinkList(new int[] { 1, 2, 3, 4 }),
                _ => new LinkList(),
            };
        }

        public static int[] GetExpectedArrayForAddFirstTest(int ID)
        {
            return ID switch
            {
                0 => new int[] { 2, 1},
                1 => new int[] { 12, 4},
                2 => new int[] { 5, 1, 2, 3, 4 },
                _ => new int[] { 0 },
            };
        }

        public static LinkList GetAddListForAddFirstTest(int ID)
        {
            return ID switch
            {
                0 => new LinkList(new LinkList(new int[] { 1, 2, 3, 4 })),
                1 => new LinkList(),
                2 => new LinkList(1),
                _ => new LinkList(new int[] { 4 }),
            };
        }
        public static LinkList GetExpectedListForAddFirstTest(int ID)
        {
            return ID switch
            {
                0 => new LinkList(new LinkList(new int[] { 1, 2, 3, 4, 1 })),
                1 => new LinkList(4),
                2 => new LinkList(new int[] { 1, 1, 2, 3, 4 }),
                _ => new LinkList(4),
            };
        }

        public static LinkList GetListForAddAtTest(int ID)
        {
            return ID switch
            {
                0 => new LinkList(new LinkList(1)),
                1 => new LinkList(4),
                2 => new LinkList(new int[] { 1, 2, 3, 4 }),
                3 => new LinkList(new int[] { 1, 2, 3, 4 }),
                4 => new LinkList(new int[] { 1, 2, 3, 4 }),
                _ => new LinkList(),
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
                _ => new int[] { 228 },
            };
        }

        public static LinkList GetAddListForAddAtTest(int ID)
        {
            return ID switch
            {
                0 => new LinkList(new LinkList(new int[] { 1, 2, 3, 4 })),
                1 => new LinkList(),
                2 => new LinkList(1),
                3 => new LinkList(new int[] { 11, 12 }),
                4 => new LinkList(new int[] { 4, 5, 6}),
                _ => new LinkList(new int[] { 4 }),
            };
        }
        public static LinkList GetExpectedListForAddAtTest(int ID)
        {
            return ID switch
            {
                0 => new LinkList(new LinkList(new int[] { 1, 2, 3, 4, 1 })),
                1 => new LinkList(4),
                2 => new LinkList(new int[] { 1, 1, 2, 3, 4 }),
                3 => new LinkList(new int[] { 1, 2, 11, 12, 3, 4 }),
                4 => new LinkList(new int[] { 4, 5, 6, 1, 2, 3, 4 }),
                _ => new LinkList(4),
            };
        }


        public static LinkList GetListForSetTest(int ID)
        {
            return ID switch
            {
                0 => new LinkList(new LinkList(new int[] { 1, 2, 3, 4 })),
                1 => new LinkList(1),
                2 => new LinkList(new int[] { 4, 5, 6 }),
                _ => new LinkList(new int[] { 4 }),
            };
        }
        public static LinkList GetExpectedListForSetTest(int ID)
        {
            return ID switch
            {
                0 => new LinkList(new LinkList(new int[] { 1, 2, 0, 4 })),
                1 => new LinkList(4),
                2 => new LinkList(new int[] { 4, 5, 0 }),
                _ => new LinkList(4),
            };
        }

        public static LinkList GetListForRemoveFirstLastAtTest(int ID)
        {
            return ID switch
            {
                0 => new LinkList(new LinkList(new int[] { 1, 2, 3, 4 })),
                1 => new LinkList(1),
                2 => new LinkList(new int[] { 4, 5, 6 }),
                3 => new LinkList(new LinkList(new int[] { 1, 2, 3, 4 })),
                _ => new LinkList(new int[] { 4 }),
            };
        }
        public static LinkList GetExpectedListForRemoveFirstTest(int ID)
        {
            return ID switch
            {
                0 => new LinkList(new LinkList(new int[] { 2, 3, 4 })),
                1 => new LinkList(),
                2 => new LinkList(new int[] { 5, 6}),
                _ => new LinkList(),
            };
        }

        public static LinkList GetExpectedListForRemoveLastTest(int ID)
        {
            return ID switch
            {
                0 => new LinkList(new LinkList(new int[] { 1, 2, 3})),
                1 => new LinkList(),
                2 => new LinkList(new int[] { 4, 5}),
                _ => new LinkList(),
            };
        }

        public static LinkList GetExpectedListForRemoveAtTest(int ID)
        {
            return ID switch
            {
                0 => new LinkList(new LinkList(new int[] { 1, 2, 4 })),
                1 => new LinkList(),
                2 => new LinkList(new int[] { 5, 6 }),
                3 => new LinkList(new LinkList(new int[] { 1, 2, 3})),
                _ => new LinkList(new int[] { }),
            };
        }
    }
}
