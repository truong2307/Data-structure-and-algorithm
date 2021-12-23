using System;

namespace manageCarr.ExtensionMethods
{
    public static class ExtensionMethodSearch
    {
        //Binary Search need array be sorted
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

        public static bool LinearSearch<T>(this T[] array, int requestSearch) where T: IComparable
        {
            int lengthArray = array.Length;
            int result = 0;
            while (result < lengthArray && array[result].CompareTo(requestSearch) != 0)
            {
                result++;
            }
            if (result == lengthArray)
            {
                return false;
            }

            return true;
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

        //Brute Force 
        public static int BruteForce(this string stringInput, string stringFind)
        {
            int stringInputLength = stringInput.Length;
            int stringFindLength = stringFind.Length;
            int count = 0;
            int j;
            //(stringInputLength - stringFindLength) to avoid out range 
            for (int i = 0; i <= (stringInputLength - stringFindLength); i++)
            {
                for (j = 0; j < stringFindLength && stringFind[j] == stringInput[i + j]; j++) ;
                if (j >= stringFindLength)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
