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
                int[] newArr = new int[(_arr.Length * 3) / 2];
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
                int[] newArr = new int[(_arr.Length * 3) / 2];
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
            _lengthArr += arr.Length;
            if (_lengthArr >= _arr.Length)
            {
                int[] newArr = new int[(_arr.Length * 3) / 2];
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
    }
}
