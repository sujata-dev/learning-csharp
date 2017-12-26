using System;

namespace N
{
    class Delegate
    {
        static int num = 10;
        delegate void Ans(int p);
        public static void add(int p)
        {
            Console.WriteLine(num + p);
        }
        public static void mul(int p)
        {
            Console.WriteLine(num * p);
        }
        static void Main(string[] arg)
        {
            Ans a1 = new Ans(Delegate.add), a2 = new Ans(Delegate.mul), a3;
            a1(2);
            a2(3);
            a3 = a1 + a2;
            a3(4);
        }
    }
}
