using System;

namespace SortAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 5, 1, 6, 2, 8, 4, 13, 7, 16, 0 };
            Program p = new Program();
            p.BuildHeap(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                Console.Write("\t");
            }
            Console.WriteLine();
            array = new int[] { 3, 5, 1, 6, 2, 8, 4, 13, 7, 16, 0 };
            p.HeapSort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                Console.Write("\t");
            }
        }
        private void HeapAdjust(int[] array, int i, int n = -1)
        {
            if (n == -1)
            {
                n = array.Length;
            }
            int lChild = 2 * i;
            int rChild = 2 * i + 1;
            int maxIndex = i;
            if (lChild < n && array[lChild] > array[maxIndex])
            {
                maxIndex = lChild;
            }
            if (rChild < n && array[rChild] > array[maxIndex])
            {
                maxIndex = rChild;
            }
            if (maxIndex != i)
            {
                Swap(array, i, maxIndex);
                HeapAdjust(array, maxIndex, n);
            }
        }
        private void BuildHeap(int[] array)
        {
            int last = array.Length - 1;
            int parent = (array.Length - 2) / 2;
            for (int i = parent; i >= 0; i--)
            {
                HeapAdjust(array, i);
            }
        }
        private void HeapSort(int[] array)
        {
            BuildHeap(array);
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Swap(array, i, 0);
                HeapAdjust(array, 0, i);
            }
        }

        private void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
