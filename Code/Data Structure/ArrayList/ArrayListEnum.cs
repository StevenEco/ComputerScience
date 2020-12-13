using System.Collections;

namespace DS_ArrayList
{
    public class ArrayListEnum<T> : IEnumerator
    {
        private int _index = -1;
        private ArrayList<T> _data;
        public ArrayListEnum(ArrayList<T> arrayList)
        {
            _data = arrayList;
        }

        public object Current => _data[_index];

        public bool MoveNext()
        {
            _index++;
            return _index < _data.Length;
        }

        public void Reset()
        {
            _index = -1;
        }
    }
}
