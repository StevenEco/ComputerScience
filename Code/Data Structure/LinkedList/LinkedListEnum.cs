using System.Collections;

namespace DS_LinkedList
{
    public class LinkedListEnum<T> : IEnumerator
    {
        private LinkedNode<T> _data;
        private LinkedList<T> _list;
        public LinkedListEnum(LinkedList<T> linkedList)
        {
            _list = linkedList;
            _data = _list.Head;
        }

        public object Current => _data;

        public bool MoveNext()
        {
            _data = _data.Next;
            return _data != null;
        }

        public void Reset()
        {
            _data = _list.Head;
        }
    }
}
