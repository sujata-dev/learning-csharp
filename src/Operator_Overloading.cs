using System;

namespace N
{
    class Box
    {
        private int l, b, h;
        public void getVal(int l, int b, int h)
        {
            this.l = l;
            this.b = b;
            this.h = h;
        }
        public int vol()
        {
            return l * b * h;
        }
        public static Box operator + (Box x, Box y)
        {
            Box z = new Box();
            z.l = x.l + y.l;
            z.b = x.b + y.b;
            z.h = x.h + y.h;
            return z;
        }
    }
    class Demo
    {
        static void Main(string[] arg)
        {
            Box b1 = new Box(), b2 = new Box(), b3 = new Box();
            b1.getVal(2, 3, 4);
            b2.getVal(5, 6, 7);
            b3 = b1 + b2;
            Console.WriteLine("Volume1: " + b1.vol());
            Console.WriteLine("Volume2: " + b2.vol());
            Console.WriteLine("Volume3: " + b3.vol());
        }
    }


}
