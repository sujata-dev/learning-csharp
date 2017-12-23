using System;

namespace N
{
    class Out
    {
        public void getVal(out int a, out int b)
        {
            a = 5;
            b = 10;
        }
        static void Main(string[] arg)
        {
            int a = 2, b = 3;
            Out o = new Out();
            o.getVal(out a, out b);
            Console.WriteLine("a = " + a + "\nb = " + b);
        }
    }
}
