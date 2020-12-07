using DS_ArrayList;
using System;
using Xunit;

namespace DataStructureTest
{
    public class ArrayListTest
    {
        private static IArrayList<int> _arrayList = new ArrayList<int>(5);

        [Fact]
        public void AutoIncreasing()
        {
            _arrayList.Append(1);
            _arrayList.Append(1);
            _arrayList.Append(1);
            _arrayList.Append(1);
            Assert.Equal(10, _arrayList.Capacity);
        }

        [Fact]
        public void AppendTest()
        {
            _arrayList.Append(1);
            _arrayList.Append(2);
            _arrayList.Append(3);
            Assert.Equal("1\t2\t3\t", _arrayList.ToString());
        }

        [Fact]
        public void InsertTestInFirst()
        {
            _arrayList.Append(1);
            _arrayList.Append(2);
            _arrayList.Append(3);
            _arrayList.Insert(0, 0);
            Assert.Equal("0\t1\t2\t3\t", _arrayList.ToString());
        }

        [Fact]
        public void InsertTestInLast()
        {
            _arrayList.Append(1);
            _arrayList.Append(2);
            _arrayList.Append(3);
            _arrayList.Insert(_arrayList.Length, 4);
            Assert.Equal("1\t2\t3\t4\t", _arrayList.ToString());
        }


        [Fact]
        public void DeleteTest1()
        {
            _arrayList.Append(1);
            _arrayList.Append(2);
            _arrayList.Append(3);
            _arrayList.Append(4);
            _arrayList.Append(4);
            _arrayList.Append(5);
            _arrayList.Remove(4);
            Assert.Equal("1\t2\t3\t4\t5\t", _arrayList.ToString());

        }

        [Fact]
        public void DeleteTest2()
        {
            _arrayList.Append(1);
            _arrayList.Append(2);
            _arrayList.Append(3);
            _arrayList.Append(4);
            _arrayList.Append(4);
            _arrayList.Append(5);
            _arrayList.RemoveAt(2);
            Assert.Equal("1\t2\t4\t4\t5\t", _arrayList.ToString());

        }

        [Fact]
        public void UpdateTest1()
        {
            _arrayList.Append(1);
            _arrayList.Append(2);
            _arrayList.Append(3);
            _arrayList.Append(4);
            _arrayList.Append(4);
            _arrayList.Append(5);
            _arrayList.Update(4, 5);
            Assert.Equal("1\t2\t3\t5\t4\t5\t", _arrayList.ToString());
        }

        [Fact]
        public void UpdateTest2()
        {
            _arrayList.Append(1);
            _arrayList.Append(2);
            _arrayList.Append(3);
            _arrayList.Append(4);
            _arrayList.Append(4);
            _arrayList.Append(5);
            _arrayList.UpdateAt(4, 5);
            Assert.Equal("1\t2\t3\t4\t5\t5\t", _arrayList.ToString());
        }

        [Fact]
        public void SelectTest1()
        {
            _arrayList.Append(1);
            _arrayList.Append(2);
            _arrayList.Append(3);
            _arrayList.Append(4);
            _arrayList.Append(4);
            _arrayList.Append(5);
            var index = _arrayList.IndexOf(4);
            Assert.Equal(3, index);
        }

        [Fact]
        public void SelectTest2()
        {
            _arrayList.Append(1);
            _arrayList.Append(2);
            _arrayList.Append(3);
            _arrayList.Append(4);
            _arrayList.Append(4);
            _arrayList.Append(5);
            var index = _arrayList.IndexOf(4,4, 5);
            Assert.Equal(4, index);
        }

        [Fact]
        public void ClearTest()
        {
            _arrayList.Append(1);
            _arrayList.Append(2);
            _arrayList.Append(3);
            _arrayList.Append(4);
            _arrayList.Append(4);
            _arrayList.Append(5);
            _arrayList.Clear();
            Assert.Equal(0, _arrayList.Length);
            Assert.Equal(5, _arrayList.Capacity);
        }

        [Fact]
        public void IndexTest()
        {
            _arrayList.Append(1);
            _arrayList.Append(2);
            _arrayList.Append(3);
            _arrayList.Append(4);
            _arrayList.Append(4);
            _arrayList.Append(5);
            Assert.Equal(5, _arrayList[_arrayList.Length-1]);
        }

        [Fact]
        public void LengthTest()
        {
            _arrayList.Append(1);
            _arrayList.Append(2);
            _arrayList.Append(3);
            _arrayList.Append(4);
            _arrayList.Append(4);
            _arrayList.Append(5);
            Assert.Equal(6, _arrayList.Length);
        }
    }
}
