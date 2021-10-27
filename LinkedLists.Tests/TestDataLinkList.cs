using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists.Tests
{
    class TestDataLinkList
    {
        public static LinkList GetListForToArrayTest(int ID)
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
    }
}
