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
    }
}
