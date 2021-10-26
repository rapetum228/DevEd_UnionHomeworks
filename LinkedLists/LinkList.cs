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
        private int _lengthList;
        public LinkList(int value)
        {
            _lengthList = 1;
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
            _lengthList = 1; 
            
            Node temp = list.Head;
            while (temp.Next != null)
            {
                temp = temp.Next;
                Node current = new Node { Value = temp.Value };
                tempUS.Next = current;
                tempUS = tempUS.Next;
                _lengthList++;
            }
            Tail = tempUS;//new Node { Value = list.Tail.Value, Next = null };
        }

        public void AddLast(int val)
        {
            Node current = new Node { Value = val};
            Tail.Next = current;
            Tail = current;
        }
        
        public void AddLast(LinkList list)
        {
            LinkList temp = new LinkList(list);
            Tail.Next = list.Head;
            Tail = list.Tail;
            list = temp;
        }
       
        public void AddFirst(int val)
        {
            Node current = new Node { Value = val };
            current.Next = Head;
            Head = current;
        }

        public void AddFirst(LinkList list)
        {
            LinkList temp = new LinkList(list);
            list.Tail.Next = Head;
            Head = list.Head;
            list = temp;
        }

        public void AddAt(int idx, int val)
        {
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
            Head = Head.Next;
        }
        public void RemoveLast()
        {
            Node temp = Head;
            while (temp.Next.Next != null)
                temp = temp.Next;

            temp.Next = null;
            Tail = temp;
        }

        public void RemoveAt(int idx)
        {
            Node temp = Head;
            for (int i = 0; i < idx - 1; i++)
                temp = temp.Next;

            temp.Next = temp.Next.Next;
        }

        public void RemoveFirstMultiple(int n)
        {
            for (int i = 0; i < n; i++)
                Head = Head.Next;
        }

        public void RemoveLastMultiple(int n)
        {
            Node temp = Head;
            while(temp.Next.Next.Next.Next != null)
            {

            }
                
        }

    }
}
