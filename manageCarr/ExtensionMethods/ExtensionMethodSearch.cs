using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manageCarr.ExtensionMethods
{
    public static class ExtensionMethodSearch
    {
        //Binary with loop
        /// <summary>
        /// Binary Search need array sorted
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <param name="requestSearch"></param>
        /// <returns></returns>
        public static bool BinarySearchLoop<T>(this T[] array, int left, int right, T requestSearch) where T : IComparable

        {
            while (left <= right)
            {
                // get index mid of array
                int middle = left + (right - left) / 2;
                // value at indexMiddle == request search return true
                if (array[middle].CompareTo(requestSearch) == 0)
                {
                    return true;
                }
                //value at indexMiddle < requestSearch then maybe requestSearch in array right
                if (array[middle].CompareTo(requestSearch) < 0)
                {
                    left = middle + 1;
                }
                //value at indexMiddle > requestSearch then maybe requestSearch in array left
                if (array[middle].CompareTo(requestSearch) > 0)
                {
                    right = middle - 1;
                }
            }

            return false;
        }

        //Binary search with recursive
        public static bool BinarySearchRecursive<T>(this T[] array, int left, int right, T requestSearch) where T : IComparable
        {
            while (left <= right)
            {
                int middle = left + (right - left) / 2;
                if (array[middle].CompareTo(requestSearch) == 0)
                {
                    return true;
                }
                if (array[middle].CompareTo(requestSearch) > 0)
                {
                    return BinarySearchRecursive(array, left, middle - 1, requestSearch);
                }
                if (array[middle].CompareTo(requestSearch) < 0)
                {
                    return BinarySearchRecursive(array, middle + 1, right, requestSearch);
                }
            }

            return false;
        }
    }
}
