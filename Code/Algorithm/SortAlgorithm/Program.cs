using System;
using System.Collections.Generic;

namespace SortAlgorithm
{
    class Program
    {
        #region Init and Help Method
        public static Program obj = new();
        /// <summary>
        /// Swap array element
        /// </summary>
        /// <param name="array">input array</param>
        /// <param name="i">index_1</param>
        /// <param name="j">index_2</param>
        private void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        /// <summary>
        /// Init array
        /// </summary>
        /// <returns>array</returns>
        private int[] InitInput(int count, int min = 0, int max = 1000)
        {
            HashSet<int> hs = new HashSet<int>(count);
            int[] array = new int[count];
            Random rd = new();
            for (int i = 0; i < array.Length; i++)
            {
                int item = rd.Next(min, max);
                if (hs.Contains(item))
                {
                    i--;
                    continue;
                }
                hs.Add(item);
            }
            hs.CopyTo(array);
            return array;
        }
        public void Heapify(int[] array, int n, int i)
        {
            if (i >= n)
            {
                return;
            }
            int c1 = i * 2 + 1;
            int c2 = i * 2 + 2;
            int max = i;
            if (c1 < n && array[c1] > array[max])
            {
                max = c1;
            }
            if (c2 < n && array[c2] > array[max])
            {
                max = c2;
            }

            if (i != max)
            {
                Swap(array, max, i);
                Heapify(array, n, max);
            }
        }
        public void BuildHeap(int[] array, int n)
        {
            int last_node = n - 1;
            int parent = (last_node - 1) / 2;
            for (int i = parent; i >= 0; i--)
            {
                Heapify(array, n, i);
            }
        }
        #endregion

        #region BubbleSort
        /// <summary>
        /// BubbleSort Time need O(n^2),Space need O(1)
        /// </summary>
        /// <param name="input"></param>
        public void BubbleSort(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length - 1 - i; j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        Swap(input, j, j + 1);
                    }
                }
            }
        }
        #endregion
        #region CocktailSort
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        public void CocktailSort(int[] input)
        {
            int left = 0;
            int right = input.Length - 1;
            while (left <= right)
            {
                for (int i = left; i < right; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        Swap(input, i, i + 1);
                    }
                }
                right--;
                for (int i = right; i > left; i--)
                {
                    if (input[i - 1] > input[i])
                    {
                        Swap(input, i, i - 1);
                    }
                }
                left++;
            }
        }

        #endregion
        #region SelectionSort
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        public void SelectionSort(int[] input)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[min] > input[j])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    Swap(input, i, min);
                }
            }
        }
        #endregion
        #region InsertSort
        /// <summary>
        /// This is Insert Sort
        /// </summary>
        /// <param name="input">input array</param>
        public void InsertSort(int[] input)
        {

            for (int i = 1; i < input.Length; i++)
            {
                int key = input[i];
                int j = i - 1;
                while (j >= 0 && input[j] > key)
                {
                    input[j + 1] = input[j];
                    j--;
                }
                input[j + 1] = key;
            }
        }
        #endregion
        #region InsertionSortDichotomy
        public void InsertionSortDichotomy(int[] input)
        {

        }
        #endregion
        #region HeapSort
        public void HeapSort(int[] array, int n)
        {
            BuildHeap(array, n);
            for (int i = n - 1; i >= 0; i--)
            {
                Swap(array, i, 0);
                Heapify(array, i, 0);
            }
        }
        #endregion

        static void Main(string[] args)
        {
            //int[] input = obj.InitInput(6, 0, 50);
            int[] temp = new int[] { 1,2,3,4,5,6,7,8,9,10,11 };
            //obj.InsertSort(input);
            // obj.HeapSort(input, input.Length);
            obj.Heapify(temp, temp.Length, 4);
            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write(temp[i]);
                Console.Write("   ");
            }
            Console.WriteLine();
            Console.WriteLine("Program Finish");
        }
    }
}
