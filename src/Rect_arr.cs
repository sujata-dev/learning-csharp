using System;

namespace Rec
{
    class X
    {
        double l=2,b=3;
        public double ar()
        {
            return l*b;
        }
        public void disp()
        {
            Console.WriteLine("{0} x {1} = {2}",l,b,ar());
        }
    }
    class Y
    {
        static void Main(string[] arg)
        {
            X x=new X();
            x.disp();
        }
    }
}
