using System;

namespace N
{
    class ParamArr
    {
        public double getSum(params int[] arr)
        {
            int sum = 0;
            foreach(int i in arr)
                sum += i;
            return sum;
        }
        static void Main(string[] arg)
        {
            ParamArr p = new ParamArr();
            Console.WriteLine("Sum: " + p.getSum(2, 3, 4));
            Console.WriteLine("Sum: " + p.getSum(51, 72, 25, 567, 88));
        }
    }
}
