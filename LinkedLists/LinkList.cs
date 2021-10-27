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
        public int LengthList { get; private set; }
        public LinkList(int value)
        {
            LengthList = 1;
            Head = new Node
            {
                Value = value
            };
            Tail = Head;
        }

        public LinkList(LinkList list)
        {
            Head = new Node
            {
                Value = list.Head.Value,
            };
            Node tempUS = Head;
            LengthList = 1; 
            
            Node temp = list.Head;
            while (temp.Next != null)
            {
                temp = temp.Next;
                Node current = new Node { Value = temp.Value };
                tempUS.Next = current;
                tempUS = tempUS.Next;
                LengthList++;
            }
            Tail = tempUS;//new Node { Value = list.Tail.Value, Next = null };
        }

        public void AddLast(int val)
        {
            LengthList++;
            Node current = new Node { Value = val};
            Tail.Next = current;
            Tail = current;
        }
        
        public void AddLast(LinkList list)
        {
            LengthList += list.LengthList;
            LinkList temp = new LinkList(list);
            Tail.Next = temp.Head;
            Tail = temp.Tail;
            //list = temp;
        }
       
        public void AddFirst(int val)
        {
            LengthList++;
            Node current = new Node { Value = val };
            current.Next = Head;
            Head = current;
        }

        public void AddFirst(LinkList list)
        {
            LengthList += list.LengthList;
            LinkList temp = new LinkList(list);
            temp.Tail.Next = Head;
            Head = temp.Head;
            //list = temp;
        }

        public void AddAt(int idx, int val)
        {
            LengthList++;
            Node current = new Node { Value = val };
            Node temp = Head;
            for (int i = 0; i < idx-1; i++)
                temp = temp.Next;

            current.Next = temp.Next;
            temp.Next = current;
            //temp.Next = new Node { Value = 228 };
            //temp.Next = new Node { Value = 229 };
            //temp.Next = current;
        }

        public void AddAt(int idx, LinkList list)
        {
            LinkList newList = new LinkList(list);
            LengthList += list.LengthList;
            Node temp = Head;
            for (int i = 0; i < idx - 1; i++)
                temp = temp.Next;

            newList.Tail.Next = temp.Next;
            temp.Next = newList.Head;
        }

        public void Set(int idx, int val)
        {
            Node temp = Head;
            for (int i = 0; i < idx - 1; i++)
                temp = temp.Next;

            temp.Value = val;
        }

        public void RemoveFirst()
        {
            LengthList--;
            Head = Head.Next;
        }
        public void RemoveLast()
        {
            LengthList--;
            Node temp = Head;
            while (temp.Next.Next != null)
                temp = temp.Next;

            temp.Next = null;
            Tail = temp;
        }

        public void RemoveAt(int idx)
        {
            LengthList--;
            Node temp = Head;
            for (int i = 0; i < idx - 1; i++)
                temp = temp.Next;

            temp.Next = temp.Next.Next;
        }

        public void RemoveFirstMultiple(int n)
        {
            LengthList -= n;
            for (int i = 0; i < n; i++)
                Head = Head.Next;
        }

        public void RemoveLastMultiple(int n)
        {
            LengthList -= n;
            Node temp = Head;
            for (int i = 0; i < LengthList-1; i++)
            {
                temp = temp.Next;
            }
            Tail = temp;
            temp.Next = null;

        }

        public void RemoveAtMultiple(int idx, int n)
        {
            LengthList -= n;
            Node temp = Head;
            for (int i = 0; i < idx-1 ; i++)
                temp = temp.Next;
            
            Node current = temp;

            for (int i = 0; i < n+1; i++)
                temp = temp.Next;
            current.Next = temp;
        }

        public int RemoveFirst(int val)//поправить
        {
            if (Head.Value == val)
            {
                LengthList--;
                Head = Head.Next;
                return 0;
            }
                
            Node temp = Head;
            int index = 0;
            while (temp.Next.Value != val)
            {
                index++;
                if (temp.Next == null)
                    return -1;
                temp = temp.Next;
            }  
            temp.Next = temp.Next.Next;
            LengthList--;
            return index;
        }

        public int RemoveAll(int val)
        {
            int numbersOfRemoveElements = 0;
            while (Head.Value == val)
            {
                numbersOfRemoveElements++;
                Head = Head.Next;
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
            
            LengthList -= numbersOfRemoveElements;
            return numbersOfRemoveElements;
        }

        public bool Contains(int val)
        {
            if (Head.Value == val)
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
            if (Head.Value == val)
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
            return Head.Value;
        }

        public int GetLast()
        {
            return Tail.Value;
        }

        public int Get(int idx)
        {
            Node temp = Head;
            for (int i = 0; i < idx; i++)
                temp = temp.Next;
            return temp.Value;
        }

        public void Reverse()//кажись всё..
        {
            int fakeLength = LengthList;
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
            int min = this.Min();
            LinkList sortList = new LinkList(min);
            LinkList copyThis = new LinkList(this);
            while(copyThis.LengthList > 1)
            {
                copyThis.RemoveFirst(min);
                min = copyThis.Min();
                sortList.AddLast(min);
            }
            Head = sortList.Head;
            Tail = sortList.Tail;
        }

        public void SortDesc()
        {
            int max = this.Max();
            LinkList sortList = new LinkList(max);
            LinkList copyThis = new LinkList(this);
            while (copyThis.LengthList > 1)
            {
                copyThis.RemoveFirst(max);
                max = copyThis.Max();
                sortList.AddLast(max);
            }
            Head = sortList.Head;
            Tail = sortList.Tail;
        }
    }
}
