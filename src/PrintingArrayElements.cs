using System;

namespace N
{
    class Arr
    {
        static void Main(string[] arg)
        {
            int i = 0;
            int[] arr = new int[] {99, 98, 92, 97, 95};
            int[] arr1 = arr;
            foreach (int x in arr1)
                Console.WriteLine("Element[{0}] = {1}", i++, x);
        }
    }
}
