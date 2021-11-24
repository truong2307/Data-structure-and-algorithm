using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace manageCarr.ExtensionMethods
{
    public static class ExtensionMethod
    {
        // func để chia thành 2 mảng, 1 mảng lớn và 1 mảng nhỏ hơn pivot
        private static int Partition<T>(T[] arr, int left, int right) where T : IComparable
        {
            IComparable pivot = arr[left];
            while (true)
            {
                // if arr[left] < pivot
                while (arr[left].CompareTo(pivot) < 0)
                {
                    left++;
                }
                // if arr[right] > pivot
                while (arr[right].CompareTo(pivot) > 0)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left].CompareTo(arr[right]) == 0) return right;

                    T temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

        public static void Quick_Sort<T>(T[] arr, int left, int right) where T : IComparable
        {
            if (left < right)
            {

                int pivot = Partition(arr, left, right);

                //quick sort mảng nhỏ hơn pivot
                if (pivot > 1)
                {
                    Quick_Sort<T>(arr, left, pivot - 1);
                }

                // quick sort mảng lớn hơn pivot
                if (pivot + 1 < right)
                {
                    Quick_Sort<T>(arr, pivot + 1, right);
                }
            }
        }

    }
}