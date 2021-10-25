using ArrayListLibrary;
using Homework1;
using Homework2;
using Homework3;
using Homework4;
using Homework5;
using System;

namespace AllHomeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrList aList = new ArrList();
            ArrList aList1 = new ArrList(new int[] { 1, 2, 3 });
            aList.AddFirst(aList1);
            aList.AddAt(2, new int[] { 7, 9, 8 });
            aList.RemoveAll(8);
            aList.AddLast(aList1);
            Console.ReadLine();
        }
    }
}
