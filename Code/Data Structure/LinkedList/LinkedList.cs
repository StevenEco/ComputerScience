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

        public LinkedNode<T> Head { get => _head; set => _head = value; }

        public int Length => _length;

        public bool IsEmpty => _head.Next == null;
        public LinkedList()
        {
            _head = new LinkedNode<T>();
        }

        public void Append(T data)
        {
            throw new NotImplementedException();
        }

        public void Append(LinkedNode<T> node)
        {
            throw new NotImplementedException();
        }
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
            return new LinkedListEnum<T>(this);
        }

        public void Insert(int index, T data)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, LinkedNode<T> data)
        {
            throw new NotImplementedException();
        }

        public int Search(T data)
        {
            throw new NotImplementedException();
        }

        public void Update(int index, T data)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(_length + 20);
            sb.Append("HEAD ==> ");
            foreach (var item in this)
            {
                sb.Append(((LinkedNode<T>)item).Data + " ==> ");
            }
            sb.Append("NULL");
            return sb.ToString();
        }
    }
}
