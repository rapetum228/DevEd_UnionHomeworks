using System;

namespace Lists
{
    public class ArrList<T> : ILists<T> where T : IComparable<T>
    {
        private T[] _arr;
        private int _lengthArr;

        public ArrList()
        {
            _arr = new T[10];
            _lengthArr = 0;
        }

        public ArrList(T firstElementArrList)
        {
            _arr = new T[10];
            _arr[0] = firstElementArrList;
            _lengthArr = 1;
        }

        public ArrList(T[] inputArray)
        {
            int arrLength = 10;
            _lengthArr = inputArray.Length;
            while (_lengthArr > arrLength)
            {
                arrLength = (arrLength * 3) / 2;
            }
            _arr = new T[arrLength];
            for (int i = 0; i < _lengthArr; i++)
                _arr[i] = inputArray[i];
        }

        public ArrList(ArrList<T> inputArrList)
        {
            int arrLength = 10;
            _lengthArr = inputArrList.GetLength();
            while (_lengthArr > arrLength)
            {
                arrLength = (arrLength * 3) / 2;
            }
            _arr = new T[arrLength];
            for (int i = 0; i < _lengthArr; i++)
                _arr[i] = inputArrList.Get(i);
        }

        
        public int GetLength()
        {
            return _lengthArr;
        }

        public T[] ToArray()
        {
            T[] newArr = new T[_lengthArr];
            for (int i = 0; i < _lengthArr; i++)
            {
                newArr[i] = _arr[i];
            }
            return newArr;
        }

        private bool ChangeLengthInserArray( )
        {
            if (_lengthArr >= _arr.Length)
            {
                int newArrLength = (_arr.Length * 3) / 2;
                while (_lengthArr > newArrLength)
                    newArrLength = (newArrLength * 3) / 2;
                T[] newArr = new T[newArrLength];
                for (int i = 0; i < _arr.Length; i++)
                {
                    newArr[i] = _arr[i];
                }
                _arr = newArr;
                return true;
            }
            else if(_lengthArr <= (_arr.Length * 2) / 3 && _arr.Length > 10)
            {
                int newArrLength = (_arr.Length * 2) / 3;
                while (_lengthArr < newArrLength)
                    newArrLength = (newArrLength * 2) / 3;
                T[] newArr = new T[newArrLength];
                for (int i = 0; i < _arr.Length; i++)
                {
                    newArr[i] = _arr[i];
                }
                _arr = newArr;
                return true;
            }
            return false;
        }

        public void AddFirst(T val)
        {
            _lengthArr++;
            this.ChangeLengthInserArray();
 
            for (int i = _lengthArr-1; i > 0 ; i--)
                _arr[i] = _arr[i - 1];
            _arr[0] = val;

        }


        public void AddFirst(T[] arr)
        {
            _lengthArr += arr.Length;
            this.ChangeLengthInserArray();
            for (int i = _lengthArr - 1; i > arr.Length - 1; i--)
                _arr[i] = _arr[i - arr.Length];

            for (int i = 0; i < arr.Length; i++)
                _arr[i] = arr[i];
        }

        public void AddFirst(ArrList<T> list)
        {
            AddFirst(list.ToArray());
        }

        public void AddLast(T val)
        {
            _lengthArr++;
            this.ChangeLengthInserArray();
            _arr[_lengthArr - 1] = val;
        }

        public void AddLast(T[] arr)
        {
            _lengthArr += arr.Length;
            this.ChangeLengthInserArray();
            for (int i = _lengthArr - arr.Length; i < _lengthArr; i++)
                _arr[i] = arr[i - (_lengthArr - arr.Length)];
        }

        public void AddLast(ArrList<T> list)
        {
            AddLast(list.ToArray());
        }

        public void AddAt(int idx, T val)
        {
            if (idx > _lengthArr - 1 || idx < 0)
            {
                throw new IndexOutOfRangeException("Entry index out of range array list");
            }
            _lengthArr++;
            this.ChangeLengthInserArray();
            for (int i = _lengthArr; i > idx; i--)
                _arr[i] = _arr[i - 1];
            _arr[idx] = val;
        }

        public void AddAt(int idx, T[] arr)
        {
            if (idx > _lengthArr - 1 || idx < 0)
            {
                throw new IndexOutOfRangeException("Entry index out of range array list");
            }
            _lengthArr += arr.Length;
            this.ChangeLengthInserArray();
            for (int i = _lengthArr - 1; i >= idx + arr.Length; i--)
                _arr[i] = _arr[i - arr.Length];
            for (int i = idx; i < idx + arr.Length; i++)
                _arr[i] = arr[i - idx];
        }

        public void AddAt(int idx, ArrList<T> list)
        {
            AddAt(idx, list.ToArray());
        }

        public void Set(int idx, T val)
        {
            if (idx > _lengthArr - 1 || idx < 0)
            {
                throw new IndexOutOfRangeException("Entry index out of range array list");
            }
            
            _arr[idx] = val;
        }

        public void RemoveFirst()
        {
            if (_lengthArr == 0)
            {
                throw new Exception("Array list is empty");
            }
            _lengthArr--;
            this.ChangeLengthInserArray();
            for (int i = 0; i < _lengthArr; i++)
                _arr[i] = _arr[i + 1];
            _arr[_lengthArr] = default;
        }

        public void RemoveLast()
        {
            if (_lengthArr == 0)
            {
                throw new Exception("Array list is empty");
            }
            _lengthArr--;
            this.ChangeLengthInserArray();
            _arr[_lengthArr] = default;
        }

        public void RemoveAt(int idx)
        {
            if (_lengthArr == 0)
            {
                throw new Exception("Array list is empty");
            }
            if (idx > _lengthArr - 1 || idx < 0)
            {
                throw new IndexOutOfRangeException("Entry index out of range array list");
            }
            
            _lengthArr--;
            this.ChangeLengthInserArray();
            for (int i = idx; i < _lengthArr; i++)
                _arr[i] = _arr[i + 1];
            _arr[_lengthArr] = default;

        }

        public void RemoveFirstMultiple(int n)
        {
            if (_lengthArr == 0)
            {
                throw new Exception("Array list is empty");
            }
            if (n > _lengthArr)
            {
                T[] newArr = new T[10];
                _arr = newArr;
                _lengthArr = 0;
                return;
            }
            _lengthArr -= n;
            this.ChangeLengthInserArray();
            for (int i = 0; i < _lengthArr; i++)
                _arr[i] = _arr[i + n];
        }

        public void RemoveLastMultiple(int n)
        {
            if (_lengthArr == 0)
            {
                throw new Exception("Array list is empty");
            }
            if (n >= _lengthArr)
            {
                T[] newArr = new T[10];
                _arr = newArr;
                _lengthArr = 0;
                return;
            }

            _lengthArr -= n;
            this.ChangeLengthInserArray();
            for (int i = _lengthArr; i < _lengthArr + n; i++)
                _arr[i] = default;
        }

        public void RemoveAtMultiple(int idx, int n)
        {
            if (_lengthArr == 0)
            {
                throw new Exception("Array list is empty");
            }
            if (idx > _lengthArr - 1 || idx < 0)
            {
                throw new IndexOutOfRangeException("Entry index out of range array list");
            }
            
            if (idx + n > _lengthArr)
            {
                n = _lengthArr - idx;
            }

            _lengthArr -= n;
            this.ChangeLengthInserArray();

            for (int i = idx; i < _lengthArr; i++)
            {
                _arr[i] = _arr[i + n];
                _arr[i + n] = default;
            }

        }

        public int RemoveFirst(T val)
        {
            if (_lengthArr == 0)
            {
                throw new Exception("Array list is empty");
            }
            int indexRemoveElemnt = this.IndexOf(val);
            if (indexRemoveElemnt != -1)
            {
                this.RemoveAt(indexRemoveElemnt);
            }

            return indexRemoveElemnt;
        }


        public int RemoveAll(T val)
        {
            if (_lengthArr == 0)
            {
                throw new Exception("Array list is empty");
            }

            int iterator = this.IndexOf(val);
            if (iterator == -1)
                return 0;

            int j = 1; 
            int numberOfRemoveElements = 1;
            while (_arr[iterator+1].CompareTo(val) == 0)
            {
                j++;
                iterator++;
                numberOfRemoveElements++;
            }
            for (int i = iterator-j+1; i < iterator; i++)
            {
                _arr[i] = _arr[i + j];
            }
           

            while (iterator != -1)
            {
                for (int i = iterator; i+j < _lengthArr; i++)
                {
                    iterator++;
                    _arr[i] = _arr[i + j];
                    if (i + j + 1 <= _arr.Length-1 && _arr[i+j+1].CompareTo(val) == 0)
                    {
                        while (i + j + 1 <= _lengthArr - 1 
                            && _arr[i + j + 1].CompareTo(val) == 0)
                        {
                            j++; numberOfRemoveElements++;
                        }
                        iterator = i+1;
                        break;
                    }
                }
                if (iterator + j>= _lengthArr)
                {
                    _lengthArr = _lengthArr - numberOfRemoveElements ;
                    for (int i = _lengthArr; i < _lengthArr+numberOfRemoveElements; i++)
                        _arr[i] = default;
                    break;
                }
            }
            return numberOfRemoveElements;
        }

        public bool Contains(T val)
        {
            if (_lengthArr == 0)
            {
                throw new Exception("Array list is empty");
            }
            bool flag = false;
            for (int i = 0; i < _lengthArr; i++)
            {
                if (_arr[i].CompareTo(val) == 0)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }

        public int IndexOf(T val)
        {
            if (_lengthArr == 0)
            {
                throw new Exception("Array list is empty");
            }
            int index = -1;
            for (int i = 0; i < _lengthArr; i++)
            {
                if (_arr[i].CompareTo(val) == 0)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        //public int[] IndexesOf(int val)
        //{
        //    int[] arrayIndexes = new int[_lengthArr];
        //    int lengthOfArrayIndexes = 0;
        //    for (int i = 0; i < _lengthArr; i++)
        //    {
        //        if (_arr[i] == val)
        //        {
        //            arrayIndexes[lengthOfArrayIndexes] = i;
        //            lengthOfArrayIndexes++;
        //        }
        //    }
        //    return arrayIndexes;
        //}

        public T GetFirst()
        {
            return _arr[0];
        }

        public T GetLast()
        {
            return _arr[_lengthArr-1];
        }

        public T Get(int idx)
        {
            if (idx > _lengthArr - 1 || idx < 0)
            {
                throw new IndexOutOfRangeException("Entry index out of range array list");
            }
            return _arr[idx];
        }

        public void Reverse()
        {
            for (int i = _lengthArr - 1; i >= _lengthArr / 2; i--)
            {
                T temp = _arr[i];
                _arr[i] = _arr[_lengthArr - 1 - i];
                _arr[_lengthArr - 1 - i] = temp;
            }
        }

        public T Max()
        {
            T maxElementArr = _arr[0];

            for (int i = 0; i < _lengthArr; i++)
            {
                if (maxElementArr.CompareTo(_arr[i]) < 0)
                    maxElementArr = _arr[i];
            }
            return maxElementArr;
        }

        public T Min()
        {
            T minElementArr = _arr[0];

            for (int i = 0; i < _lengthArr; i++)
            {
                if (minElementArr.CompareTo(_arr[i]) > 0)
                    minElementArr = _arr[i];
            }
            return minElementArr;
        }

        public int IndexOfMax()
        {
            T maxElementArr = _arr[0];
            int indexOfMax = 0;
            for (int i = 0; i < _lengthArr; i++)
            {
                if (maxElementArr.CompareTo(_arr[i]) < 0)
                {
                    maxElementArr = _arr[i];
                    indexOfMax = i;
                }

            }
            return indexOfMax;
        }

        public int IndexOfMin()
        {
            T minElementArr = _arr[0];
            int indexOfMin = 0;
            for (int i = 0; i < _lengthArr; i++)
            {
                if (minElementArr.CompareTo(_arr[i]) > 0)
                {
                    minElementArr = _arr[i];
                    indexOfMin = i;
                }
                    
            }
            return indexOfMin;
        }

        public void Sort()
        {
            for (int i = 0; i < _lengthArr; i++)
            {

                T temp = _arr[i];
                for (int j = i - 1; j >= 0; j--)
                {
                    if (temp.CompareTo(_arr[j]) < 0)
                    {
                        _arr[j + 1] = _arr[j];
                        _arr[j] = temp;
                    }
                }

            }
        }

        public void SortDesc()
        {
            for (int i = 0; i < _lengthArr; i++)
            {
                T temp = _arr[i];
                for (int j = i - 1; j >= 0; j--)
                {
                    if (temp.CompareTo(_arr[j]) > 0)
                    {
                        _arr[j + 1] = _arr[j];
                        _arr[j] = temp;
                    }
                }
            }
        }

        
    }
}
