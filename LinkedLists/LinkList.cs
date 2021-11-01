﻿using System;
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

        public LinkList()
        {
            Head = null;
            Tail = Head;
        }
        public LinkList(int value)
        {

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
            
            Node temp = list.Head;
            while (temp.Next != null)
            {
                temp = temp.Next;
                Node current = new Node { Value = temp.Value };
                nodeNewLink.Next = current;
                nodeNewLink = nodeNewLink.Next;
            }
            Tail = nodeNewLink;
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
            LinkList temp = new LinkList(list);
            temp.Tail.Next = Head;
            Head = temp.Head;
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
            current.Next = temp.Next;
            temp.Next = current;

        }

        public void AddAt(int idx, LinkList list)
        {
            if (idx < 0 || Head == null)
            {
                throw new IndexOutOfRangeException("Index out of range list length");
            }
            if (idx == 0)
            {
                this.AddFirst(list);
                return;
            }
            LinkList newList = new LinkList(list);

            Node temp = Head;
            for (int i = 0; i < idx - 1; i++)
            {
                if (temp == null)
                {
                    throw new IndexOutOfRangeException("Index out of range list length");
                }
                temp = temp.Next;
            }
            newList.Tail.Next = temp.Next;
            temp.Next = newList.Head;
        }

        public void Set(int idx, int val)
        {
            if (idx < 0 || Head == null)
                throw new IndexOutOfRangeException("Index out of range list length");

            Node temp = Head;
            for (int i = 0; i < idx; i++)
            {
                if (temp == null)
                    throw new IndexOutOfRangeException("Index out of range list length");
                
                temp = temp.Next;
            }

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
            if (idx < 0 || Head == null )
            {
                throw new IndexOutOfRangeException("Index out of range list length");
            }
            if (idx == 0)
            {
                this.RemoveFirst();
                return;
            }
            
            Node temp = Head;
            for (int i = 0; i < idx - 1; i++)
            {
                if (temp == null)
                {
                    throw new IndexOutOfRangeException("Index out of range list length");
                }
                temp = temp.Next;
            }
            temp.Next = temp.Next.Next;
        }

        public void RemoveFirstMultiple(int n)
        {
            if (Head == null)
            {
                Head = null;
                Tail = Head;
                return;
            }

            for (int i = 0; i < n; i++)
            {
                Head = Head.Next;
                if (Head == null)
                    return;
            }
        }

        public void RemoveLastMultiple(int n)
        {
            Node temp = Head;
            Node toLastN = Head;

            for (int i = 0; i < n; i++)
            {
                if (toLastN == null)
                {
                    Head = null;
                    Tail = Head;
                    return;
                }
                toLastN = toLastN.Next;
            }

            while (toLastN != Tail)
            {
                toLastN = toLastN.Next;
                temp = temp.Next;
            }

            Tail = temp;
            temp.Next = null;
            
        }

        public void RemoveAtMultiple(int idx, int n)
        {
            if (idx < 0 || Head == null)
            {
                throw new IndexOutOfRangeException("Index out of range list length");
            }
            if (idx == 0)
            {
                this.RemoveFirstMultiple(n);
                return;
            }

            Node temp = Head;
            for (int i = 0; i < idx-1 ; i++)
            {
                if (temp == null)
                {
                    throw new IndexOutOfRangeException("Index out of range list length");
                }
                temp = temp.Next;
            }

            Node fromIndex = temp;

            for (int i = 0; i < n+1; i++)
            {
                if (temp == null)
                    break;
                temp = temp.Next;
            }
            fromIndex.Next = temp;
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
            
            return numbersOfRemoveElements;
        }

        public bool Contains(int val)
        {
            if (Head == null)
                return false;
            
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
            if (idx < 0 || Head == null)
            {
                throw new IndexOutOfRangeException("List is empty");
            }
            
            Node temp = Head;
            for (int i = 0; i < idx; i++)
            {
                temp = temp.Next;
                if (temp == null)
                {
                    throw new IndexOutOfRangeException("Entry index out of range length list");
                }
            }
            return temp.Value;
        }

        public void Reverse()//кажись всё..
        {
            if (Head == null)
            {
                return;
            }
            Node tempHead = Head;
            Node tempTail = Tail;
            while (tempHead != tempTail)
            {
                int copyTempHead = tempHead.Value;
                tempHead.Value = tempTail.Value;
                tempTail.Value = copyTempHead;
                if (tempHead.Next == tempTail)
                {
                    break;
                }
                Node newTempTail = tempHead;
                while (newTempTail.Next != tempTail)
                {
                    newTempTail = newTempTail.Next;
                }
                tempHead = tempHead.Next;
                tempTail = newTempTail;
            }
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
            Node temp = Head;
            while (temp != null)
            {
                Node copyHead = Head;
                
                while (copyHead != temp)
                {
                    if (temp.Value < copyHead.Value)
                    {
                        int tempValue = temp.Value;
                        temp.Value = copyHead.Value;
                        copyHead.Value = tempValue;
                    }
                    copyHead = copyHead.Next;

                }
                
                temp = temp.Next;
            }
        }

        public void SortDesc()
        {
            if (Head == null)
            {
                return;
            }
            Node temp = Head;
            while (temp != null)
            {
                Node copyHead = Head;

                while (copyHead != temp)
                {
                    if (temp.Value > copyHead.Value)
                    {
                        int tempValue = temp.Value;
                        temp.Value = copyHead.Value;
                        copyHead.Value = tempValue;
                    }
                    copyHead = copyHead.Next;

                }

                temp = temp.Next;
            }
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
