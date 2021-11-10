using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    interface ILists<T>
    {
        public int GetLength();

        public T[] ToArray();
        public void AddLast(T val);

        //public void AddLast(LinkedList list);
        

        public void AddFirst(T val);

        //public void AddFirst(LinkedList list);

        public void AddAt(int idx, T val);

        //public void AddAt(int idx, LinkedList list);

        public void Set(int idx, T val);

        public void RemoveFirst();
        public void RemoveLast();
        public void RemoveAt(int idx);
        public void RemoveFirstMultiple(int n);

        public void RemoveLastMultiple(int n);

        public void RemoveAtMultiple(int idx, int n);

        public int RemoveFirst(T val);

        public int RemoveAll(T val);

        public bool Contains(T val);
        public int IndexOf(T val);

        public T GetFirst();

        public T GetLast();

        public T Get(int idx);

        public void Reverse();

        public T Max();

        public T Min();

        public int IndexOfMax();

        public int IndexOfMin();

        public void Sort();

        public void SortDesc();

        
    }
}
