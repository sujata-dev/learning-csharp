using System;

namespace N
{
    class Swap
    {
        public void doSwap(ref int a, ref int b)
        {
            int x = a;
            a = b;
            b = x;
        }
        static void Main(string[] arg)
        {
            int a = 2, b = 3;
            Swap s = new Swap();
            s.doSwap(ref a, ref b);
            Console.WriteLine("a = " + a + "\nb = " + b);
        }
    }
}
