using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manageCarr.ExtensionMethods
{
    public static class ExtensionMethodSearch
    {
        /// <summary>
        /// Binary Search
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <param name="requestSearch"></param>
        /// <returns></returns>
        public static bool BinarySearch<T>(this T[] array
            , int left, int right, T requestSearch) where T : IComparable
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



    }
}
