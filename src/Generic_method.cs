using System;
using System.Collections.Generic;

namespace N
{
    class Demo
    {
        void swap<T>(ref T t1, ref T t2)
        {
            T temp = t1;
            t1 = t2;
            t2 = temp;
        }
        static void Main(string[] arg)
        {
            Demo d = new Demo();
            int a = 2, b = 3;
            d.swap<int>(ref a, ref b);
            Console.WriteLine(a + " " + b);
        }
    }
}
