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
            T pivot = arr[left];
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
                        arr[i] = arr[j];
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

        /// <summary>
        /// Merge sort
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <param name="left"></param>
        /// <param name="middle"></param>
        /// <param name="right"></param>
        private static void Merge<T>(T[] arr, int left, int middle, int right) where T : IComparable
        {
            int indexLeft, indexRight, indexResult = left;
            // lenght of array left
            int lenghtLeft = middle - left + 1;
            // lenght of array right
            int lenghtRight = right - middle;
            // create array contain value left
            T[] leftArray = new T[lenghtLeft];
            // create array contain value right
            T[] rightArray = new T[lenghtRight];

            //import value by indexleft to array left from arr
            for (indexLeft = 0; indexLeft < lenghtLeft; indexLeft++)
            {
                leftArray[indexLeft] = arr[left + indexLeft];
            }
            //import value by indexright to array right from arr
            for (indexRight = 0; indexRight < lenghtRight; indexRight++)
            {
                rightArray[indexRight] = arr[middle + indexRight + 1];
            }

            // compare value at indexleft and indexright 
            indexLeft = 0; indexRight = 0;
            while (indexLeft < lenghtLeft && indexRight < lenghtRight)
            {
                //if value at indexleft <= value at indexright 
                if (leftArray[indexLeft].CompareTo(rightArray[indexRight]) <= 0)
                {
                    arr[indexResult] = leftArray[indexLeft];
                    indexLeft++;
                }
                else
                {
                    arr[indexResult] = rightArray[indexRight];
                    indexRight++;
                }
                indexResult++;
            }
            //if in arrayright has not value then add value from arrayleft to arr by indexresult
            while (indexLeft < lenghtLeft)
            {
                arr[indexResult] = leftArray[indexLeft];
                indexResult++;
                indexLeft++;
            }
            //if in arrayleft has not value then add value from arrayright to arr by indexresult
            while (indexRight < lenghtRight)
            {
                arr[indexResult] = rightArray[indexRight];
                indexResult++;
                indexRight++;
            }
        }

        //divide arr until it has 1 value
        public static void MergSort<T>(this T[] arr, int left, int right) where T : IComparable
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;
                MergSort(arr, left, middle);
                MergSort(arr, middle + 1, right);
                Merge(arr, left, middle, right);
            }
        }
    }   
}