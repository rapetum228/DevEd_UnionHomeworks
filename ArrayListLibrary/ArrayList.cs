using System;

namespace ArrayListLibrary
{
    public class ArrList
    {
        private int[] _arr;
        private int _lengthArr;

        public ArrList()
        {
            _arr = new int[10];
            _lengthArr = 0;
        }

        public ArrList(int firstElementArrList)
        {
            _arr = new int[10];
            _arr[0] = firstElementArrList;
            _lengthArr = 1;
        }

        public ArrList(int[] inputArray)
        {
            int arrLength = 10;
            _lengthArr = inputArray.Length;
            while (_lengthArr > arrLength)
            {
                arrLength = (arrLength * 3) / 2;
            }
            _arr = new int[arrLength];
            for (int i = 0; i < _lengthArr; i++)
                _arr[i] = inputArray[i];
        }

        public ArrList(ArrList inputArrList)
        {
            int arrLength = 10;
            _lengthArr = inputArrList.GetLength();
            while (_lengthArr > arrLength)
            {
                arrLength = (arrLength * 3) / 2;
            }
            _arr = new int[arrLength];
            for (int i = 0; i < _lengthArr; i++)
                _arr[i] = inputArrList.Get(i);
        }

        
        public int GetLength()
        {
            return _lengthArr;
        }

        public int[] ToArray()
        {
            int[] newArr = new int[_lengthArr];
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
                int[] newArr = new int[newArrLength];
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
                int[] newArr = new int[newArrLength];
                for (int i = 0; i < _arr.Length; i++)
                {
                    newArr[i] = _arr[i];
                }
                _arr = newArr;
                return true;
            }
            return false;
        }

        public void AddFirst(int val)
        {
            _lengthArr++;
            this.ChangeLengthInserArray();
 
            for (int i = _lengthArr-1; i > 0 ; i--)
                _arr[i] = _arr[i - 1];
            _arr[0] = val;

        }


        public void AddFirst(int[] arr)
        {
            _lengthArr += arr.Length;
            this.ChangeLengthInserArray();
            for (int i = _lengthArr - 1; i > arr.Length - 1; i--)
                _arr[i] = _arr[i - arr.Length];

            for (int i = 0; i < arr.Length; i++)
                _arr[i] = arr[i];
        }

        public void AddFirst(ArrList list)
        {
            AddFirst(list.ToArray());
        }

        public void AddLast(int val)
        {
            _lengthArr++;
            this.ChangeLengthInserArray();
            _arr[_lengthArr - 1] = val;
        }

        public void AddLast(int[] arr)
        {
            _lengthArr += arr.Length;
            this.ChangeLengthInserArray();
            for (int i = _lengthArr - arr.Length; i < _lengthArr; i++)
                _arr[i] = arr[i - (_lengthArr - arr.Length)];
        }

        public void AddLast(ArrList list)
        {
            AddLast(list.ToArray());
        }

        public void AddAt(int idx, int val)
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

        public void AddAt(int idx, int[] arr)
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

        public void AddAt(int idx, ArrList list)
        {
            AddAt(idx, list.ToArray());
        }

        public void Set(int idx, int val)
        {
            if (idx > _lengthArr - 1 || idx < 0)
            {
                throw new IndexOutOfRangeException("Entry index out of range array list");
            }
            
            _arr[idx] = val;
        }

        public void RemoveFirst()
        {
            _lengthArr--;
            this.ChangeLengthInserArray();
            for (int i = 0; i < _lengthArr; i++)
                _arr[i] = _arr[i + 1];
            _arr[_lengthArr] = 0;
        }

        public void RemoveLast()
        {
            _lengthArr--;
            this.ChangeLengthInserArray();
            _arr[_lengthArr] = 0;
        }

        public void RemoveAt(int idx)
        {
            if (idx > _lengthArr - 1 || idx < 0)
            {
                throw new IndexOutOfRangeException("Entry index out of range array list");
            }
            _lengthArr--;
            this.ChangeLengthInserArray();
            for (int i = idx; i < _lengthArr; i++)
                _arr[i] = _arr[i + 1];
            _arr[_lengthArr] = 0;

        }

        public void RemoveFirstMultiple(int n)
        {
            if (n > _lengthArr)
            {
                int[] newArr = new int[10];
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
            if (n >= _lengthArr)
            {
                int[] newArr = new int[10];
                _arr = newArr;
                _lengthArr = 0;
                return;
            }

            _lengthArr -= n;
            this.ChangeLengthInserArray();
            for (int i = _lengthArr; i < _lengthArr + n; i++)
                _arr[i] = 0;
        }

        public void RemoveAtMultiple(int idx, int n)
        {
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
                _arr[i + n] = 0;
            }

        }

        public void RemoveFirst(int val)
        {
            int indexRemoveElemnt = this.IndexOf(val);
            this.RemoveAt(indexRemoveElemnt);

        }


        public int RemoveAll(int val)
        {
            int numberOfRemoveElements = 0;
            
            int iterator = this.IndexOf(val);
            int j = 1;
            while (iterator != -1)
            {
                for (int i = iterator; i+j <= _lengthArr; i++)
                {
                    iterator++;
                    _arr[i] = _arr[i + j];
                    if (i + j + 1 <= _arr.Length-1 && _arr[i+j+1] == val)
                    {
                        while (i + j + 1 <= _lengthArr - 1 && _arr[i + j + 1] == val)
                        {
                            j++; numberOfRemoveElements++;
                        }
                        iterator = i+1;
                        break;
                    }
                }
                if (iterator + j > _lengthArr)
                {
                    _lengthArr = _lengthArr - numberOfRemoveElements -1;
                    for (int i = _lengthArr; i < _lengthArr+numberOfRemoveElements+1; i++)
                        _arr[i] = 0;
                    break;
                }
            }
            return numberOfRemoveElements+1;
        }

        public bool Contains(int val)
        {
            bool flag = false;
            for (int i = 0; i < _lengthArr; i++)
            {
                if (_arr[i] == val)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }

        public int IndexOf(int val)
        {
            int index = -1;
            for (int i = 0; i < _lengthArr; i++)
            {
                if (_arr[i] == val)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public int[] IndexesOf(int val)
        {
            int[] arrayIndexes = new int[_lengthArr];
            int lengthOfArrayIndexes = 0;
            for (int i = 0; i < _lengthArr; i++)
            {
                if (_arr[i] == val)
                {
                    arrayIndexes[lengthOfArrayIndexes] = i;
                    lengthOfArrayIndexes++;
                }
            }
            return arrayIndexes;
        }

        public int GetFirst()
        {
            return _arr[0];
        }

        public int GetLast()
        {
            return _arr[_lengthArr-1];
        }

        public int Get(int idx)
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
                int temp = _arr[i];
                _arr[i] = _arr[_lengthArr - 1 - i];
                _arr[_lengthArr - 1 - i] = temp;
            }
        }

        public int Max()
        {
            int maxElementArr = _arr[0];

            for (int i = 0; i < _lengthArr; i++)
            {
                if (maxElementArr < _arr[i])
                    maxElementArr = _arr[i];
            }
            return maxElementArr;
        }

        public int Min()
        {
            int minElementArr = _arr[0];

            for (int i = 0; i < _lengthArr; i++)
            {
                if (minElementArr > _arr[i])
                    minElementArr = _arr[i];
            }
            return minElementArr;
        }

        public int IndexOfMax()
        {
            int maxElementArr = _arr[0];
            int indexOfMax = 0;
            for (int i = 0; i < _lengthArr; i++)
            {
                if (maxElementArr < _arr[i])
                {
                    maxElementArr = _arr[i];
                    indexOfMax = i;
                }

            }
            return indexOfMax;
        }

        public int IndexOfMin()
        {
            int minElementArr = _arr[0];
            int indexOfMin = 0;
            for (int i = 0; i < _lengthArr; i++)
            {
                if (minElementArr > _arr[i])
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

                int temp = _arr[i];
                for (int j = i - 1; j >= 0; j--)
                {
                    if (temp < _arr[j])
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
                int temp = _arr[i];
                for (int j = i - 1; j >= 0; j--)
                {
                    if (temp > _arr[j])
                    {
                        _arr[j + 1] = _arr[j];
                        _arr[j] = temp;
                    }
                }
            }
        }

        
    }
}
