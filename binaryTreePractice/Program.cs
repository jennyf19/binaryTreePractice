using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binaryTreePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] treeArray = { 5, 9, -12, 8, 4, -2, 6 };
            int lo = 0;
            int hi = 6;

            PrintTreeArray(treeArray, lo, hi);

            QuickSort(treeArray, lo, hi);

            PrintTreeArray(treeArray, lo, hi);

            Console.ReadLine();
        }
        static void QuickSort(int[] treeArray, int lo, int hi)
        {
            if (lo < hi)
            {
                int p = Partition(treeArray, lo, hi);
                QuickSort(treeArray, lo, p - 1);
                QuickSort(treeArray, p + 1, hi);
            }
        }

        static int Partition(int[] treeArray, int lo, int hi)
        {
            int pivot = treeArray[hi];
            int i = lo;
            for (int j = lo; j < hi - 1; j++)
            {
                if (treeArray[j] <= pivot)
                {
                    int temp = treeArray[i];
                    treeArray[i] = treeArray[j];
                    treeArray[j] = temp;
                    i = i + 1;
                }
            }
            int temp2 = treeArray[i];
            treeArray[i] = treeArray[hi];
            treeArray[hi] = temp2;
            return i;
        }

        static void PrintTreeArray(int[] treeArray, int lo, int hi)
        {
            for (int i = 0; i <= hi; i++)
            {
                Console.WriteLine(treeArray[i]);
            }
            Console.WriteLine();
        }
    }
}
