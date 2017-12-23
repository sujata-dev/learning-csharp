using System;

namespace N
{
    class ArrMethods
    {
        static void Main(string[] arg)
        {
            int[] arr = new int[]{4, 3, 1};
            int[] arr1 = new int[]{5, 6, 7};
            Array.Clear(arr1, 0, arr.Length);
            Array.Copy(arr, arr1, arr.Length);
            Console.WriteLine("Index of element 3: " + Array.IndexOf(arr, 3));
            Array.Reverse(arr);
            Array.Sort(arr);
            arr1.SetValue(2, 0);
            Console.WriteLine("arr1[0] = " + arr1[0]);
        }
    }
}
