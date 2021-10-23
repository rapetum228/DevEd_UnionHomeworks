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
        /*
         Сделано:
        3 конструктора
        GetLength
        ToArray
        AddFirst(int val)
        AddLast(int val)
        AddAt(int idx, int val)
        Set(int idx)
        RemoveFirst
        RemoveLast
        RemoveAt(int idx)

         */
        static void Main(string[] args)
        {
            ArrayList aList = new ArrayList(new int[]{1, 2, 3 });
            aList.AddFirst(45);
            aList.AddLast(9);
            aList.AddFirst(15);
            aList.AddFirst(15);
            aList.AddFirst(15);
            aList.AddLast(15);
            aList.AddAt(9, 32);
            aList.AddAt(0, 32);
            aList.RemoveFirst();
            aList.RemoveFirst();
            aList.RemoveLast();
            aList.RemoveAt(3);
            aList.RemoveAt(0);
            aList.AddAt(2, 32);
            aList.AddAt(4, 32);
            aList.AddLast(9);
            aList.AddLast(9);
            aList.AddLast(9);
            aList.AddLast(9);
            aList.AddLast(9);
            aList.RemoveAt(5);
            aList.RemoveAt(3);
            aList.RemoveAt(5);
            aList.RemoveAt(3);
            aList.RemoveAt(5);
            aList.RemoveAt(3);

            Console.ReadLine();
        }
    }
}
