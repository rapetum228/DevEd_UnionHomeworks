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
        AddFirst(int idx, arr)
        AddLast(int idx, arr)
        AddAt(int idx, arr)
        Set(int idx)
        RemoveFirst
        RemoveLast
        RemoveAt(int idx)

         */
        static void Main(string[] args)
        {
            ArrayList aList = new ArrayList(new int[]{1, 2, 3 });

            aList.AddFirst(new int[] { 4, 5, 6 });
            aList.AddAt(3, new int[] { 4, 5, 6 });
            aList.AddAt(3, new int[] { 8, 9, 10 });
            Console.ReadLine();
        }
    }
}
