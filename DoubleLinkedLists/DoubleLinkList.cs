using System;

namespace DoubleLinkedLists
{
    public class DoubleLinkList
    {
        public DNode Head { get; private set; }
        public DNode Tail { get; private set; }

        public DoubleLinkList()
        {
            Head = null;
            Tail = Head;
        }

        public DoubleLinkList(int val)
        {
            Head = new DNode
            {
                Value = val,
                Previous = null,
                Next = null,
            };
            Tail = Head;
        }

        public DoubleLinkList(int[] arr)
        {
            Head = new DNode
            {
                Value = arr[0],
                Previous = null,
                Next = null,
            };
            DNode temp = Head;
            for (int i = 1; i < arr.Length; i++)
            {
                temp.Next = new DNode { Value = arr[i], Previous = temp };
                temp = temp.Next;
            }
            Tail = temp;
        }

        public DoubleLinkList(DoubleLinkList list)
        {
            Head = new DNode
            {
                Value = list.Head.Value,
                Previous = null,
                Next = null,
            };
            DNode temp = Head;
            DNode tempList = list.Head;
            while (tempList.Next != null)
            {
                tempList = tempList.Next;
                temp.Next = new DNode { Value = tempList.Value, Previous = temp };
                temp = temp.Next;
            }
            Tail = temp;
        }

        public int GetLength()
        {
            int lengthList = 0;
            DNode temp = Head;
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
            DNode temp = Head;
            int indexArray = 0;
            while (temp != null)
            {
                arr[indexArray] = temp.Value;
                temp = temp.Next;
                indexArray++;
            }

            return arr;
        }

        public void AddLast(int val)
        {
            //LengthList++;
            DNode current = new DNode { Value = val, Previous = Tail };
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

        public void AddLast(DoubleLinkList list)
        {
            if (list.Head == null)
            {
                return;
            }

            DNode tempHead = list.Head;
            DNode tempTail = list.Tail;

            if (Head != null)
            {
                Tail.Next = tempHead;
                Tail.Next.Previous = Tail;
                Tail = tempTail;
            }
            else
            {
                Head = tempHead;
                Tail = tempTail;
            }

        }

        public void AddFirst(int val)
        {
            DNode current = new DNode { Value = val, Next = Head };
            Head = current;
            Head.Next.Previous = current;
        }

        public void AddFirst(DoubleLinkList list)
        {
            if (list.Head == null)
            {
                return;
            }
            // LengthList += list.LengthList;
            DoubleLinkList temp = new DoubleLinkList(list);
            temp.Tail.Next = Head;
            Head = temp.Head;
            //list = temp;
        }
    }
}
