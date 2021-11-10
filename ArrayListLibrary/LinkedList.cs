using System;
using System.Collections.Generic;
namespace Lists
{
    public class LinkedList<T>: ILists<T> where T : IComparable<T>
    {
        private Node<T> _head; 
        private Node<T> _tail; 

        public LinkedList()
        {
            _head = null;
            _tail = _head;
        }
        public LinkedList(T value)
        {

            _head = new Node<T>
            {
                Value = value
            };
            _tail = _head;
        }

        public LinkedList(T[] arr)
        {
            if (arr.Length == 0)
            {
                _head = null;
                _tail = _head;
                return;
            }
            _head = new Node<T>
            {
                Value = arr[0],
            };
            Node<T> temp = _head;
            for (int i = 1; i < arr.Length; i++)
            {
                temp.Next = new Node<T> { Value = arr[i] };
                temp = temp.Next;
            }
            _tail = temp;
            
        }

        public LinkedList(LinkedList<T> list)
        {
            if (list._head == null)
            {
                _head = null;
                _tail = _head;
                return;
            }
            _head = new Node<T>
            {
                Value = list._head.Value,
            };
            Node<T> nodeNewLink = _head;

            Node<T> temp = list._head;
            while (temp.Next != null)
            {
                temp = temp.Next;
                Node<T> current = new Node<T> { Value = temp.Value };
                nodeNewLink.Next = current;
                nodeNewLink = nodeNewLink.Next;
            }
            _tail = nodeNewLink;
        }

        public LinkedList<T> Clone()
        {
            if (_head == null)
            {
                return new LinkedList<T>();
            }
            LinkedList<T> copyInputList = new LinkedList<T>(_head.Value);

            Node<T> nodeNewList = copyInputList._head;
            Node<T> temp = _head;

            while (temp.Next != null)
            {
                temp = temp.Next;
                nodeNewList.Next = new Node<T> { Value = temp.Value };
                nodeNewList = nodeNewList.Next;
            }
            copyInputList._tail = nodeNewList;

            return copyInputList;
        }

        public int GetLength()
        {
            int lengthList = 0;
            Node<T> temp = _head;
            while (temp != null)
            {
                lengthList++;
                temp = temp.Next;
            }
            return lengthList;
        }

        public T[] ToArray()
        {
            T[] arr = new T[this.GetLength()];
            Node<T> temp = _head;
            for (int i = 0; i < this.GetLength(); i++)
            {
                arr[i] = temp.Value;
                temp = temp.Next;
            }

            return arr;
        }
        public void AddLast(T val)
        {

            Node<T> current = new Node<T> { Value = val};
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
        
        public void AddLast(LinkedList<T> list)
        {
            if (list._head == null)
            {
                return;
            }
           
            LinkedList<T> temp = list.Clone();
            
            if (_head != null)
            {
                _tail.Next = temp._head;
                _tail = temp._tail;
            }
            else
            {
                _head = temp._head;
                _tail = temp._tail;
            }
           
        }
       
        public void AddFirst(T val)
        {
            Node<T> current = new Node<T> { Value = val };
            current.Next = _head;
            _head = current;
        }

        public void AddFirst(LinkedList<T> list)
        {
            if (list._head == null)
            {
                return;
            }
            LinkedList<T> temp = list.Clone();
            temp._tail.Next = _head;
            _head = temp._head;
        }

        public void AddAt(int idx, T val)
        {
            if (idx < 0 || _head == null)
            {
                throw new IndexOutOfRangeException("Index out of range list length");
            }
            if (idx == 0)
            {
                this.AddFirst(val);
                return;
            }
            Node<T> current = new Node<T> { Value = val };
            Node<T> temp = _head;
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

        public void AddAt(int idx, LinkedList<T> list)
        {
            if (idx < 0 || _head == null)
            {
                throw new IndexOutOfRangeException("Index out of range list length");
            }
            if (idx == 0)
            {
                this.AddFirst(list);
                return;
            }
            LinkedList<T> newList = list.Clone();

            Node<T> temp = _head;
            for (int i = 0; i < idx - 1; i++)
            {
                if (temp == null)
                {
                    throw new IndexOutOfRangeException("Index out of range list length");
                }
                temp = temp.Next;
            }
            newList._tail.Next = temp.Next;
            temp.Next = newList._head;
        }

        public void Set(int idx, T val)
        {
            if (idx < 0 || _head == null)
                throw new IndexOutOfRangeException("Index out of range list length");

            Node<T> temp = _head;
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
            {
                return;
            }

            _head = _head.Next;
        }
        public void RemoveLast()
        {
            if (_head == null || _head.Next == null)
            {
                _head = null;
                return;
            }

            Node<T> temp = _head;
            while (temp.Next.Next != null)
                temp = temp.Next;

            temp.Next = null;
            _tail = temp;
        }

        public void RemoveAt(int idx)
        {
            if (idx < 0 || _head == null )
            {
                throw new IndexOutOfRangeException("Index out of range list length");
            }
            if (idx == 0)
            {
                this.RemoveFirst();
                return;
            }

            Node<T> temp = _head;
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
            if (_head == null)
            {
                throw new Exception("List is empty");
            }

            for (int i = 0; i < n; i++)
            {
                _head = _head.Next;
                if (_head == null)
                    return;
            }
        }

        public void RemoveLastMultiple(int n)
        {
            if (_head == null)
            {
                throw new Exception("List is empty");
            }

            Node<T> temp = _head;
            Node<T> toLastN = _head;

            for (int i = 0; i < n; i++)
            {
                if (toLastN == null)
                {
                    _head = null;
                    _tail = _head;
                    return;
                }
                toLastN = toLastN.Next;
            }

            while (toLastN != _tail)
            {
                toLastN = toLastN.Next;
                temp = temp.Next;
            }

            _tail = temp;
            temp.Next = null;
            
        }

        public void RemoveAtMultiple(int idx, int n)
        {
            if (idx < 0 || _head == null)
            {
                throw new IndexOutOfRangeException("Index out of range list length");
            }
            if (idx == 0)
            {
                this.RemoveFirstMultiple(n);
                return;
            }

            Node<T> temp = _head;
            for (int i = 0; i < idx-1 ; i++)
            {
                if (temp == null)
                {
                    throw new IndexOutOfRangeException("Index out of range list length");
                }
                temp = temp.Next;
            }

            Node<T> fromIndex = temp;

            for (int i = 0; i < n+1; i++)
            {
                if (temp == null)
                    break;
                temp = temp.Next;
            }
            fromIndex.Next = temp;
        }

        public int RemoveFirst(T val)
        {
            if (_head == null)
                return -1;
            else if (_head.Value.CompareTo(val) == 0)
            {
                _head = _head.Next;
                return 0;
            }

            Node<T> temp = _head;
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
            return index+1;
        }

        public int RemoveAll(T val)
        {
            int numbersOfRemoveElements = 0;
            while (_head != null &&  _head.Value.CompareTo(val) == 0 )
            {
                numbersOfRemoveElements++;
                _head = _head.Next;
            }
            if (_head == null)
            {
                return numbersOfRemoveElements;
            }
            Node<T> temp = _head;

            while (temp.Next != null)
            {
                if (temp.Next.Value.CompareTo(val) == 0)
                {
                    numbersOfRemoveElements++;
                    temp.Next = temp.Next.Next;
                }
                else { temp = temp.Next; }
            }
            
            return numbersOfRemoveElements;
        }

        public bool Contains(T val)
        {
            if (_head == null)
                return false;
            
            Node<T> temp = _head;

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
                return -1;
            else if (_head.Value.CompareTo(val) == 0)
                return 0;
            Node<T> temp = _head;
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
                throw new IndexOutOfRangeException("List is empty");
            }
            return _head.Value;
        }

        public T GetLast()
        {
            if (_head == null)
            {
                throw new IndexOutOfRangeException("List is empty");
            }
            return _tail.Value;
        }

        public T Get(int idx)
        {
            if (idx < 0 || _head == null)
            {
                throw new IndexOutOfRangeException("List is empty");
            }
            
            Node<T> temp = _head;
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

        public void Reverse()
        {
            if (_head == null)
            {
                return;
            }
            Node<T> tempHead = _head;
            Node<T> prev = null;
            Node<T> tempNext = tempHead;
            while (tempNext.Next != null)
            {
                tempNext = tempNext.Next;
                tempHead.Next = prev;
                prev = tempHead;
                tempHead = tempNext;
            }
            tempNext.Next = prev;
            _tail = _head;
            _head = tempNext;
        }

        public T Max()
        {
            if (_head == null)
            {
                throw new IndexOutOfRangeException("List is empty");
            }

            Node<T> temp = _head;
            T max = _head.Value;
            while (temp.Next != null)
            {
                temp = temp.Next;
                if (max.CompareTo(temp.Value) < 0 )
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
                throw new IndexOutOfRangeException("List is empty");
            }
            Node<T> temp = _head;
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
                throw new IndexOutOfRangeException("List is empty");
            }
            Node<T> temp = _head;
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
                throw new IndexOutOfRangeException("List is empty");
            }
            Node<T> temp = _head;
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

        public void Sort()
        {
            if (_head == null)
                return;

            Node<T> temp = _head;
            Node<T> tempPrevious = null;
            Node<T> tempNext = temp.Next;
            while (temp != null)
            {
                Node<T> copyHead = _head;

                while (temp != copyHead)
                {
                    if  (temp.Value.CompareTo(_head.Value) < 0)
                    {
                        tempPrevious.Next = tempNext;
                        temp.Next = _head;
                        _head = temp;
                        break;
                    }
                    else if (temp.Value.CompareTo(copyHead.Next.Value) < 0)
                    { 
                        tempPrevious.Next = tempNext;
                        temp.Next = copyHead.Next;
                        copyHead.Next = temp;
                        break;
                    }
                    copyHead = copyHead.Next;
   
                }
                if (temp.Next == tempNext)
                    tempPrevious = temp;
               
                temp = tempNext;
                if (temp != null) 
                    tempNext = tempNext.Next;
                
            }
            _tail = tempPrevious;
        }

        public void SortDesc() 
        {
            if (_head == null)
                return;

            Node<T> temp = _head;
            Node<T> tempPrevious = null;
            Node<T> tempNext = temp.Next;
            while (temp != null)
            {
                Node<T> copyHead = _head;

                while (temp != copyHead)
                {
                    if (temp.Value.CompareTo(_head.Value) > 0)
                    {
                        tempPrevious.Next = tempNext;
                        temp.Next = _head;
                        _head = temp;
                        break;
                    }
                    else if (temp.Value.CompareTo(copyHead.Next.Value) > 0)
                    {
                        tempPrevious.Next = tempNext;
                        temp.Next = copyHead.Next;
                        copyHead.Next = temp;
                        break;
                    }
                    copyHead = copyHead.Next;

                }
                if (temp.Next == tempNext)
                    tempPrevious = temp;

                temp = tempNext;
                if (temp != null)
                    tempNext = tempNext.Next;

            }
            _tail = tempPrevious;
        }


        //public void SortCocktail()
        //{
        //    if (_head == null)
        //    {
        //        return;
        //    }
        //    Node<T> temp = _head;

        //    Node<T> fakeTail = null;
        //    bool flagSort = true;
        //    while (flagSort)
        //    {
        //        Node<T> copyHead = temp;
        //        flagSort = false;
        //        while (copyHead.Next != fakeTail)
        //        {
        //            if (copyHead.Next.Value < temp.Value)
        //            {
        //                int copyTempValue = temp.Value;
        //                temp.Value = copyHead.Next.Value;
        //                copyHead.Next.Value = copyTempValue;
        //            }
        //            if (copyHead.Value > copyHead.Next.Value)
        //            {
        //                flagSort = true;
        //                int copyTempValue = copyHead.Value;
        //                copyHead.Value = copyHead.Next.Value;
        //                copyHead.Next.Value = copyTempValue;
        //            }
                    
        //            copyHead = copyHead.Next;

        //        }
        //        fakeTail = copyHead;
        //        temp = temp.Next;
        //    }
        //}
    }
}
