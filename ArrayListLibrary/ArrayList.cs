using System;

namespace ArrayListLibrary
{
    public class ArrayList
    {
        private int[] _arr;
        private int _lengthArr;

        public ArrayList()
        {
            _arr = new int[10];
            _lengthArr = 0;
        }

        public ArrayList(int firstElementArrList)
        {
            _arr = new int[10];
            _arr[0] = firstElementArrList;
            _lengthArr = 1;
        }

        public ArrayList(int[] inputArray)
        {
            _lengthArr = inputArray.Length;
            _arr = new int[10];
            for (int i = 0; i < _lengthArr; i++)
                _arr[i] = inputArray[i];
        }

        public int GetLength()
        {
            return _lengthArr;
        }

        public int[] ToArray()
        {
            return _arr;
        }

        public void AddFirst(int val)
        {
            _lengthArr++;

            if (_lengthArr >= _arr.Length) 
            {
                int[] newArr = new int[(_arr.Length * 3) / 2];
                for (int i = 0; i < _lengthArr - 1; i++)
                    newArr[_lengthArr - i - 1] = _arr[_lengthArr - i - 2];

                newArr[0] = val;
                _arr = newArr;
            }
            else
            {
                for (int i = 0; i < _lengthArr - 1; i++)
                    _arr[_lengthArr - i - 1] = _arr[_lengthArr - i - 2];

                _arr[0] = val;
            } 

        }


        public void AddFirst(int[] arr)
        {
            _lengthArr += arr.Length;
            
            if (_lengthArr >= _arr.Length)
            {
                int newArrLength = (_arr.Length * 3) / 2;
                while (_lengthArr >= newArrLength)
                    newArrLength = (newArrLength * 3) / 2;
                
                int[] newArr = new int[newArrLength];

                for (int i = _lengthArr - 1; i > arr.Length - 1; i--)
                    newArr[i] = _arr[i - arr.Length];

                for (int i = 0; i < arr.Length; i++)
                    newArr[i] = arr[i];

                _arr = newArr;
            }
            else
            {
                for (int i = _lengthArr-1; i > arr.Length-1; i--)
                    _arr[i] = _arr[i - arr.Length];

                for (int i = 0; i < arr.Length; i++)
                    _arr[i] = arr[i];
            }
        }

        public void AddLast(int val)
        {
            _lengthArr++;
            if (_lengthArr >= _arr.Length)
            {
                int[] newArr = new int[(_arr.Length * 3) / 2];
                for (int i = 0; i < _arr.Length; i++)
                    newArr[i] = _arr[i];
                newArr[_lengthArr-1] = val;
                _arr = newArr;
            }                
            else
                _arr[_lengthArr - 1] = val;
        }

        public void AddLast(int[] arr)
        {
            _lengthArr += arr.Length;

            if (_lengthArr >= _arr.Length)
            {
                int newArrLength = (_arr.Length * 3) / 2;
                while (_lengthArr >= newArrLength)
                    newArrLength = (newArrLength * 3) / 2;

                int[] newArr = new int[newArrLength];

                for (int i = _lengthArr - arr.Length; i < _lengthArr; i++)
                    newArr[i] = arr[i - (_lengthArr - arr.Length)];

                for (int i = 0; i < _lengthArr - arr.Length; i++)
                    newArr[i] = _arr[i];

                _arr = newArr;
            }
            else
            {
                for (int i = _lengthArr - arr.Length; i < _lengthArr; i++)
                    _arr[i] = arr[i - (_lengthArr - arr.Length)];
            }
        }

        public void AddAt(int idx, int val)
        {
            _lengthArr++;
            if (_lengthArr >= _arr.Length)
            {
                int[] newArr = new int[(_arr.Length * 3) / 2];
                
                for (int i = _lengthArr; i > idx; i--)
                    newArr[i] = _arr[i-1];
                for (int i = 0; i < idx; i++)
                    newArr[i] = _arr[i];
                newArr[idx] = val;
                _arr = newArr;
            }
            else
            {
                for (int i = _lengthArr; i > idx; i--)
                    _arr[i] = _arr[i - 1];
                _arr[idx] = val;
            } 
        }

        public void AddAt(int idx, int[] arr)
        {
            if (idx > _lengthArr)
            {
                return;
            }
            _lengthArr += arr.Length;
            if (_lengthArr >= _arr.Length)
            {
                int newArrLength = (_arr.Length * 3) / 2;
                while (_lengthArr >= newArrLength)
                    newArrLength = (newArrLength * 3) / 2;

                int[] newArr = new int[newArrLength];
                for (int i = 0; i < idx; i++)
                    newArr[i] = _arr[i];

                for (int i = _lengthArr - 1; i >= idx + arr.Length; i--)
                    newArr[i] = _arr[i - arr.Length];

                for (int i = idx; i < idx + arr.Length; i++)
                    newArr[i] = arr[i - idx];
                _arr = newArr;
            }
            else
            {
                for (int i = _lengthArr-1; i >= idx + arr.Length; i--)
                    _arr[i] = _arr[i - arr.Length ];
                for (int i = idx; i < idx + arr.Length; i++)
                    _arr[i] = arr[i - idx];
            }
        }

        public void Set(int idx, int val)
        {
            if (idx > _lengthArr - 1)
            {
                return;
            }
            _arr[idx] = val;
        }

        public void RemoveFirst()
        {
            _lengthArr--;
            if (_lengthArr < (_arr.Length * 2) / 3)
            {
                int[] newArr = new int[(_arr.Length * 2) / 3];
                for (int i = 0; i < _lengthArr; i++)
                    newArr[i] = _arr[i + 1];
                newArr[_lengthArr] = 0;
                _arr = newArr;
            }
            else
            {
                for (int i = 0; i < _lengthArr; i++)
                    _arr[i] = _arr[i + 1];
                _arr[_lengthArr] = 0;
            }
        }

        public void RemoveLast()
        {
            _lengthArr--;
            if (_lengthArr < (_arr.Length * 2) / 3)
            {
                int[] newArr = new int[(_arr.Length * 2) / 3];
                for (int i = 0; i < _lengthArr; i++)
                    newArr[i] = _arr[i];
                _arr = newArr;
            }
            else
                _arr[_lengthArr] = 0;
        }

        public void RemoveAt(int idx)
        {
            if (idx > _lengthArr - 1)
            {
                return;
            }
            _lengthArr--;
            if (_lengthArr < (_arr.Length * 2) / 3)
            {
                int[] newArr = new int[(_arr.Length * 2) / 3];
                for (int i = 0; i < idx; i++)
                    newArr[i] = _arr[i];
                for (int i = idx; i < _lengthArr; i++)
                    newArr[i] = _arr[i+1];
                _arr = newArr;
            }
            else 
            {
                for (int i = idx; i < _lengthArr; i++)
                    _arr[i] = _arr[i + 1];
                _arr[_lengthArr] = 0;
            }
                
        }

        public void RemoveFirstMultiple(int n)
        {
            if (n > _lengthArr)
            {
                int[] newArr = new int[10];
                _arr = newArr;
            }
            _lengthArr -= n;

            if (_lengthArr < (_arr.Length * 2) / 3) 
            {
                int[] newArr = new int[(_arr.Length * 2) / 3];
                for (int i = 0; i < _lengthArr; i++)
                    newArr[i] = _arr[i + n];
                _arr = newArr;
            }
            else
            {
                for (int i = 0; i < _lengthArr; i++)
                    _arr[i] = _arr[i+n];
            }
        }

        public void RemoveLastMultiple(int n)
        {
            if (n > _lengthArr)
            {
                int[] newArr = new int[10];
                _arr = newArr;
            }

            _lengthArr -= n;

            if (_lengthArr < (_arr.Length * 2) / 3)
            {
                int[] newArr = new int[(_arr.Length * 2) / 3];
                for (int i = 0; i < _lengthArr; i++)
                    newArr[i] = _arr[i];
                _arr = newArr;
            }
            else
            {
                for (int i = _lengthArr; i < _lengthArr + n; i++)
                    _arr[i] = 0;
            }
        }

        public void RemoveAtMultiple(int idx, int n)
        {
            if (idx > _lengthArr - 1)
            {
                return;
            }

            if (idx + n > _lengthArr)
            {
                n = _lengthArr - idx;
            }

            _lengthArr -= n;

            if (_lengthArr < (_arr.Length * 2) / 3)
            {
                int[] newArr = new int[(_arr.Length * 2) / 3];

                for (int i = 0; i < idx; i++)
                    newArr[i] = _arr[i];
                
                for (int i = idx; i < _lengthArr; i++)
                    newArr[i] = _arr[i + n];
                
                _arr = newArr;
            }
            else
            {
                for (int i = idx; i < _lengthArr; i++)
                {
                    _arr[i] = _arr[i + n];
                    _arr[i + n] = 0;
                }
            }

        }

        public void RemoveFirst(int val)
        {
            _lengthArr--;
            if (_lengthArr < (_arr.Length * 2) / 3)
            {
                int[] newArr = new int[(_arr.Length * 2) / 3];
                for (int i = 0; i < _lengthArr; i++)
                {
                    newArr[i] = _arr[i];
                    if (_arr[i] == val)
                    {
                        for (int j = i; j < _lengthArr; j++)
                            newArr[j] = _arr[j + 1];
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < _lengthArr; i++)
                {
                    if (_arr[i] == val)
                    {
                        for (int j = i; j < _lengthArr; j++)
                            _arr[j] = _arr[j + 1];
                        break;
                    }
                }
                _arr[_lengthArr] = 0;
            }
        }


        public int RemoveAll(int val)
        {
            int numberOfRemoveElements = 0;

            for (int i = 0; i < _lengthArr; i++)
            {
                if (_arr[i] == val)
                {
                    numberOfRemoveElements ++;
                    _lengthArr--;
                    for (int j = i; j < _lengthArr; j++)
                        _arr[j] = _arr[j + 1];
                    i--;
                }
            }
            for (int i = _lengthArr; i < _lengthArr + numberOfRemoveElements; i++)
                _arr[i] = 0;

            if (_lengthArr < (_arr.Length * 2) / 3)
            {
                int[] newArr = new int[(_arr.Length * 2) / 3];
                for (int i = 0; i < _lengthArr; i++)
                    newArr[i] = _arr[i];
                _arr = newArr;
            }
            return numberOfRemoveElements;
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

        public int GetFirst()
        {
            return _arr[0];
        }

        public int GetLast()
        {
            return _arr[_lengthArr];
        }

        public int Get(int idx)
        {
            if (idx > _lengthArr - 1)
            {
                throw new IndexOutOfRangeException("Вышли за пределы массива");
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

        public void SorttDesc()
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
