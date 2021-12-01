using System;
using System.Text;
using manageCarr.ExtensionMethods;

namespace manageCarr
{
    class Program
    {
        
        static void Main(string[] args)
        {
            IComparable[] arr =  { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };

            //Console.WriteLine("Quick sort");
            //arr.QuickSort(0, arr.Length - 1);
            //foreach (var item in arr)   
            //{
            //    Console.Write(" "+ item);
            //}

            //Console.WriteLine("\nBubble sort");
            //arr.BubbleSort();
            //foreach (var item in arr)
            //{
            //    Console.Write(" " + item);
            //}

            //Console.WriteLine("\nSelection sort");
            //arr.SelectionSort();
            //foreach (var item in arr)
            //{
            //    Console.Write(" " + item);
            //}

            Console.WriteLine("\nMerge sort");
            arr.MergSort(0, arr.Length - 1);
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            IComparable requestSearch = 99;
            Console.WriteLine("\nSo can tim trong mang là: "+requestSearch);
            Console.WriteLine();
            bool searchSuccess = arr.BinarySearch(0, arr.Length-1, requestSearch);

            if (searchSuccess)
            {
                Console.WriteLine("Found {0} in array", requestSearch);
            }
            else
            {
                Console.WriteLine("Not Found {0} in array", requestSearch);
            }

            Console.ReadKey();
        }
    }
}
