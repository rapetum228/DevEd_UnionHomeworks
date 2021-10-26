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
        private Node _tail;

        public LinkList(int value)
        {
            Head = new Node
            {
                Value = value
            };
            _tail = Head;
        }

        public void AddLast(int val)
        {
            Node current = new Node { Value = val};
            _tail.Next = current;
            _tail = current;
        }
        
        public void AddLast(LinkList list)
        {
            _tail.Next = list.Head;
        }
       
        public void AddFirst(int val)
        {
            Node current = new Node { Value = val };
            current.Next = Head;
            Head = current;
        }

        public void AddFirst(LinkList list)
        {
            Head = list.Head.Next;
        }

        public void AddAt(int idx, int val)
        {
            Node current = new Node { Value = val };
            Node temp = Head;
            for (int i = 0; i < idx-1; i++)
            {
                temp = temp.Next;
            }

            current.Next = temp.Next;
            temp.Next = current;
            //temp.Next = new Node { Value = 228 };
            //temp.Next = new Node { Value = 229 };
            temp.Next = current;
        }


    }
}
