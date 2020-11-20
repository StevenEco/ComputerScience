using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ArrayList
{
    public class ArrayList<T> : IDisposable, IArrayList<T>
    {
        private const double LAMBDA = 0.75;
        private T[] _data;
        private int _capacity;
        private int _length;

        public ArrayList()
        {
            _data = new T[10];
            _capacity = 10;
            _length = 0;
        }

        public ArrayList(int size)
        {
            _data = new T[size];
            _capacity = size;
            _length = 0;
        }

        public T this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Length => throw new NotImplementedException();

        public bool IsEmpty => throw new NotImplementedException();

        public void Append(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item, int startIndex, int endIndex)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public bool RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public void Update(T item, T newItem)
        {
            throw new NotImplementedException();
        }

        public void Update(int index, T item)
        {
            throw new NotImplementedException();
        }

    }
}
