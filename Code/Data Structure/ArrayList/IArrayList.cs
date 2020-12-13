using System;
using System.Collections;

namespace DS_ArrayList
{
    public interface IArrayList<T>: IDisposable, IEnumerable
    {
        int Length { get; }
        int Capacity { get; }
        T this[int index] { get; set; }
        void Append(T item);
        void Insert(int index, T item);
        void Update(T item, T newItem);
        void UpdateAt(int index, T item);
        bool Remove(T item);
        bool RemoveAt(int index);
        int IndexOf(T item);
        int IndexOf(T item, int startIndex, int endIndex);
        void Clear();
        bool IsEmpty { get; }
    }
}
