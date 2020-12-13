using System;
using System.Collections;

namespace DS_LinkedList
{
    public interface ILinkedList<T> : IDisposable, IEnumerable
    {
        LinkedNode<T> Head { get; set; }
        int Length { get; }
        bool IsEmpty { get; }
        void Append(T data);
        void Append(LinkedNode<T> node);
        void Insert(int index, T data);
        void Insert(int index, LinkedNode<T> data);
        bool Delete(int index);
        int Search(T data);
        void Update(int index, T data);
        void Clear();
    }
}
