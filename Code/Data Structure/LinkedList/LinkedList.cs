using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DS_LinkedList
{
    public class LinkedList<T> : ILinkedList<T>
    {
        private LinkedNode<T> _head;
        private int _length = 0;

        public LinkedNode<T> Head { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Length => throw new NotImplementedException();

        public bool IsEmpty => throw new NotImplementedException();

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Delete(int index)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T data)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, LinkedNode<T> data)
        {
            throw new NotImplementedException();
        }

        public void Search(T data)
        {
            throw new NotImplementedException();
        }

        public void Update(int index, T data)
        {
            throw new NotImplementedException();
        }
    }
}
