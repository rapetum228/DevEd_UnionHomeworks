using System;

namespace Lists
{
    public class DoublyLinkedList: ILists
    {
        private DoublyNode _head;
        private DoublyNode _tail;

        public DoublyLinkedList()
        {
            _head = null;
            _tail = _head;
        }

        public DoublyLinkedList(int val)
        {
            _head = new DoublyNode
            {
                Value = val,
                Previous = null,
                Next = null,
            };
            _tail = _head;
        }

        public DoublyLinkedList(int[] arr)
        {
            if (arr.Length == 0)
            {
                _head = null;
                _tail = _head;
                return;
            }
            _head = new DoublyNode
            {
                Value = arr[0],
                Previous = null,
                Next = null,
            };
            DoublyNode temp = _head;
            for (int i = 1; i < arr.Length; i++)
            {
                temp.Next = new DoublyNode { Value = arr[i], Previous = temp };
                temp = temp.Next;
            }
            _tail = temp;
        }

        public DoublyLinkedList(DoublyLinkedList list)
        {
            if (list._head == null)
            {
                _head = null;
                _tail = _head;
                return;
            }
            _head = new DoublyNode
            {
                Value = list._head.Value,
                Previous = null,
                Next = null,
            };
            DoublyNode temp = _head;
            DoublyNode tempList = list._head;
            while (tempList.Next != null)
            {
                tempList = tempList.Next;
                temp.Next = new DoublyNode { Value = tempList.Value, Previous = temp };
                temp = temp.Next;
            }
            _tail = temp;
        }

        public DoublyLinkedList Clone()
        {
            if (_head == null)
            {
                _head = null;
                _tail = _head;
                return new DoublyLinkedList();
            }
            DoublyLinkedList copyInputList = new DoublyLinkedList(_head.Value);
            
            DoublyNode temp = _head;
            DoublyNode tempList = copyInputList._head;
            while (temp.Next != null)
            {
                temp = temp.Next;
                tempList.Next = new DoublyNode { Value = temp.Value, Previous = tempList };
                tempList = tempList.Next;
                
            }
            copyInputList._tail = tempList;
            return copyInputList;
        }

        public int GetLength()
        {
            int lengthList = 0;
            DoublyNode temp = _head;
            while (temp != null)
            {
                lengthList++;
                temp = temp.Next;
            }
            return lengthList;
        }

        public int[] ToArray()
        {
            if (_head == null)
            {
                return new int[] { };
            }
            int[] arr = new int[this.GetLength()];
            DoublyNode temp = _head;
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
            DoublyNode current = new DoublyNode { Value = val, Previous = _tail };
            if (_head != null)
            {
                _tail.Next = current;
                _tail = current;
            }
            else
            {
                _head = current;
                _tail = current;
            }
        }

        public void AddLast(DoublyLinkedList list)
        {
            if (list._head == null)
            {
                return;
            }
            DoublyLinkedList temp = list.Clone();
            if (_head == null)
            {
                _head = temp._head;
                _tail = temp._tail;
            }
            else
            {
                _tail.Next = temp._head;
                _tail = temp._tail;
            }
        }

        public void AddFirst(int val)
        {
            DoublyNode current = new DoublyNode { Value = val, Next = _head };
            current.Next = _head;
            if(_head != null)
                _head.Previous = current;
            _head = current;
        }

        public void AddFirst(DoublyLinkedList list)
        {
            if (list._head == null)
            {
                return;
            }

            DoublyNode temp, tempTail;
            if (_head == null)
            {
                temp = new DoublyNode { Value = list._tail.Value };
                tempTail = list._tail.Previous;
            }
            else
            {
                tempTail = list._tail;
                temp = _head;
            }
            while (tempTail != null)
            {
                temp.Previous = new DoublyNode { Value = tempTail.Value, Next = temp };
                tempTail = tempTail.Previous;
                temp = temp.Previous;
            }
            _head = temp;
        }

        public void AddAt(int idx, int val)
        {
            if (_head == null)
                throw new Exception("List is empty");

            if (idx < 0)
                throw new IndexOutOfRangeException("Index out of range list length");
            
            DoublyNode temp = _head;
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
            DoublyNode current = new DoublyNode
            {
                Value = val,
                Next = (idx == 0) ? temp : temp.Next,
                Previous = (idx == 0) ? null : temp,
            };
            if (idx == 0)
            {
                _head = current;
            }
            else
            {
                temp.Next = current;
                temp.Next.Next.Previous = current;
            }

        }

        public void AddAt(int idx, DoublyLinkedList list)
        {
            if (_head == null)
                throw new Exception("List is empty");
            if (idx < 0)
                throw new IndexOutOfRangeException("Index out of range list length");
            
            DoublyNode temp = _head;

            for (int i = 0; i < idx - 1; i++)
            {
                if (temp == null && idx != 0)
                    throw new IndexOutOfRangeException("Index out of range list length");
                
                temp = temp.Next;
            }
            if (list._head == null)
                return;

            DoublyLinkedList newList = list.Clone() ;
            if (idx == 0)
            {
                newList._tail.Next = _head;
                _head.Previous = newList._tail;
                _head = newList._head;
                return;
            }
            temp.Previous = null;
            newList._head.Previous = temp;
            newList._tail.Next = temp.Next;
            if (temp.Next != null)
                temp.Next.Previous = newList._tail;
            temp.Next = newList._head;
        }

        public void Set(int idx, int val)
        {
            if (_head == null)
                throw new Exception("List is empty");

            if (idx < 0)
                throw new IndexOutOfRangeException("Index out of range list length");

            DoublyNode temp = _head;
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
            if (_head == null)
                throw new Exception("List is empty");

            _head = _head.Next;
            if (_head != null)
                _head.Previous = null;
        }

        public void RemoveLast()
        {
            if (_head == null)
                throw new Exception("List is empty");

            if (_head.Next == null)
            {
                _head = null;
                return;
            }
            _tail = _tail.Previous;
            _tail.Next = null;
        }

        public void RemoveAt(int idx)
        {
            if (_head == null)
                throw new Exception("List is empty");

            if (idx < 0)
                throw new IndexOutOfRangeException("Index out of range list length");
           
            if (idx == 0)
            {
                this.RemoveFirst();
                return;
            }
            
            DoublyNode temp = _head;
            for (int i = 0; i < idx - 1; i++)
            {
                if (temp == null)
                    throw new IndexOutOfRangeException("Index out of range list length");
                
                temp = temp.Next;
            }
             
            temp.Next = temp.Next.Next;
            if (temp.Next != null)
                temp.Next.Previous = temp;
        }

        public void RemoveFirstMultiple(int n)
        {

            if (_head == null)
            {
                throw new Exception("List is empty");
            }
            for (int i = 0; i < n; i++)
            {
                _head = _head.Next;
                if (_head == null)
                {
                    _head = null;
                    _tail = _head;
                    return;
                }
            }
            _head.Previous = null;
        }

        public void RemoveLastMultiple(int n)
        {
            if (_head == null)
            {
                throw new Exception("List is empty");
            }
            DoublyNode temp = _tail;
            for (int i = 0; i < n; i++)
            {
                if (temp == null)
                {
                    _head = temp;
                    _tail = temp;
                    return;
                }
                temp = temp.Previous;
            }
            _tail = temp;
            temp.Next = null;
        }

        public void RemoveAtMultiple(int idx, int n)
        {
            if (_head == null)
            {
                throw new Exception("List is empty");
            }
            if (idx == 0)
            {
                this.RemoveFirstMultiple(n);
                return;
            }

            DoublyNode temp = _head;
            for (int i = 0; i < idx - 1; i++)
            {
                if(temp == null) 
                    throw new Exception("Index out of range list length");
                temp = temp.Next;
            }

            DoublyNode current = temp;
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
            if (_head == null)
                throw new Exception("List is empty");
            
            
            else if (_head.Value == val)
            {
                _head = _head.Next;
                _head.Previous = null;
                return 0;
            }

            DoublyNode temp = _head;
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
            if (_head == null)
                throw new Exception("List is empty");

            int numbersOfRemoveElements = 0;
            while (_head != null && _head.Value == val)
            {
                numbersOfRemoveElements++;
                _head = _head.Next;
                if(_head != null) 
                    _head.Previous = null;
            }
            if (_head == null)
            {
                return numbersOfRemoveElements;
            }
            DoublyNode temp = _head;

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
            if (_head == null)
                throw new Exception("List is empty");

            if (_head == null)
                return false;
            else if (_head.Value == val)
                return true;
            DoublyNode temp = _head;

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
            if (_head == null)
                throw new Exception("List is empty");
            else if (_head.Value == val)
                return 0;
            DoublyNode temp = _head;
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
            if (_head == null)
            {
                throw new Exception("List is empty");
            }
            return _head.Value;
        }

        public int GetLast()
        {
            if (_head == null)
            {
                throw new Exception("List is empty");
            }
            return _tail.Value;
        }

        public int Get(int idx)
        {
            if (_head == null)
            {
                throw new Exception("List is empty");
            }
            DoublyNode temp = _head;
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
            if (_head == null)
            {
                throw new Exception("List is empty");
            }

            DoublyNode temp = _head;
            int max = _head.Value;
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
            if (_head == null)
            {
                throw new Exception("List is empty");
            }
            DoublyNode temp = _head;
            int min = _head.Value;
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
            if (_head == null)
            {
                throw new Exception("List is empty");
            }
            DoublyNode temp = _head;
            int max = _head.Value;
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
            if (_head == null)
            {
                throw new Exception("List is empty");
            }
            DoublyNode temp = _head;
            int min = _head.Value;
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

        public void Reverse()
        {
            if (_head == null)
                return;

            DoublyNode temp = _head;
            DoublyNode tempNext = temp.Next;
            DoublyNode tempPrevious = temp.Previous;

            while (tempNext != null)
            {
                temp.Previous = tempNext;
                temp.Next = tempPrevious;
                tempPrevious = temp;
                temp = temp.Previous; 
                tempNext = tempNext.Next; 
            }
            temp.Previous = tempNext;
            temp.Next = tempPrevious;

            _tail = _head;
            _head = temp;

        }

        public void Sort()
        {
            if (_head == null)
            {
                return;
            }
            DoublyNode temp = _head;
            DoublyNode tempNext = temp.Next;

            while (temp != null)
            {
                DoublyNode copy = temp;
                
                bool flag = false;
                while (copy.Previous != null && copy.Previous.Value > temp.Value)
                {
                    copy = copy.Previous;
                    flag = true;
                }

                if (flag)
                {
                    temp.Previous.Next = temp.Next;
                    if (tempNext != null)
                        temp.Next.Previous = temp.Previous;

                    temp.Next = copy;
                    temp.Previous = copy.Previous;
                    if (copy.Previous != null)
                    {
                        copy.Previous.Next = temp;
                        copy.Previous = temp;
                    }
                        
                    else
                    {
                        copy.Previous = temp;
                        _head = temp;
                    }
                }

                if (tempNext != null && tempNext.Next == null)
                    _tail = tempNext;
                
                temp = tempNext;
                tempNext = (tempNext != null)?tempNext.Next:null;
            }
            _tail = (_tail.Next != null)?_tail.Next:_tail;
        }

        public void SortDesc()
        {
            if (_head == null)
            {
                return;
            }
            DoublyNode temp = _head;
            DoublyNode tempNext = temp.Next;

            while (temp != null)
            {
                DoublyNode copy = temp;

                bool flag = false;
                while (copy.Previous != null && copy.Previous.Value < temp.Value)
                {
                    copy = copy.Previous;
                    flag = true;
                }

                if (flag)
                {
                    temp.Previous.Next = temp.Next;
                    if (tempNext != null)
                        temp.Next.Previous = temp.Previous;

                    temp.Next = copy;
                    temp.Previous = copy.Previous;
                    if (copy.Previous != null)
                    {
                        copy.Previous.Next = temp;
                        copy.Previous = temp;
                    }

                    else
                    {
                        copy.Previous = temp;
                        _head = temp;
                    }

                }

                if (tempNext != null && tempNext.Next == null)
                    _tail = tempNext;

                temp = tempNext;
                tempNext = (tempNext != null) ? tempNext.Next : null;
            }
            _tail = (_tail.Next != null) ? _tail.Next : _tail;
        }
    }
}
