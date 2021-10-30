using ArrayListLibrary;
using DoubleLinkedLists;
using Homework1;
using Homework2;
using Homework3;
using Homework4;
using Homework5;
using LinkedLists;
using System;

namespace AllHomeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ArrList aList = new ArrList();
            ArrList aList1 = new ArrList(new int[] { 1, 2, 3 });
            aList.AddFirst(aList1);
            aList.AddAt(2, new int[] { 7, 9, 8 });
            aList.RemoveAll(8);
            aList.AddLast(aList1);
            Console.ReadLine();
            */
            /*
            LinkList lList = new LinkList(1);
            lList.AddLast(2);
            lList.AddLast(3);
            lList.AddLast(4);
            lList.AddFirst(0);
            lList.AddAt(2, -2);
            LinkList lList1 = new LinkList(-9);
            lList1.AddLast(-11);
            lList1.AddFirst(-8);
            lList1.AddAt(2, -10);
            lList.AddFirst(lList1);
            lList.AddAt(4, lList1);
            lList.Set(4, 228);
            lList.RemoveFirst();
            lList.RemoveLast();
            lList.RemoveAt(2);
            lList.RemoveAtMultiple(3, 3);
            lList.RemoveAll(-8);
            lList.GetFirst();
            lList.GetLast();
            lList.Get(2);
            lList.Reverse();
            lList.Max();
            lList.Min();
            lList.IndexOfMax();
            lList.IndexOfMin();
            lList.Sort();
            lList1.SortDesc();
            lList.Sort();
            lList1.Sort();
            lList.SortDesc();
            lList.GetLength();
            int[] arr = lList.ToArray();

            LinkList lList12 = new LinkList(new int[] { 1, 2, 3, 4, 5 });
            */

            DoubleLinkList dLList = new DoubleLinkList(new int[] { 1, 2, 3 });

            DoubleLinkList dLList1 = new DoubleLinkList(dLList);

            dLList.AddLast(4);
            dLList.AddLast(new DoubleLinkList(new int[] {5, 6 }));
            dLList.AddFirst(0);
        }
    }
}
