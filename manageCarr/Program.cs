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

            ExtensionMethod.Quick_Sort(arr, 0, arr.Length - 1);

            foreach (var item in arr)   
            {
                Console.WriteLine(" "+ item);
            }

            Console.ReadKey();
        }
    }
}
