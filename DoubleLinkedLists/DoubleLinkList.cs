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
            if (arr.Length == 0)
            {
                Head = null;
                Tail = Head;
                return;
            }
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
            if (list.Head == null)
            {
                Head = null;
                Tail = Head;
                return;
            }
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
            if (Head == null)
            {
                return new int[] { };
            }
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
            DoubleLinkList temp = new DoubleLinkList(list);
            if (Head == null)
            {
                Head = temp.Head;
                Tail = temp.Tail;
            }
            else
            {
                Tail.Next = temp.Head;
                Tail = temp.Tail;
            }
        }

        public void AddFirst(int val)
        {
            DNode current = new DNode { Value = val, Next = Head };
            current.Next = Head;
            if(Head != null)
                Head.Previous = current;
            Head = current;
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
            if (Head == null)
                throw new IndexOutOfRangeException("Index out of range list length");

            DNode temp = Head;

            for (int i = 0; i < idx - 1; i++)
            {
                if (temp == null && idx != 0)
                {
                    throw new IndexOutOfRangeException("Index out of range list length");
                }
                temp = temp.Next;
            }
            if (list.Head == null)
                return;

            DoubleLinkList newList = new DoubleLinkList(list);
            if (idx == 0)
            {
                newList.Tail.Next = Head;
                Head.Previous = newList.Tail;
                Head = newList.Head;
                return;
            }
            temp.Previous = null;
            newList.Head.Previous = temp;
            newList.Tail.Next = temp.Next;
            if (temp.Next != null)
                temp.Next.Previous = newList.Tail;
            temp.Next = newList.Head;
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
            if (Head != null)
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

            if (Head == null)
            {
                throw new Exception("List is empty");
            }
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
            if (Head == null)
            {
                throw new Exception("List is empty");
            }
            DNode temp = Tail;
            for (int i = 0; i < n; i++)
            {
                if (temp == null)
                {
                    Head = temp;
                    Tail = temp;
                    return;
                }
                temp = temp.Previous;
            }
            Tail = temp;
            temp.Next = null;
        }

        public void RemoveAtMultiple(int idx, int n)
        {
            if (Head == null)
            {
                throw new Exception("List is empty");
            }
            if (idx == 0)
            {
                this.RemoveFirstMultiple(n);
                return;
            }

            DNode temp = Head;
            for (int i = 0; i < idx - 1; i++)
            {
                if(temp == null) 
                    throw new Exception("Index out of range list length");
                temp = temp.Next;
            }

            DNode current = temp;
            while (n > 0)
            {
                
                if (temp.Next == null)
                {
                    this.RemoveLastMultiple(n-1);
                    return;
                }
                n--;
                temp = temp.Next;
            }
            //for (int i = 0; i < n + 1; i++)
            //{
            //    if (temp.Next == null)
            //    {
            //        this.RemoveLastMultiple(n);
            //        return;
            //    }
            //    temp = temp.Next;
            //}
                
            current.Next = temp.Next;
            if (temp.Next != null)
                temp.Next.Previous = current;
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
                if(Head != null) 
                    Head.Previous = null;
            }
            if (Head == null)
            {
                return numbersOfRemoveElements;
            }
            DNode temp = Head;

            while (temp != null)
            {
                while (temp.Next != null && temp.Next.Value == val)
                {
                    numbersOfRemoveElements++;
                    temp.Next = temp.Next.Next;
                    if(temp.Next != null)
                        temp.Next.Previous = temp;
                    //temp = temp.Next;
                }
                 temp = temp.Next; 
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

        public int Max()
        {
            if (Head == null)
            {
                throw new IndexOutOfRangeException("List is empty");
            }

            DNode temp = Head;
            int max = Head.Value;
            while (temp.Next != null)
            {
                temp = temp.Next;
                if (max < temp.Value)
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
            DNode temp = Head;
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
            DNode temp = Head;
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
            DNode temp = Head;
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
            DNode temp = Head;//копирую голову, чтобы в цикле идти вперёд

            while (temp != null)
            {
                DNode copy = temp;//копирую ссылку на temp для хода назад от неё 

                while(copy.Previous != null && copy.Previous.Value > copy.Value)
                //цикл выполняется пока копия temp не дойдёт обратным ходом до null и
                //если значение предыдущего элемента копии больше значения в temp
                {
                    int copyValue = copy.Value;
                    copy.Value = copy.Previous.Value;
                    copy.Previous.Value = copyValue;
                    copy = copy.Previous;
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
            DNode temp = Head;//копирую голову, чтобы в цикле идти вперёд

            while (temp != null)
            {
                DNode copy = temp;//копирую ссылку на temp для хода назад от неё 

                while (copy.Previous != null && copy.Previous.Value < copy.Value)
                //цикл выполняется пока копия temp не дойдёт обратным ходом до null и
                //если значение предыдущего элемента копии больше значения в temp
                {
                    int copyValue = copy.Value;
                    copy.Value = copy.Previous.Value;
                    copy.Previous.Value = copyValue;
                    copy = copy.Previous;
                }
                temp = temp.Next;
            }
        }

        public void Reverse()
        {
            if (Head == null)
            {
                return;
            }
            DNode tempHead = Head;
            DNode tempTail = Tail;
            while (tempHead != tempTail)
            {
                int copyTempHead = tempHead.Value;
                tempHead.Value = tempTail.Value;
                tempTail.Value = copyTempHead;
                if (tempHead.Next == tempTail)
                    break;
                
                tempHead = tempHead.Next;
                tempTail = tempTail.Previous;
            }

        }


    }
}
