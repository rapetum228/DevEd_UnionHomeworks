using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class LinkedList
    {
        private Node _head; //{ get; private set; }
        private Node _tail; //{ get; private set; }

        public LinkedList()
        {
            _head = null;
            _tail = _head;
        }
        public LinkedList(int value)
        {

            _head = new Node
            {
                Value = value
            };
            _tail = _head;
        }

        public LinkedList(int[] arr)
        {
            if (arr.Length == 0)
            {
                _head = null;
                _tail = _head;
                return;
            }
            _head = new Node
            {
                Value = arr[0],
            };
            Node temp = _head;
            for (int i = 1; i < arr.Length; i++)
            {
                temp.Next = new Node { Value = arr[i] };
                temp = temp.Next;
            }
            _tail = temp;
            
        }

        public LinkedList(LinkedList list)
        {
            if (list._head == null)
            {
                _head = null;
                _tail = _head;
                return;
            }
            _head = new Node
            {
                Value = list._head.Value,
            };
            Node nodeNewLink = _head;
            
            Node temp = list._head;
            while (temp.Next != null)
            {
                temp = temp.Next;
                Node current = new Node { Value = temp.Value };
                nodeNewLink.Next = current;
                nodeNewLink = nodeNewLink.Next;
            }
            _tail = nodeNewLink;
        }

        public LinkedList Clone()
        {
            if (_head == null)
            {
                return new LinkedList();
            }
            LinkedList copyInputList = new LinkedList(_head.Value);

            Node nodeNewList = copyInputList._head;
            Node temp = _head;

            while (temp.Next != null)
            {
                temp = temp.Next;
                nodeNewList.Next = new Node { Value = temp.Value };
                nodeNewList = nodeNewList.Next;
            }
            copyInputList._tail = nodeNewList;

            return copyInputList;
        }

        public int GetLength()
        {
            int lengthList = 0;
            Node temp = _head;
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
            Node temp = _head;
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
        
        public void AddLast(LinkedList list)
        {
            if (list._head == null)
            {
                return;
            }
           
            LinkedList temp = list.Clone();
            
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
       
        public void AddFirst(int val)
        {
            Node current = new Node { Value = val };
            current.Next = _head;
            _head = current;
        }

        public void AddFirst(LinkedList list)
        {
            if (list._head == null)
            {
                return;
            }
            LinkedList temp = list.Clone();
            temp._tail.Next = _head;
            _head = temp._head;
        }

        public void AddAt(int idx, int val)
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
            Node current = new Node { Value = val };
            Node temp = _head;
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

        public void AddAt(int idx, LinkedList list)
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
            LinkedList newList = list.Clone();

            Node temp = _head;
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

        public void Set(int idx, int val)
        {
            if (idx < 0 || _head == null)
                throw new IndexOutOfRangeException("Index out of range list length");

            Node temp = _head;
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
            //LengthList--;
            Node temp = _head;
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
            
            Node temp = _head;
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

            Node temp = _head;
            Node toLastN = _head;

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

            Node temp = _head;
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
            if (_head == null)
                return -1;
            else if (_head.Value == val)
            {
                _head = _head.Next;
                return 0;
            }

            Node temp = _head;
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
            while (_head != null &&  _head.Value == val  )
            {
                numbersOfRemoveElements++;
                _head = _head.Next;
            }
            if (_head == null)
            {
                return numbersOfRemoveElements;
            }
            Node temp = _head;

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
            if (_head == null)
                return false;
            
            Node temp = _head;

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
                return -1;
            else if (_head.Value == val)
                return 0;
            Node temp = _head;
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
                throw new IndexOutOfRangeException("List is empty");
            }
            return _head.Value;
        }

        public int GetLast()
        {
            if (_head == null)
            {
                throw new IndexOutOfRangeException("List is empty");
            }
            return _tail.Value;
        }

        public int Get(int idx)
        {
            if (idx < 0 || _head == null)
            {
                throw new IndexOutOfRangeException("List is empty");
            }
            
            Node temp = _head;
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
            Node tempHead = _head;
            Node prev = null;
            Node tempNext = tempHead;
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

        public int Max()
        {
            if (_head == null)
            {
                throw new IndexOutOfRangeException("List is empty");
            }

            Node temp = _head;
            int max = _head.Value;
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
            if (_head == null)
            {
                throw new IndexOutOfRangeException("List is empty");
            }
            Node temp = _head;
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
                throw new IndexOutOfRangeException("List is empty");
            }
            Node temp = _head;
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
                throw new IndexOutOfRangeException("List is empty");
            }
            Node temp = _head;
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

        public void Sort()
        {
            if (_head == null)
                return;

            Node temp = _head;
            Node tempPrevious = null;
            Node tempNext = temp.Next;
            while (temp != null)
            {
                Node copyHead = _head;

                while (temp != copyHead)
                {
                    if  (temp.Value < _head.Value)
                    {
                        tempPrevious.Next = tempNext;
                        temp.Next = _head;
                        _head = temp;
                        break;
                    }
                    else if (temp.Value < copyHead.Next.Value)
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

            Node temp = _head;
            Node tempPrevious = null;
            Node tempNext = temp.Next;
            while (temp != null)
            {
                Node copyHead = _head;

                while (temp != copyHead)
                {
                    if (temp.Value > _head.Value)
                    {
                        tempPrevious.Next = tempNext;
                        temp.Next = _head;
                        _head = temp;
                        break;
                    }
                    else if (temp.Value > copyHead.Next.Value)
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

        public void SortCocktail()
        {
            if (_head == null)
            {
                return;
            }
            Node temp = _head;

            Node fakeTail = null;
            bool flagSort = true;
            while (flagSort)
            {
                Node copyHead = temp;
                flagSort = false;
                while (copyHead.Next != fakeTail)
                {
                    if (copyHead.Next.Value < temp.Value)
                    {
                        int copyTempValue = temp.Value;
                        temp.Value = copyHead.Next.Value;
                        copyHead.Next.Value = copyTempValue;
                    }
                    if (copyHead.Value > copyHead.Next.Value)
                    {
                        flagSort = true;
                        int copyTempValue = copyHead.Value;
                        copyHead.Value = copyHead.Next.Value;
                        copyHead.Next.Value = copyTempValue;
                    }
                    
                    copyHead = copyHead.Next;

                }
                fakeTail = copyHead;
                temp = temp.Next;
            }
        }
    }
}
