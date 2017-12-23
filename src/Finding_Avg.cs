using System;

namespace N
{
    class Avg
    {
        public double getAvg(int[] arr)
        {
            int sum = 0;
            foreach(int i in arr)
                sum += i;
            return (double)sum / arr.Length;
        }
        static void Main(string[] arg)
        {
            Avg a = new Avg();
            int[] arr = new int[]{1, 2, 3, 7};
            Console.Write("Average: " + a.getAvg(arr));
        }
    }
}

