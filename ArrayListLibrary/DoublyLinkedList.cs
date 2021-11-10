using System;

namespace Lists
{
    public class DoublyLinkedList<T>: ILists<T> where T : IComparable<T>
    {
        private DoublyNode<T> _head;
        private DoublyNode<T> _tail;

        public DoublyLinkedList()
        {
            _head = null;
            _tail = _head;
        }

        public DoublyLinkedList(T val)
        {
            _head = new DoublyNode<T>
            {
                Value = val,
                Previous = null,
                Next = null,
            };
            _tail = _head;
        }

        public DoublyLinkedList(T[] arr)
        {
            if (arr.Length == 0)
            {
                _head = null;
                _tail = _head;
                return;
            }
            _head = new DoublyNode<T>
            {
                Value = arr[0],
                Previous = null,
                Next = null,
            };
            DoublyNode<T> temp = _head;
            for (int i = 1; i < arr.Length; i++)
            {
                temp.Next = new DoublyNode<T> { Value = arr[i], Previous = temp };
                temp = temp.Next;
            }
            _tail = temp;
        }

        public DoublyLinkedList(DoublyLinkedList<T> list)
        {
            if (list._head == null)
            {
                _head = null;
                _tail = _head;
                return;
            }
            _head = new DoublyNode<T>
            {
                Value = list._head.Value,
                Previous = null,
                Next = null,
            };
            DoublyNode<T> temp = _head;
            DoublyNode<T> tempList = list._head;
            while (tempList.Next != null)
            {
                tempList = tempList.Next;
                temp.Next = new DoublyNode<T> { Value = tempList.Value, Previous = temp };
                temp = temp.Next;
            }
            _tail = temp;
        }

        public DoublyLinkedList<T> Clone()
        {
            if (_head == null)
            {
                _head = null;
                _tail = _head;
                return new DoublyLinkedList<T>();
            }
            DoublyLinkedList<T> copyInputList = new DoublyLinkedList<T>(_head.Value);
            
            DoublyNode<T> temp = _head;
            DoublyNode<T> tempList = copyInputList._head;
            while (temp.Next != null)
            {
                temp = temp.Next;
                tempList.Next = new DoublyNode<T> { Value = temp.Value, Previous = tempList };
                tempList = tempList.Next;
                
            }
            copyInputList._tail = tempList;
            return copyInputList;
        }

        public int GetLength()
        {
            int lengthList = 0;
            DoublyNode<T> temp = _head;
            while (temp != null)
            {
                lengthList++;
                temp = temp.Next;
            }
            return lengthList;
        }

        public T[] ToArray()
        {
            if (_head == null)
            {
                return new T[] { };
            }
            T[] arr = new T[this.GetLength()];
            DoublyNode<T> temp = _head;
            int indexArray = 0;
            while (temp != null)
            {
                arr[indexArray] = temp.Value;
                temp = temp.Next;
                indexArray++;
            }

            return arr;
        }

        public void AddLast(T val)
        {
            //LengthList++;
            DoublyNode<T> current = new DoublyNode<T> { Value = val, Previous = _tail };
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

        public void AddLast(DoublyLinkedList<T> list)
        {
            if (list._head == null)
            {
                return;
            }
            DoublyLinkedList<T> temp = list.Clone();
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

        public void AddFirst(T val)
        {
            DoublyNode<T> current = new DoublyNode<T> { Value = val, Next = _head };
            current.Next = _head;
            if(_head != null)
                _head.Previous = current;
            _head = current;
        }

        public void AddFirst(DoublyLinkedList<T> list)
        {
            if (list._head == null)
            {
                return;
            }

            DoublyNode<T> temp, tempTail;
            if (_head == null)
            {
                temp = new DoublyNode<T> { Value = list._tail.Value };
                tempTail = list._tail.Previous;
            }
            else
            {
                tempTail = list._tail;
                temp = _head;
            }
            while (tempTail != null)
            {
                temp.Previous = new DoublyNode<T> { Value = tempTail.Value, Next = temp };
                tempTail = tempTail.Previous;
                temp = temp.Previous;
            }
            _head = temp;
        }

        public void AddAt(int idx, T val)
        {
            if (_head == null)
                throw new Exception("List is empty");

            if (idx < 0)
                throw new IndexOutOfRangeException("Index out of range list length");
            
            DoublyNode<T> temp = _head;
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
            DoublyNode<T> current = new DoublyNode<T>
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

        public void AddAt(int idx, DoublyLinkedList<T> list)
        {
            if (_head == null)
                throw new Exception("List is empty");
            if (idx < 0)
                throw new IndexOutOfRangeException("Index out of range list length");
            
            DoublyNode<T> temp = _head;

            for (int i = 0; i < idx - 1; i++)
            {
                if (temp == null && idx != 0)
                    throw new IndexOutOfRangeException("Index out of range list length");
                
                temp = temp.Next;
            }
            if (list._head == null)
                return;

            DoublyLinkedList<T> newList = list.Clone() ;
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

        public void Set(int idx, T val)
        {
            if (_head == null)
                throw new Exception("List is empty");

            if (idx < 0)
                throw new IndexOutOfRangeException("Index out of range list length");

            DoublyNode<T> temp = _head;
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
            
            DoublyNode<T> temp = _head;
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
            DoublyNode<T> temp = _tail;
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

            DoublyNode<T> temp = _head;
            for (int i = 0; i < idx - 1; i++)
            {
                if(temp == null) 
                    throw new Exception("Index out of range list length");
                temp = temp.Next;
            }

            DoublyNode<T> current = temp;
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

        public int RemoveFirst(T val)
        {
            if (_head == null)
                throw new Exception("List is empty");
            
            
            else if (_head.Value.CompareTo(val) == 0)
            {
                _head = _head.Next;
                _head.Previous = null;
                return 0;
            }

            DoublyNode<T> temp = _head;
            int index = 0;
            while (temp.Next != null && temp.Next.Value.CompareTo(val) != 0)
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

        public int RemoveAll(T val)
        {
            if (_head == null)
                throw new Exception("List is empty");

            int numbersOfRemoveElements = 0;
            while (_head != null && _head.Value.CompareTo(val) == 0)
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
            DoublyNode<T> temp = _head;

            while (temp != null)
            {
                while (temp.Next != null && temp.Next.Value.CompareTo(val) == 0)
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

        public bool Contains(T val)
        {
            if (_head == null)
                throw new Exception("List is empty");

            if (_head == null)
                return false;
            else if (_head.Value.CompareTo(val) == 0)
                return true;
            DoublyNode<T> temp = _head;

            while (temp.Value.CompareTo(val) != 0)
            {
                if (temp.Next == null)
                    return false;
                temp = temp.Next;
            }

            return true;
        }

        public int IndexOf(T val)
        {
            if (_head == null)
                throw new Exception("List is empty");
            else if (_head.Value.CompareTo(val) == 0)
                return 0;
            DoublyNode<T> temp = _head;
            int index = 0;
            while (temp.Value.CompareTo(val) != 0)
            {
                if (temp.Next == null)
                    return -1;
                temp = temp.Next;
                index++;
            }
            return index;
        }

        public T GetFirst()
        {
            if (_head == null)
            {
                throw new Exception("List is empty");
            }
            return _head.Value;
        }

        public T GetLast()
        {
            if (_head == null)
            {
                throw new Exception("List is empty");
            }
            return _tail.Value;
        }

        public T Get(int idx)
        {
            if (_head == null)
            {
                throw new Exception("List is empty");
            }
            DoublyNode<T> temp = _head;
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

        public T Max()
        {
            if (_head == null)
            {
                throw new Exception("List is empty");
            }

            DoublyNode<T> temp = _head;
            T max = _head.Value;
            while (temp.Next != null)
            {
                temp = temp.Next;
                if (max.CompareTo(temp.Value) < 0)
                {
                    max = temp.Value;
                }
            }
            return max;
        }

        public T Min()
        {
            if (_head == null)
            {
                throw new Exception("List is empty");
            }
            DoublyNode<T> temp = _head;
            T min = _head.Value;
            while (temp.Next != null)
            {
                temp = temp.Next;
                if (min.CompareTo(temp.Value) > 0)
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
            DoublyNode<T> temp = _head;
            T max = _head.Value;
            int indexOfMax = 0;
            int index = 0;
            while (temp.Next != null)
            {
                index++;
                temp = temp.Next;
                if (max.CompareTo(temp.Value) < 0)
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
            DoublyNode<T> temp = _head;
            T min = _head.Value;
            int indexOfMin = 0;
            int index = 0;
            while (temp.Next != null)
            {
                index++;
                temp = temp.Next;
                if (min.CompareTo(temp.Value) > 0)
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

            DoublyNode<T> temp = _head;
            DoublyNode<T> tempNext = temp.Next;
            DoublyNode<T> tempPrevious = temp.Previous;

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
            DoublyNode<T> temp = _head;
            DoublyNode<T> tempNext = temp.Next;

            while (temp != null)
            {
                DoublyNode<T> copy = temp;
                
                bool flag = false;
                while (copy.Previous != null && copy.Previous.Value.CompareTo(temp.Value) > 0)
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
            DoublyNode<T> temp = _head;
            DoublyNode<T> tempNext = temp.Next;

            while (temp != null)
            {
                DoublyNode<T> copy = temp;

                bool flag = false;
                while (copy.Previous != null && copy.Previous.Value.CompareTo(temp.Value)<0)
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
