using DS_LinkedList;
using System;
using Xunit;

namespace DataStructureTest
{
    public class LinkedListTest
    {
        private static ILinkedList<int> _linkedList = new LinkedList<int>();

        [Fact]
        public void AppendTest()
        {
            _linkedList.Append(1);
            _linkedList.Append(2);
            _linkedList.Append(3);
            _linkedList.Append(4);
            Assert.Equal(4, _linkedList.Length);
            Assert.Equal("HEAD ==> 1 ==> 2 ==> 3 ==> 4 ==> NULL", _linkedList.ToString());

        }

        [Fact]
        public void InsertTest1()
        {
            _linkedList.Append(1);
            _linkedList.Append(2);
            _linkedList.Append(4);
            _linkedList.Append(5);
            _linkedList.Insert(3, 3);
            Assert.Equal(5, _linkedList.Length);
            Assert.Equal("HEAD ==> 1 ==> 2 ==> 3 ==> 4 ==> 5 ==> NULL", _linkedList.ToString());
        }

        [Fact]
        public void InsertTest2()
        {
            _linkedList.Append(1);
            _linkedList.Append(2);
            _linkedList.Append(3);
            _linkedList.Append(4);
            Assert.Throws<ArgumentOutOfRangeException>(() => _linkedList.Insert(6, 5));
        }

        [Fact]
        public void DeleteTest()
        {
            _linkedList.Append(1);
            _linkedList.Append(2);
            _linkedList.Append(3);
            _linkedList.Append(4);
            _linkedList.Delete(3);
            Assert.Equal(3, _linkedList.Length);
            Assert.Equal("HEAD ==> 1 ==> 2 ==> 4 ==> NULL", _linkedList.ToString());
        }

        [Fact]
        public void UpdateTest()
        {
            _linkedList.Append(1);
            _linkedList.Append(2);
            _linkedList.Append(3);
            _linkedList.Append(4);
            _linkedList.Update(2, 5);
            Assert.Equal("HEAD ==> 1 ==> 5 ==> 3 ==> 4 ==> NULL", _linkedList.ToString());
        }

        [Fact]
        public void SearchTest()
        {
            _linkedList.Append(1);
            _linkedList.Append(2);
            _linkedList.Append(3);
            _linkedList.Append(4);
            var index = _linkedList.Search(3);
            Assert.Equal(3, index);
        }

        [Fact]
        public void ClearTest()
        {
            _linkedList.Append(1);
            _linkedList.Append(2);
            _linkedList.Append(3);
            _linkedList.Append(4);
            _linkedList.Clear();
            Assert.Equal(0, _linkedList.Length);
            Assert.Null(_linkedList.Head.Next);
        }
    }
}
