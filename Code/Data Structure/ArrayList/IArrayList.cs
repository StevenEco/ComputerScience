using System.Collections;
using System.Collections.Generic;

namespace ArrayList
{
    public interface IArrayList<T> : IEnumerable
    {
        int Length { get; }
        T this[int index] { get; set; }
        void Append(T item);
        void Insert(int index, T item);
        void Update(T item, T newItem);
        void Update(int index, T item);
        bool Remove(T item);
        bool RemoveAt(int index);
        int IndexOf(T item);
        int IndexOf(T item, int startIndex, int endIndex);
        void Clear();
        bool IsEmpty { get; }
    }
}
