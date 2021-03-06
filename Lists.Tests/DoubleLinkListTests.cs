using Lists;
using NUnit.Framework;
using System;

namespace LinkedLists.Tests
{
    public class DoubleLinkListTests
    {
        [SetUp]
        public void Setup()
        {
        }
        [TestCase(20)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        
        public void ToArrayTest(int ID)
        {
            //arrange
            int[] toTest = TestDataList.GetArrayForToArrayAndGetLengthTest(ID);
            DoublyLinkedList<int> toTestList = new DoublyLinkedList<int>(toTest);
            int[] expected = TestDataList.GetExpectedArrayForToArrayTest(ID);
            //act
            int[] actual = toTestList.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 1)]
        [TestCase(1, 1)]
        [TestCase(2, 4)]
        [TestCase(3, 5)]
        [TestCase(20, 0)]
        public void GetLengthTest(int ID, int expected)
        {
            //arrange
            int[] toTest = TestDataList.GetArrayForToArrayAndGetLengthTest(ID);
            DoublyLinkedList<int> toTestList = new DoublyLinkedList<int>(toTest);
            //act
            int actual = toTestList.GetLength();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 2)]
        [TestCase(1, 12)]
        [TestCase(2, 5)]
        [TestCase(20, 0)]
        public void AddLastTest(int ID, int value)
        {
            //arrange
            int[] toTest = TestDataList.GetListForAddLastTest(ID);
            DoublyLinkedList<int> toTestList = new DoublyLinkedList<int>(toTest);
            int[] expected = TestDataList.GetExpectedArrayForAddLastTest(ID);
            //act
            toTestList.AddLast(value);
            int[] actual = toTestList.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase(20)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        
        public void AddLastListTest(int ID)
        {
            //arrange
            int[] toTest = TestDataList.GetListForAddLastTest(ID);
            DoublyLinkedList<int> toTestList = new DoublyLinkedList<int>(toTest);
            int[] addArray = TestDataList.GetAddListForAddLastTest(ID);
            DoublyLinkedList<int> add = new DoublyLinkedList<int>(addArray);
            int[] expected = TestDataList.GetExpectedListForAddLastTest(ID);
            //act
            toTestList.AddLast(add);
            int[] actual = toTestList.ToArray();
            
            //assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(addArray, add.ToArray());
        }

        
        
        [TestCase(0, 2)]
        [TestCase(1, 12)]
        [TestCase(2, 5)]
        [TestCase(20, 0)]
        public void AddFirstTest(int ID, int value)
        {
            //arrange
            int[] toTestArray = TestDataList.GetListForAddFirstTest(ID);
            DoublyLinkedList<int> toTest = new DoublyLinkedList<int>(toTestArray);
            int[] expected = TestDataList.GetExpectedArrayForAddFirstTest(ID);
            //act
            toTest.AddFirst(value);
            int[] actual = toTest.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }

        
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(20)]
        [TestCase(2)]
        public void AddFirstListTest(int ID)
        {
            //arrange
            int[] toTestArray = TestDataList.GetListForAddFirstTest(ID);
            DoublyLinkedList<int> toTest = new DoublyLinkedList<int>(toTestArray);
            int[] addArray = TestDataList.GetAddListForAddFirstTest(ID);
            DoublyLinkedList<int> add = new DoublyLinkedList<int>(addArray);
            int[] expected = TestDataList.GetExpectedListForAddFirstTest(ID);

            //act
            toTest.AddFirst(add);
            int[] actual = toTest.ToArray();

            //assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(addArray, add.ToArray());
        }

        [TestCase(0, 0, 2)]
        [TestCase(1, 0, 12)]
        [TestCase(2, 2, 5)]
        [TestCase(3, 3, 0)]
        [TestCase(4, 0, 0)]
        [TestCase(5, 2, 100)]
        [TestCase(6, 1, 0)]
        public void AddAtTest(int ID, int idx, int value)
        {
            //arrange
            int[] toTestArray = TestDataList.GetListForAddAtTest(ID);
            DoublyLinkedList<int> toTest = new DoublyLinkedList<int>(toTestArray);
            int[] expected = TestDataList.GetExpectedArrayForAddAtTest(ID);
            //act
            toTest.AddAt(idx, value);
            int[] actual = toTest.ToArray();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(100, 1, 2, "List is empty")]
        [TestCase(1, 10, 2, "Index out of range list length")]
        public void AddAtNegativeTest(int ID, int idx, int value,
            string expectedMessage)
        {
            //arrange
            int[] toTestArray = TestDataList.GetListForAddAtTest(ID);
            DoublyLinkedList<int> toTest = new DoublyLinkedList<int>(toTestArray);

            if (ID == 1)
            {
                //act
                Exception ex = Assert.Throws(typeof(IndexOutOfRangeException),
                    () => toTest.AddAt(idx, value));
                //assert
                Assert.AreEqual(expectedMessage, ex.Message);
            }
            else
            {
                //act
                Exception ex = Assert.Throws(typeof(Exception),
                    () => toTest.AddAt(idx, value));
                //assert
                Assert.AreEqual(expectedMessage, ex.Message);
            }
            
        }
        
        
        [TestCase(0, 0)]
        [TestCase(1, 0)]
        [TestCase(2, 0)]
        [TestCase(3, 2)]
        [TestCase(4, 0)]
        [TestCase(5, 4)]
        [TestCase(6, 3)]
        public void AddAtListTest(int ID, int idx)
        {
            //arrange
            int[] toTestArray = TestDataList.GetListForAddAtTest(ID);
            DoublyLinkedList<int> toTest = new DoublyLinkedList<int>(toTestArray);
            int[] addArray = TestDataList.GetAddListForAddAtTest(ID);
            DoublyLinkedList<int> add = new DoublyLinkedList<int>(addArray);
            int[] expected = TestDataList.GetExpectedListForAddAtTest(ID);
            //act
            toTest.AddAt(idx, add);
            int[] actual = toTest.ToArray();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, 10, "Index out of range list length")]
        [TestCase(100, 0, "List is empty")]
        public void AddAtListNegativeTest(int ID, int idx,
            string expectedMessage)
        {
            //arrange
            int[] toTestArray = TestDataList.GetListForAddAtTest(ID);
            DoublyLinkedList<int> toTest = new DoublyLinkedList<int>(toTestArray);
            int[] addArray = TestDataList.GetAddListForAddAtTest(ID);
            DoublyLinkedList<int> add = new DoublyLinkedList<int>(addArray);
            if(ID == 1)
            {
                //act
                Exception ex = Assert.Throws(typeof(IndexOutOfRangeException),
                    () => toTest.AddAt(idx, add));
                //assert
                Assert.AreEqual(expectedMessage, ex.Message);
            }
            else
            {
                //act
                Exception ex = Assert.Throws(typeof(Exception),
                    () => toTest.AddAt(idx, add));
                //assert
                Assert.AreEqual(expectedMessage, ex.Message);
            }
        }

        [TestCase(0, 2, 0)]
        [TestCase(1, 0, 4)]
        public void SetTest(int ID, int idx, int val)
        {
            //arrange
            int[] toTestArray = TestDataList.GetListForSetTest(ID);
            DoublyLinkedList<int> toTest = new(toTestArray);
            int[] expected = TestDataList.GetExpectedListForSetTest(ID);
            //act
            toTest.Set(idx, val);
            int[] actual = toTest.ToArray();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 10, 2, "Index out of range list length")]
        [TestCase(22, 0, 2, "List is empty")]
        public void SetNegativeTest(int ID, int idx, int value,
            string expectedMessage)
        {
            //arrange
            int[] toTestArray = TestDataList.GetListForSetTest(ID);
            DoublyLinkedList<int> toTest = new(toTestArray);

            if(ID == 1)
            {
                //act
                Exception ex = Assert.Throws(typeof(IndexOutOfRangeException),
                    () => toTest.Set(idx, value));
                //assert
                Assert.AreEqual(expectedMessage, ex.Message);
            }
            else
            {
                //act
                Exception ex = Assert.Throws(typeof(Exception),
                    () => toTest.Set(idx, value));
                //assert
                Assert.AreEqual(expectedMessage, ex.Message);
            }
            
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        public void RemoveFirstTest(int ID)
        {
            //arrange
            int[] toTestArray = TestDataList.GetListForRemoveFirstLastAtTest(ID);
            DoublyLinkedList<int> toTest = new(toTestArray);
            int[] expected = TestDataList.GetExpectedListForRemoveFirstTest(ID);
            //act
            toTest.RemoveFirst();
            int[] actual = toTest.ToArray();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        public void RemoveLastTest(int ID)
        {
            //arrange
            int[] toTestArray = TestDataList.GetListForRemoveFirstLastAtTest(ID);
            DoublyLinkedList<int> toTest = new(toTestArray);
            int[] expected = TestDataList.GetExpectedListForRemoveLastTest(ID);
            //act
            toTest.RemoveLast();
            int[] actual = toTest.ToArray();

            //assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestCase(0, 2)]
        [TestCase(1, 0)]
        [TestCase(2, 0)]
        [TestCase(3, 3)]
        public void RemoveAtTest(int ID, int idx)
        {
            //arrange
            int[] toTestArray = TestDataList.GetListForRemoveFirstLastAtTest(ID);
            DoublyLinkedList<int> toTest = new(toTestArray);
            int[] expected = TestDataList.GetExpectedListForRemoveAtTest(ID);
            //act
            toTest.RemoveAt(idx);
            int[] actual = toTest.ToArray();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 10, "Index out of range list length")]
        [TestCase(22, 0, "List is empty")]
        public void RemoveFirstLastAtNegativeTest(int ID, int idx,
            string expectedMessage)
        {
            //arrange
            int[] toTestArray = TestDataList.GetListForRemoveFirstLastAtTest(ID);
            DoublyLinkedList<int> toTest = new(toTestArray);

            //act
            if (ID == 1)
            {
                Exception ex = Assert.Throws(typeof(IndexOutOfRangeException),
                () => toTest.RemoveAt(idx));
                //assert
                Assert.AreEqual(expectedMessage, ex.Message);
            }
            else
            {
                Exception exRemoveAt = Assert.Throws(typeof(Exception),
                                () => toTest.RemoveAt(idx));
                Exception exRemoveLast = Assert.Throws(typeof(Exception),
                                () => toTest.RemoveLast());
                Exception exRemoveFirst = Assert.Throws(typeof(Exception),
                                () => toTest.RemoveFirst());
                //assert
                Assert.AreEqual(expectedMessage, exRemoveAt.Message);
                Assert.AreEqual(expectedMessage, exRemoveLast.Message);
                Assert.AreEqual(expectedMessage, exRemoveFirst.Message);
            }
            
        }

        [TestCase(0, 3)]
        [TestCase(1, 4)]
        [TestCase(2, 4)]
        [TestCase(3, 1)]
        [TestCase(4, 0)]
        [TestCase(5, 6)]
        [TestCase(6, 2)]
        public void RemoveFirstMultipleTest(int ID, int n)
        {
            //arrange
            int[] toTestArray = TestDataList.GetListForRemoveFirstLastAtMultipleTest(ID);
            DoublyLinkedList<int> toTest = new DoublyLinkedList<int>(toTestArray);
            int[] expected = TestDataList.GetExpectedListForRemoveFirstMultipleTest(ID);
            //act
            toTest.RemoveFirstMultiple(n);
            int[] actual = toTest.ToArray();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(12, 4, "List is empty")]
        public void RemoveFirstMultipleNegativeTest(int ID, int n, string expectedMessage)
        {
            //arrange
            int[] toTestArray = TestDataList.GetListForRemoveFirstLastAtMultipleTest(ID);
            DoublyLinkedList<int> toTest = new DoublyLinkedList<int>(toTestArray);
            Exception ex = Assert.Throws(typeof(Exception),
                () => toTest.RemoveFirstMultiple(n));
            //act

            //assert
            Assert.AreEqual(expectedMessage, ex.Message);
        }



        [TestCase(0, 3)]
        [TestCase(1, 4)]
        [TestCase(2, 2)]
        [TestCase(3, 1)]
        [TestCase(4, 0)]
        [TestCase(5, 6)]
        [TestCase(6, 2)]
        public void RemoveLastMultipleTest(int ID, int n)
        {
            //arrange
            int[] toTestArray = TestDataList.GetListForRemoveFirstLastAtMultipleTest(ID);
            DoublyLinkedList<int> toTest = new DoublyLinkedList<int>(toTestArray);
            int[] expected = TestDataList.GetExpectedListForRemoveLastMultipleTest(ID);
            //act
            toTest.RemoveLastMultiple(n);
            int[] actual = toTest.ToArray();

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestCase(12, 4, "List is empty")]
        public void RemoveLastMultipleNegativeTest(int ID, int n, string expectedMessage)
        {
            //arrange
            int[] toTestArray = TestDataList.GetListForRemoveFirstLastAtMultipleTest(ID);
            DoublyLinkedList<int> toTest = new DoublyLinkedList<int>(toTestArray);
            Exception ex = Assert.Throws(typeof(Exception),
                () => toTest.RemoveLastMultiple(n));
            //act

            //assert
            Assert.AreEqual(expectedMessage, ex.Message);
        }


        [TestCase(2, 2, 5)]
        [TestCase(0, 2, 3)]
        [TestCase(1, 0, 4)]
        [TestCase(3, 2, 0)]
        [TestCase(4, 5, 1)]
        [TestCase(5, 0, 3)]
        [TestCase(6, 4, 3)]
        public void RemoveAtMultipleTest(int ID, int idx, int n)
        {
            //arrange
            int[] toTestArray = TestDataList.GetListForRemoveFirstLastAtMultipleTest(ID);
            DoublyLinkedList<int> toTest = new DoublyLinkedList<int>(toTestArray);
            int[] expected = TestDataList.GetExpectedListForRemoveAtMultipleTest(ID);
            //act
            toTest.RemoveAtMultiple(idx, n);
            int[] actual = toTest.ToArray();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 10, 2, "Index out of range list length")]
        [TestCase(22, 0, 2, "List is empty")]
        public void RemoveAtMultipleNegativeTest(int ID, int idx, int n,
            string expectedMessage)
        {
            //arrange
            int[] toTestArray = TestDataList.GetListForRemoveFirstLastAtMultipleTest(ID);
            DoublyLinkedList<int> toTest = new DoublyLinkedList<int>(toTestArray);

            //act
            Exception ex = Assert.Throws(typeof(Exception),
                () => toTest.RemoveAtMultiple(idx, n));

            //assert
            Assert.AreEqual(expectedMessage, ex.Message);
        }

        [TestCase(0, 8, 2)]
        [TestCase(1, 8, 0)]
        [TestCase(2, 8, 0)]
        [TestCase(3, 8, -1)]
        public void RemoveFirstValTest(int ID, int val, int expectedIndex)
        {
            //arrange
            int[] arrayToTest = TestDataList.GetListForRemoveFirstValAndAllTest(ID);
            DoublyLinkedList<int> toTest = new DoublyLinkedList<int>(arrayToTest);
            int[] expected = TestDataList.GetExpectedListForRemoveFirstValTest(ID);
            //act
            int actualIndex = toTest.RemoveFirst(val);
            int[] actual = toTest.ToArray();

            //assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedIndex, actualIndex);
        }

        
        [TestCase(0, 8, 4)]
        [TestCase(1, 8, 3)]
        [TestCase(2, 8, 3)]
        [TestCase(3, 8, 0)]
        public void RemoveAllTest(int ID, int val, int expectedRemoveNumbers)
        {
            //arrange
            int[] arrayToTest = TestDataList.GetListForRemoveFirstValAndAllTest(ID);
            DoublyLinkedList<int> toTest = new DoublyLinkedList<int>(arrayToTest);
            int[] expected = TestDataList.GetExpectedListForRemoveAllTest(ID);
            //act
            int actualRemoveNumbers = toTest.RemoveAll(val);
            int[] actual = toTest.ToArray();

            //assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedRemoveNumbers, actualRemoveNumbers);
        }

        
        [TestCase(0, 8, true)]
        [TestCase(1, 8, true)]
        [TestCase(2, 8, true)]
        [TestCase(3, 8, false)]
        public void ContainsTest(int ID, int val, bool expected)
        {
            //arrange
            int[] arrToTest = TestDataList.GetListForGetFirstGetLastGetTest(ID);
            DoublyLinkedList<int> toTest = new DoublyLinkedList<int>(arrToTest);
            //act
            bool actual = toTest.Contains(val);


            //assert
            Assert.AreEqual(expected, actual);
        }

        
        [TestCase(0, 8, 4)]
        [TestCase(1, 8, 0)]
        [TestCase(2, 8, 0)]
        [TestCase(3, 8, -1)]

        public void IndexOfTest(int ID, int val, int expected)
        {
            //arrange
            int[] arrToTest = TestDataList.GetListForGetFirstGetLastGetTest(ID);
            DoublyLinkedList<int> toTest = new DoublyLinkedList<int>(arrToTest);

            //act
            int actual = toTest.IndexOf(val);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(22, "List is empty")]
        public void ContainsIndexOfRemoveFirstValRemoveAllNegativeTest(int ID, string expectedMessage)
        {
            //arrange
            int[] arrToTest = TestDataList.GetListForGetFirstGetLastGetTest(ID);
            DoublyLinkedList<int> toTest = new DoublyLinkedList<int>(arrToTest);

            //act
            Exception exContains = Assert.Throws(typeof(Exception),
                () => toTest.Contains(2));
            Exception exIndexOf = Assert.Throws(typeof(Exception),
                () => toTest.IndexOf(2));
            Exception exRemoveFirst = Assert.Throws(typeof(Exception),
                () => toTest.RemoveFirst(2));
            Exception exRemoveAll = Assert.Throws(typeof(Exception),
                () => toTest.RemoveAll(3));

            //assert
            Assert.AreEqual(expectedMessage, exContains.Message);
            Assert.AreEqual(expectedMessage, exIndexOf.Message);
            Assert.AreEqual(expectedMessage, exRemoveFirst.Message);
            Assert.AreEqual(expectedMessage, exRemoveAll.Message);
        }

        [TestCase(0, 12)]
        [TestCase(1, 8)]
        [TestCase(2, 8)]
        [TestCase(3, 5)]
        [TestCase(4, 228)]
        public void GetFirstTest(int ID, int expected)
        {
            //arrange
            int[] arrToTest = TestDataList.GetListForGetFirstGetLastGetTest(ID);
            DoublyLinkedList<int> toTest = new DoublyLinkedList<int>(arrToTest);

            //act
            int actual = toTest.GetFirst();


            //assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestCase(22, "List is empty")]
        public void GetFirstNegativeTest(int ID, string expectedMessage)
        {
            //arrange
            int[] arrToTest = TestDataList.GetListForGetFirstGetLastGetTest(ID);
            DoublyLinkedList<int> toTest = new DoublyLinkedList<int>(arrToTest);

            //act
            Exception ex = Assert.Throws(typeof(Exception),
                () => toTest.GetFirst());

            //assert
            Assert.AreEqual(expectedMessage, ex.Message);
        }
        
        [TestCase(0, 8)]
        [TestCase(1, 4)]
        [TestCase(2, 8)]
        [TestCase(3, 0)]
        [TestCase(4, 228)]
        public void GetLastTest(int ID, int expected)
        {
            //arrange
            int[] arrToTest = TestDataList.GetListForGetFirstGetLastGetTest(ID);
            DoublyLinkedList<int> toTest = new DoublyLinkedList<int>(arrToTest);

            //act
            int actual = toTest.GetLast();


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(22, "List is empty")]
        public void GetLastNegativeTest(int ID, string expectedMessage)
        {
            //arrange
            int[] arrToTest = TestDataList.GetListForGetFirstGetLastGetTest(ID);
            DoublyLinkedList<int> toTest = new DoublyLinkedList<int>(arrToTest);

            //act
            Exception ex = Assert.Throws(typeof(Exception),
                () => toTest.GetLast());

            //assert
            Assert.AreEqual(expectedMessage, ex.Message);
        }

        
        [TestCase(0, 2, -9)]
        [TestCase(1, 2, 3)]
        [TestCase(2, 0, 8)]
        [TestCase(3, 2, 1)]
        [TestCase(4, 0, 228)]
        public void GetTest(int ID, int idx,  int expected)
        {
            //arrange
            int[] arrToTest = TestDataList.GetListForGetFirstGetLastGetTest(ID);
            DoublyLinkedList<int> toTest = new DoublyLinkedList<int>(arrToTest);
            //act
            int actual = toTest.Get(idx);
            //assert
            Assert.AreEqual(expected, actual);
        }

        
        [TestCase(1, 14, "Entry index out of range length list")]
        [TestCase(22, 1, "List is empty")]
        public void GetNegativeTest(int ID, int idx, string expectedMessage)
        {
            //arrange
            int[] arrToTest = TestDataList.GetListForGetFirstGetLastGetTest(ID);
            DoublyLinkedList<int> toTest = new DoublyLinkedList<int>(arrToTest);

            if(ID == 1)
            {
                //act
                Exception ex = Assert.Throws(typeof(IndexOutOfRangeException),
                    () => toTest.Get(idx));
                //assert
                Assert.AreEqual(expectedMessage, ex.Message);
            }
            else
            {
                //act
                Exception ex = Assert.Throws(typeof(Exception),
                    () => toTest.Get(idx));
                //assert
                Assert.AreEqual(expectedMessage, ex.Message);
            }
        }

        
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(11)]
        public void ReverseTest(int ID)
        {
            //arrange
            int[] arrToTest = TestDataList.GetListForReverseTest(ID);
            DoublyLinkedList<int> toTest = new DoublyLinkedList<int>(arrToTest);
            int[] expected = TestDataList.GetExpectedListForReverseTest(ID);
            //act
            toTest.Reverse();
            //assert
            Assert.AreEqual(expected, toTest.ToArray());
        }

        
        [TestCase(0, 12, 4)]
        [TestCase(1, 4, 2)]
        [TestCase(2, 4, 0)]
        [TestCase(3, 5, 0)]
        public void MaxAndIndexMaxTest(int ID, int expected, int expectedIndex)
        {
            //arrange
            int[] arrToTest = TestDataList.GetListForMaxMinAndThisIndexesTest(ID);
            DoublyLinkedList<int> toTest = new DoublyLinkedList<int>(arrToTest);
            //act
            int actual = toTest.Max();
            int actualIndex = toTest.IndexOfMax();
            //assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [TestCase(22, "List is empty")]
        public void MaxAndIndexMaxNegativeTest(int ID, string expectedMessage)
        {
            //arrange
            int[] arrToTest = TestDataList.GetListForMaxMinAndThisIndexesTest(ID);
            DoublyLinkedList<int> toTest = new DoublyLinkedList<int>(arrToTest);

            //act
            Exception exMax = Assert.Throws(typeof(Exception),
                () => toTest.Max());
            Exception exIndexMax = Assert.Throws(typeof(Exception),
                () => toTest.IndexOfMax());

            //assert
            Assert.AreEqual(expectedMessage, exMax.Message, exIndexMax.Message);
        }

        
        [TestCase(0, -9, 2)]
        [TestCase(1, 1, 3)]
        [TestCase(2, 4, 0)]
        [TestCase(3, 5, 0)]
        public void MinAndIndexMinTest(int ID, int expected, int expectedIndex)
        {
            //arrange
            int[] arrToTest = TestDataList.GetListForMaxMinAndThisIndexesTest(ID);
            DoublyLinkedList<int> toTest = new DoublyLinkedList<int>(arrToTest);
            //act
            int actual = toTest.Min();
            int actualIndex = toTest.IndexOfMin();
            //assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [TestCase(22, "List is empty")]
        public void MinAndIndexMinNegativeTest(int ID, string expectedMessage)
        {
            //arrange
            int[] arrToTest = TestDataList.GetListForMaxMinAndThisIndexesTest(ID);
            DoublyLinkedList<int> toTest = new DoublyLinkedList<int>(arrToTest);

            //act
            Exception exMin = Assert.Throws(typeof(Exception),
                () => toTest.Min());
            Exception exIndexMin = Assert.Throws(typeof(Exception),
                () => toTest.IndexOfMin());

            //assert
            Assert.AreEqual(expectedMessage, exMin.Message, exIndexMin.Message);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(55)]
        public void SortTest(int ID)
        {
            //arrange
            int[] arrToTest = TestDataList.GetListForSortAndSortDescTest(ID);
            DoublyLinkedList<int> toTest = new DoublyLinkedList<int>(arrToTest);
            int[] expected = TestDataList.GetExpectedListForSortTest(ID);
            //act
            toTest.Sort();
            //assert
            Assert.AreEqual(expected, toTest.ToArray());
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(55)]
        public void SortDescTest(int ID)
        {
            //arrange
            int[] arrToTest = TestDataList.GetListForSortAndSortDescTest(ID);
            DoublyLinkedList<int> toTest = new DoublyLinkedList<int>(arrToTest);
            int[] expected = TestDataList.GetExpectedListForSortDescTest(ID);
            //act
            toTest.SortDesc();
            //assert
            Assert.AreEqual(expected, toTest.ToArray());
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        public void StringSortAndSortDescTest(int ID)
        {
            //arrange
            string[] arrToTest = TestDataList.GetListForSortAndSortDescStringTest(ID);
            DoublyLinkedList<string> toTestSort = new DoublyLinkedList<string>(arrToTest);
            DoublyLinkedList<string> toTestSortDesc = new DoublyLinkedList<string>(arrToTest);
            string[] expectedSort = TestDataList.GetExpectedListForSortStringTest(ID);
            string[] expectedSortDesc = TestDataList.GetExpectedListForSortDescStringTest(ID);
            //act
            toTestSort.Sort();
            toTestSortDesc.SortDesc();
            //assert
            Assert.AreEqual(expectedSort, toTestSort.ToArray());
            Assert.AreEqual(expectedSortDesc, toTestSortDesc.ToArray());
        }
    }
}