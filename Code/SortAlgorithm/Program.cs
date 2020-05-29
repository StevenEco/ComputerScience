using System;

namespace SortAlgorithm
{
    public static class ArrayExtension
    {
        # region Common Utils
        # endregion

        # region HeapSort
        private static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        private static void Heapify(int[] array, int i, int n = -1)
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
                Heapify(array, maxIndex, n);
            }
        }

        /// <summary>
        /// 小根堆
        /// </summary>
        /// <param name="array"></param>
        public static void BuildHeap(this int[] array)
        {
            int last = array.Length - 1;
            int parent = (array.Length - 2) / 2;
            for (int i = parent; i >= 0; i--)
            {
                Heapify(array, i);
            }
        }

        public static void HeapSort(this int[] array, int n = -1)
        {
            if (n == -1)
            {
                n = array.Length - 1;
            }
            else
            {
                n = array.Length - n - 1;
            }
            BuildHeap(array);
            for (int i = n; i >= 0; i--)
            {
                Swap(array, i, 0);
                Heapify(array, 0, i);
            }
        }
        # endregion

    }


    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 5, 1, 6, 2, 8, 4, 13, 7, 16, 0 };
            array.BuildHeap();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                Console.Write("\t");
            }
            Console.WriteLine();
            array = new int[] { 3, 5, 1, 3, 2, 8, 4, 13, 7, 16, 0 };
            array.HeapSort(5);
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                Console.Write("\t");
            }
        }
    }
}
