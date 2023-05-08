using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20210428_Shell
{
    class RecursiveFunctions
    {
        public decimal RFact(ulong n)
        {
            checked
            {
                if (n == 0 || n == 1) return 1;
                else return n * RFact(n - 1);
            }
        }
        public decimal RFib(decimal n)
        {
            checked
            {
                if (n == 0) return 0;
                else if (n == 1) return 1;
                else
                {
                    return RFib(n - 1) + RFib(n - 2);
                }
            }
        }
        public decimal Rgcd(decimal x, decimal y)
        {
            if(x >= y)
            {
                if (x % y == 0) return y;
                else return Rgcd(y, x % y);
            }
            else
            {
                if (y % x == 0) return x;
                else return Rgcd(x, y % x);
            }
        }
        public void BubbleSort(int[] A, int first, int last)
        {
            int temp;
            if (first == last) return;
            for (int j = first; j < last; j++)
            {
                if (A[j] > A[j + 1])
                {
                    temp = A[j];
                    A[j] = A[j + 1];
                    A[j + 1] = temp;
                }
            }
            BubbleSort(A, first, last - 1);
        }
        public int BinarySearch(string[] ID, string X, int first, int last)
        {
            int midptr = (first + last) / 2;
            if (last < first) return -1;
            else if (ID[midptr] == X) return midptr;
            else if (string.Compare(X, ID[midptr]) > 0)
            {
                return BinarySearch(ID, X, midptr + 1, last);
            }
            else return BinarySearch(ID, X, first, midptr - 1);
        }

        //-----------------------------------------------------------------------------------------------

        static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static int Partition(int[] arr, int front, int end)
        {
            int pivot = arr[end];
            int i = front - 1;
            for (int j = front; j < end; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    swap(ref arr[i], ref arr[j]);
                }
            }
            i++;
            swap(ref arr[i], ref arr[end]);
            return i;
        }
        public void QuickSort(int[] arr, int front, int end)
        {
            if (front < end)
            {
                int pivot = Partition(arr, front, end);
                QuickSort(arr, front, pivot - 1);
                QuickSort(arr, pivot + 1, end);
            }
        }

    }
}
