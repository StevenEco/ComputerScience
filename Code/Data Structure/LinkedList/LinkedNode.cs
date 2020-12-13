using System;
using System.Collections.Generic;
using System.Text;

namespace DS_LinkedList
{
    public class LinkedNode<T> : IDisposable
    {
        public T Data { get; set; }
        public LinkedNode<T> Next { get; set; }
        public LinkedNode()
        {
            Data = default;
            Next = null;
        }
        public LinkedNode(T data)
        {
            Data = data;
        }
        ~LinkedNode()
        {

        }
        public void Dispose()
        {
            Data = default;
            Next = null;
            GC.SuppressFinalize(this);
        }
    }
}
