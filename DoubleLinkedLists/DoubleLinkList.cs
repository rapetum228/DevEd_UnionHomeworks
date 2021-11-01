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
            DNode temp, tempHead;
            if (Head == null)
            {
                temp = new DNode { Value = list.Head.Value };
                tempHead = list.Head.Next;
            }
            else
            {
                tempHead = list.Head;
                temp = Tail;
            }
            
            while (tempHead != null)
            {
                temp.Next = new DNode{ Value = tempHead.Value, Previous = temp };
                tempHead = tempHead.Next;
                temp = temp.Next;
            }
            Tail = temp;
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

            DNode temp, tempTail;
            if (Head == null)
            {
                temp = new DNode { Value = list.Tail.Value };
                tempTail = list.Tail.Previous;
            }
            else
            {
                tempTail = list.Tail;
                temp = Head;
            }
            while (tempTail != null)
            {
                temp.Previous = new DNode { Value = tempTail.Value, Next = temp };
                tempTail = tempTail.Previous;
                temp = temp.Previous;
            }
            Head = temp;
        }

        public void AddAt(int idx, int val)
        {
            if (idx < 0 || Head == null)
            {
                throw new IndexOutOfRangeException("Index out of range list length");
            }
            
            DNode temp = Head;
            for (int i = 0; i < idx - 1; i++)
            {
                if (temp == null && idx != 0)
                {
                    throw new IndexOutOfRangeException("Index out of range list length");
                }
                temp = temp.Next;
            }

            //if (Head.Next == null)
            //{
            //    current.Next = Head;
            //    Head = current;
            //    return;
            //}
            DNode current = new DNode
            {
                Value = val,
                Next = (idx == 0) ? temp : temp.Next,
                Previous = (idx == 0) ? null : temp,
            };
            if (idx == 0)
            {
                Head = current;
            }
            else
            {
                temp.Next = current;
                temp.Next.Next.Previous = current;
            }

        }

        public void AddAt(int idx, DoubleLinkList list)
        {
            if (list.Head == null)
            {
                return;
            }

            DNode temp = Head;

            for (int i = 0; i < idx - 1; i++)
            {
                if (temp == null && idx != 0)
                {
                    throw new IndexOutOfRangeException("Index out of range list length");
                }
                temp = temp.Next;
            }

            DNode tempList = list.Head;
            DNode current = new DNode
            {
                Value = tempList.Value,
                Previous = temp,
            };
            DNode saveLink = temp.Next;
            temp.Next = current;
            while (tempList.Next != null)
            {
                tempList = tempList.Next;
                current.Next = new DNode
                {
                    Value = tempList.Value,
                    Previous = current,
                };
                current = current.Next;
            }
            current.Next = saveLink;
            saveLink.Previous = current;
        }

        public void Set(int idx, int val)
        {
            if (idx >= this.GetLength() || Head == null)
            {
                throw new IndexOutOfRangeException("Index out of range list length");
            }

            DNode temp = Head;
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
            Head = Head.Next;
            Head.Previous = null;
        }

        public void RemoveLast()
        {
            if (Head == null || Head.Next == null)
            {
                Head = null;
                return;
            }
            Tail = Tail.Previous;
            Tail.Next = null;
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
            DNode temp = Head;
            for (int i = 0; i < idx - 1; i++)
                temp = temp.Next;

            temp.Next = temp.Next.Next;
            temp.Next.Previous = temp;
        }

        public void RemoveFirstMultiple(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Head = Head.Next;
                if (Head == null)
                {
                    Head = null;
                    Tail = Head;
                    return;
                }
            }
            Head.Previous = null;
        }

        public void RemoveLastMultiple(int n)
        {
            DNode temp = Tail;
            for (int i = 0; i < n; i++)
            {
                temp = temp.Previous;
            }
            Tail = temp;
            temp.Next = null;
        }

        public void RemoveAtMultiple(int idx, int n)
        {
            if (Head == null)
            {
                throw new IndexOutOfRangeException("Index out of range list length");
            }
            if (idx == 0)
            {
                this.RemoveFirstMultiple(n);
                return;
            }

            DNode temp = Head;
            for (int i = 0; i < idx - 1; i++)
                temp = temp.Next;

            DNode current = temp;

            for (int i = 0; i < n + 1; i++)
                temp = temp.Next;
            current.Next = temp;
            current.Next.Previous = current;
        }

        public int RemoveFirst(int val)
        {
            if (Head == null)
                return -1;
            else if (Head.Value == val)
            {
                Head = Head.Next;
                Head.Previous = null;
                return 0;
            }

            DNode temp = Head;
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
            temp.Next.Previous = temp;
            return index + 1;
        }

        public int RemoveAll(int val)
        {
            int numbersOfRemoveElements = 0;
            while (Head != null && Head.Value == val)
            {
                numbersOfRemoveElements++;
                Head = Head.Next;
                Head.Previous = null;
            }
            if (Head == null)
            {
                return numbersOfRemoveElements;
            }
            DNode temp = Head;

            while (temp.Next != null)
            {
                if (temp.Next.Value == val)
                {
                    numbersOfRemoveElements++;
                    temp.Next = temp.Next.Next;
                    temp.Next.Previous = temp;
                }
                else { temp = temp.Next; }
            }
            return numbersOfRemoveElements;
        }

        public bool Contains(int val)
        {
            if (Head == null)
                return false;
            else if (Head.Value == val)
                return true;
            DNode temp = Head;

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
            DNode temp = Head;
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
            DNode temp = Head;
            for (int i = 0; i < idx; i++)
            {
                if (temp == null)
                {
                    throw new IndexOutOfRangeException("Entry index out of range length list");
                }
                temp = temp.Next;
            }
                
            return temp.Value;
        }

        public void Reverse()//хуйня наверное
        {
            if (Head == null)
            {
                return;
            }
            
            DNode temp = new DNode { Value = Tail.Value };
            Head = temp;
            while (Tail.Previous != null)
            {
                Tail = Tail.Previous;
                temp.Next = new DNode { Value = Tail.Value, Previous = temp };
                temp = temp.Next;
            }
            Tail = temp;
        }

        public void Sort()
        {
            if (Head == null)
            {
                return;
            }
            DNode temp = Head;//копирую голову, чтобы в цикле идти вперёд

            while (temp != null)
            {
                DNode copy = temp;//копирую ссылку на temp для хода назад от неё 
                DNode tempNext = temp.Next;//создаю копию ссылки на следующий за temp

                while(copy.Previous != null && copy.Previous.Value > copy.Value)
                //цикл выполняется пока копия temp не дойдёт обратным ходом до null и
                //если значение предыдущего элемента копии больше значения в temp
                {
                    if (copy.Previous.Value > copy.Value)
                    {
                        int copyValue = copy.Value;
                        copy.Value = copy.Previous.Value;
                        copy.Previous.Value = copyValue;
                    }
                    copy = copy.Previous;
                }
                temp = temp.Next;
                
            }
            

            //if (temp.Value < temp.Previous.Value)
            //{
            //    int copy = temp.Value;
            //    temp.Value = temp.Previous.Value;
            //    temp.Previous.Value = copy;
            //}
            //temp = temp.Previous;
            //if (temp.Value < temp.Previous.Value)
            //{
            //    int copy = temp.Value;
            //    temp.Value = temp.Previous.Value;
            //    temp.Previous.Value = copy;
            //}
            //temp = temp.Previous;
            //if (temp.Value < temp.Previous.Value)
            //{
            //    int copy = temp.Value;
            //    temp.Value = temp.Previous.Value;
            //    temp.Previous.Value = copy;
            //}
        }
    }
}
