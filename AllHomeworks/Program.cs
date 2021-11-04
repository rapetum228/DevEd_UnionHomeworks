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
            ArrList aList1 = new ArrList(new int[] { 1, 2, 3 });
            aList1.AddFirst(228);
            aList1.AddFirst(228);
            aList1.AddFirst(228);
            aList1.AddFirst(228);
            aList1.AddFirst(new int[] { 1, 2, 3, 4, 5 });
            aList1.AddLast(-228);
            aList1.AddLast(-228);
            aList1.AddLast(-228);
            aList1.AddLast(-228);*/
            ArrList aList = new ArrList(new int[] { 1, 2, 3, 4, 5, 1, 2, 3, 3, 4, 1, 2, 3, 4, 5});
            //{ 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 1, 2, 3, 1, 2}

            int[] indexes = aList.IndexesOf(3);
            //aList.RemoveAll(3);

            /*
            LinkedList lList = new LinkedList(1);
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
            DoublyLinkedList dLList = new DoublyLinkedList(new int[] { 1, 2, 3 });
            DoublyLinkedList clone = dLList.Clone();
            DoublyLinkedList dLList1 = new DoublyLinkedList(new int[] { -3, -2, -1, 0, -4, -5});
            //-3 0 -1 -2 
            dLList.AddLast(4);
            dLList.AddLast(dLList1);
            dLList.AddFirst(0);
            dLList.AddFirst(dLList1);
            dLList.AddAt(3, 228);
            dLList.AddAt(5, dLList1);
            dLList.RemoveAt(5);
            dLList.RemoveFirst();
     /*
            LinkedList lList12 = new LinkedList(new int[] { 1, -2, 5, 3, -1, -4,  0, 2});
            //lList12.RemoveLastMultiple(3);
            //lList12.Reverse();
            //lList12.SortDesc();
            lList12.SortCocktail();
            LinkedList ll = lList12.Clone();
            ll.AddLast(6);*/
            
        }
    }
}
