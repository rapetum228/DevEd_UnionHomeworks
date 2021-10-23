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

            Console.ReadLine();
        }
    }
}
