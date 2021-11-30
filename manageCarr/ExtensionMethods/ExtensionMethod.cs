using System;
using System.Collections;
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

        //Sort Icompare theo quicksort
        public static void QuickSort<T>(this T[] arr, int left, int right) where T : IComparable
        {
            if (left < right)
            {

                int pivot = Partition(arr, left, right);

                //quick sort mảng nhỏ hơn pivot
                if (pivot > 1)
                {
                    QuickSort<T>(arr, left, pivot - 1);
                }

                // quick sort mảng lớn hơn pivot
                if (pivot + 1 < right)
                {
                    QuickSort<T>(arr, pivot + 1, right);
                }
            }
        }

        /// <summary>
        /// Bubble sort
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        public static void BubbleSort<T>(this T[] arr) where T: IComparable
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i].CompareTo(arr[j]) > 0)
                    {
                        T temp = arr[i];
                        arr[j] = arr[i];
                        arr[j] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Selection sort
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        public static void SelectionSort<T>(this T[] arr) where T: IComparable
        {
            int minIndex=0;
            for (int i = 0; i < arr.Length-1; i++)
            {
                minIndex = i;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[minIndex].CompareTo(arr[j]) > 0)
                    {
                        minIndex = j;
                    }
                }
                T temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
        }
    }
}