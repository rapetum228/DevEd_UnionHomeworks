using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    interface ILists
    {
        public int GetLength();

        public int[] ToArray();
        public void AddLast(int val);

        //public void AddLast(LinkedList list);
        

        public void AddFirst(int val);

        //public void AddFirst(LinkedList list);

        public void AddAt(int idx, int val);

        //public void AddAt(int idx, LinkedList list);

        public void Set(int idx, int val);

        public void RemoveFirst();
        public void RemoveLast();
        public void RemoveAt(int idx);
        public void RemoveFirstMultiple(int n);

        public void RemoveLastMultiple(int n);

        public void RemoveAtMultiple(int idx, int n);

        public int RemoveFirst(int val);

        public int RemoveAll(int val);

        public bool Contains(int val);
        public int IndexOf(int val);

        public int GetFirst();

        public int GetLast();

        public int Get(int idx);

        public void Reverse();

        public int Max();

        public int Min();

        public int IndexOfMax();

        public int IndexOfMin();

        public void Sort();

        public void SortDesc();

        
    }
}
