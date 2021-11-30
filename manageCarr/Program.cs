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

            Console.ReadKey();
        }
    }
}
