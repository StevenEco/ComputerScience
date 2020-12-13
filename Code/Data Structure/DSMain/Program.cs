using DS_LinkedList;
using System;

namespace DSMain
{
    class Program
    {
        static void Main(string[] args)
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.Append(1);
            list.Append(2);
            Console.WriteLine(list);
        }
    }
}
