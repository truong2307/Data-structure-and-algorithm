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

            //Console.WriteLine("\nMerge sort");
            //arr.MergSort(0, arr.Length - 1);
            //foreach (var item in arr)
            //{
            //    Console.Write(" " + item);
            //}
            //Console.WriteLine();

            //IComparable requestSearch = 52;
            //Console.WriteLine("\nSo can tim trong mang la: " +requestSearch);
            //bool searchSuccessLoop = arr.BinarySearchLoop(0, arr.Length-1, requestSearch);
            //bool searchSuccessRecursive = arr.BinarySearchRecursive(0, arr.Length - 1, requestSearch);
            //if (searchSuccessRecursive)
            //{
            //    Console.WriteLine("Found {0} in array", requestSearch);
            //}
            //else
            //{
            //    Console.WriteLine("Not Found {0} in array", requestSearch);
            //}
            
            Console.WriteLine("\nDoi sanh mau Brute Force:");

            string requestString = "ABCCBACBABCABCA";
            string wantFind = "BCA";
            int amountFound = requestString.BruteForce(wantFind);

            Console.WriteLine("String request: "+requestString);
            Console.WriteLine("Found {0} {1} in string request", amountFound, wantFind);

            Console.ReadKey();
        }
    }
}
