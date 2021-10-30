using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class LinkList
    {
        public Node Head { get; private set; }
        public Node Tail { get; private set; }
        //public int LengthList { get; private set; }

        public LinkList()
        {
            //LengthList = 0;
            Head = null;
            Tail = Head;
        }
        public LinkList(int value)
        {
           // LengthList = 1;
            Head = new Node
            {
                Value = value
            };
            Tail = Head;
        }

        public LinkList(LinkList list)
        {
            if (list.Head == null)
            {
                Head = null;
                Tail = Head;
                return;
            }
            Head = new Node
            {
                Value = list.Head.Value,
            };
            Node nodeNewLink = Head;
            //LengthList = 1; 
            
            Node temp = list.Head;
            while (temp.Next != null)
            {
                temp = temp.Next;
                Node current = new Node { Value = temp.Value };
                nodeNewLink.Next = current;
                nodeNewLink = nodeNewLink.Next;
                //LengthList++;
            }
            Tail = nodeNewLink;//new Node { Value = list.Tail.Value, Next = null };
        }

        public LinkList(int[] arr)
        {
            if (arr.Length == 0)
            {
                Head = null;
                Tail = Head;
                return;
            }
            Head = new Node
            {
                Value = arr[0],
            };
            Node temp = Head;
            for (int i = 1; i < arr.Length; i++)
            {
                temp.Next = new Node { Value = arr[i] };
                temp = temp.Next;
            }
            Tail = temp;
            
        }

        public int GetLength()
        {
            int lengthList = 0;
            Node temp = Head;
            while (temp != null)
            {
                lengthList++;
                temp = temp.Next;
            }
            return lengthList;
        }

        public int[] ToArray()
        {
            int[] arr = new int[this.GetLength()];
            Node temp = Head;
            for (int i = 0; i < this.GetLength(); i++)
            {
                arr[i] = temp.Value;
                temp = temp.Next;
            }

            return arr;
        }
        public void AddLast(int val)
        {
            //LengthList++;
            Node current = new Node { Value = val};
            if (Head != null)
            {
                Tail.Next = current;
                Tail = current;
            }
            else
            {
                Head = current;
                Tail = current;
            }
            
            
        }
        
        public void AddLast(LinkList list)
        {
            if (list.Head == null)
            {
                return;
            }
           
            LinkList temp = new LinkList(list);
            
            if (Head != null)
            {
                Tail.Next = temp.Head;
                Tail = temp.Tail;
            }
            else
            {
                Head = temp.Head;
                Tail = temp.Tail;
            }
           
        }
       
        public void AddFirst(int val)
        {
            //LengthList++;
            Node current = new Node { Value = val };
            current.Next = Head;
            Head = current;
        }

        public void AddFirst(LinkList list)
        {
            if (list.Head == null)
            {
                return;
            }
           // LengthList += list.LengthList;
            LinkList temp = new LinkList(list);
            temp.Tail.Next = Head;
            Head = temp.Head;
            //list = temp;
        }

        public void AddAt(int idx, int val)
        {
            if (idx < 0 || Head == null)
            {
                throw new IndexOutOfRangeException("Index out of range list length");
            }
            if (idx == 0)
            {
                this.AddFirst(val);
                return;
            }
            //LengthList++;
            Node current = new Node { Value = val };
            Node temp = Head;
            for (int i = 0; i < idx-1; i++)
            {
                if (temp == null && idx != 0)
                {
                    throw new IndexOutOfRangeException("Index out of range list length");
                }
                temp = temp.Next;
            }
            if (Head.Next == null)
            {
                current.Next = Head;
                Head = current;
                return;
            }
            current.Next = temp.Next;
            temp.Next = current;
            //temp.Next = new Node { Value = 228 };
            //temp.Next = new Node { Value = 229 };
            //temp.Next = current;
        }

        public void AddAt(int idx, LinkList list)
        {
            if (idx >= this.GetLength() || Head == null)
            {
                throw new IndexOutOfRangeException("Index out of range list length");
            }
            if (idx == 0)
            {
                this.AddFirst(list);
                return;
            }
            LinkList newList = new LinkList(list);
            //LengthList += list.LengthList;
            Node temp = Head;
            for (int i = 0; i < idx - 1; i++)
                temp = temp.Next;
            if (Head.Next == null)
            {
                newList.Tail.Next = Head;
                Head = newList.Head; ;
                return;
            }
            newList.Tail.Next = temp.Next;
            temp.Next = newList.Head;
        }

        public void Set(int idx, int val)
        {
            if (idx >= this.GetLength() || Head == null)
            {
                throw new IndexOutOfRangeException("Index out of range list length");
            }

            Node temp = Head;
            for (int i = 0; i < idx; i++)
                temp = temp.Next;

            temp.Value = val;
        }

        public void RemoveFirst()
        {
            if (Head == null)
            {
                return;
            }
           // LengthList--;
            Head = Head.Next;
        }
        public void RemoveLast()
        {
            if (Head == null || Head.Next == null)
            {
                Head = null;
                return;
            }
            //LengthList--;
            Node temp = Head;
            while (temp.Next.Next != null)
                temp = temp.Next;

            temp.Next = null;
            Tail = temp;
        }

        public void RemoveAt(int idx)
        {
            if (Head == null || idx >= this.GetLength())
            {
                throw new IndexOutOfRangeException("Index out of range list length");
            }
            if (idx == 0 && Head.Next == null)
            {
                Head = null;
                return;
            }
            if (idx == 0)
            {
                this.RemoveFirst();
                return;
            }
            else if (idx == this.GetLength() - 1)
            {
                this.RemoveLast();
                return;
            }
            
            //LengthList--;
            Node temp = Head;
            for (int i = 0; i < idx - 1; i++)
                temp = temp.Next;

            temp.Next = temp.Next.Next;
        }

        public void RemoveFirstMultiple(int n)
        {
            if (n >= this.GetLength() || this.Head == null)
            {
                Head = null;
                Tail = Head;
                return;
            }

            for (int i = 0; i < n; i++)
                Head = Head.Next;
        }

        public void RemoveLastMultiple(int n)
        {
            if (n >= this.GetLength() || this.Head == null)
            {
                Head = null;
                Tail = Head;
                return;
            }

            Node temp = Head;
            for (int i = 0; i < this.GetLength()-1-n; i++)
            {
                temp = temp.Next;
            }
            Tail = temp;
            temp.Next = null;

        }

        public void RemoveAtMultiple(int idx, int n)
        {
            if (idx >= this.GetLength() || this.Head == null)
            {
                throw new IndexOutOfRangeException("Index out of range list length");
            }
            if (idx == 0)
            {
                this.RemoveFirstMultiple(n);
                return;
            }
            else if (idx == this.GetLength() - 1)
            {
                this.RemoveLastMultiple(n);
                return;
            }
            if (n + idx >= this.GetLength())
            {
                n = this.GetLength() - idx;
            }

            Node temp = Head;
            for (int i = 0; i < idx-1 ; i++)
                temp = temp.Next;
            
            Node current = temp;

            for (int i = 0; i < n+1; i++)
                temp = temp.Next;
            current.Next = temp;
        }

        public int RemoveFirst(int val)
        {
            if (Head == null)
                return -1;
            else if (Head.Value == val)
            {
                Head = Head.Next;
                return 0;
            }

            Node temp = Head;
            int index = 0;
            while (temp.Next != null && temp.Next.Value != val)
            {
                index++; 
                temp = temp.Next;
            }

            if (temp.Next == null)
            {
                return -1;
            }
            temp.Next = temp.Next.Next;
            return index+1;
        }

        public int RemoveAll(int val)
        {
            int numbersOfRemoveElements = 0;
            while (Head != null &&  Head.Value == val  )
            {
                numbersOfRemoveElements++;
                Head = Head.Next;
            }
            if (Head == null)
            {
                return numbersOfRemoveElements;
            }
            Node temp = Head;

            while (temp.Next != null)
            {
                if (temp.Next.Value == val)
                {
                    numbersOfRemoveElements++;
                    temp.Next = temp.Next.Next;
                }
                else { temp = temp.Next; }
            }
            
            //LengthList -= numbersOfRemoveElements;
            return numbersOfRemoveElements;
        }

        public bool Contains(int val)
        {
            if (Head == null)
                return false;
            else if (Head.Value == val)
                return true;
            Node temp = Head;

            while (temp.Value != val)
            {
                if (temp.Next == null)
                    return false;
                temp = temp.Next;
            }

            return true;
        }

        public int IndexOf(int val)
        {
            if (Head == null)
                return -1;
            else if (Head.Value == val)
                return 0;
            Node temp = Head;
            int index = 0;
            while (temp.Value != val)
            {
                if (temp.Next == null)
                    return -1;
                temp = temp.Next;
                index++;
            }

            return index;
        }

        public int GetFirst()
        {
            if (Head == null)
            {
                throw new IndexOutOfRangeException("List is empty");
            }
            return Head.Value;
        }

        public int GetLast()
        {
            if (Head == null)
            {
                throw new IndexOutOfRangeException("List is empty");
            }
            return Tail.Value;
        }

        public int Get(int idx)
        {
            if (Head == null)
            {
                throw new IndexOutOfRangeException("List is empty");
            }
            if (idx >= this.GetLength())
            {
                throw new IndexOutOfRangeException("Entry index out of range length list");
            }
            Node temp = Head;
            for (int i = 0; i < idx; i++)
                temp = temp.Next;
            return temp.Value;
        }

        public void Reverse()//кажись всё..
        {
            if (Head == null)
            {
                return;
            }
            int fakeLength = this.GetLength();
            Node tempTail = Tail;
            while (fakeLength > 1)
            {
                Node temp = Head;
                for (int i = 0; i < fakeLength-2; i++)
                {
                    temp = temp.Next;
                }
                fakeLength--;
                tempTail.Next = new Node {Value = temp.Value };
                tempTail = tempTail.Next;
            }
            Head = Tail;
            Tail = new Node { Value = tempTail.Value };
        }

        public int Max()
        {
            if (Head == null)
            {
                throw new IndexOutOfRangeException("List is empty");
            }

            Node temp = Head;
            int max = Head.Value;
            while (temp.Next != null)
            {
                temp = temp.Next;
                if (max < temp.Value )
                {
                    max = temp.Value;
                }
            }
            return max;
        }

        public int Min()
        {
            if (Head == null)
            {
                throw new IndexOutOfRangeException("List is empty");
            }
            Node temp = Head;
            int min = Head.Value;
            while (temp.Next != null)
            {
                temp = temp.Next;
                if (min > temp.Value)
                {
                    min = temp.Value;
                }
            }
            return min;
        }

        public int IndexOfMax()
        {
            if (Head == null)
            {
                throw new IndexOutOfRangeException("List is empty");
            }
            Node temp = Head;
            int max = Head.Value;
            int indexOfMax = 0;
            int index = 0;
            while (temp.Next != null)
            {
                index++;
                temp = temp.Next;
                if (max < temp.Value)
                {
                    indexOfMax = index;
                    max = temp.Value;
                }
            }
            return indexOfMax;
        }

        public int IndexOfMin()
        {
            if (Head == null)
            {
                throw new IndexOutOfRangeException("List is empty");
            }
            Node temp = Head;
            int min = Head.Value;
            int indexOfMin = 0;
            int index = 0;
            while (temp.Next != null)
            {
                index++;
                temp = temp.Next;
                if (min > temp.Value)
                {
                    indexOfMin = index;
                    min = temp.Value;
                }
            }
            return indexOfMin;
        }

        public void Sort()
        {
            if (Head == null)
            {
                return;
            }
            int lengthList = this.GetLength();
            int min = this.Min();
            LinkList sortList = new LinkList(min);
            LinkList copyThis = new LinkList(this);
            while(lengthList > 1)
            {
                copyThis.RemoveFirst(min);
                min = copyThis.Min();
                sortList.AddLast(min);
                lengthList--;
            }
            Head = sortList.Head;
            Tail = sortList.Tail;
        }

        public void SortDesc()
        {
            if (Head == null)
            {
                return;
            }
            int lengthList = this.GetLength();
            int max = this.Max();
            LinkList sortList = new LinkList(max);
            LinkList copyThis = new LinkList(this);
            while (lengthList > 1)
            {
                copyThis.RemoveFirst(max);
                max = copyThis.Max();
                sortList.AddLast(max);
                lengthList--;
            }
            Head = sortList.Head;
            Tail = sortList.Tail;
        }

        public override bool Equals(object obj)
        {
            return obj is LinkList list &&
                   EqualityComparer<Node>.Default.Equals(Head, list.Head) &&
                   EqualityComparer<Node>.Default.Equals(Tail, list.Tail);// &&
                   //LengthList == list.LengthList;
        }
    }
}
