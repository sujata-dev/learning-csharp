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

        public static bool operator == (Box x, Box y)
        {
            if(x.l == y.l && x.b == y.b && x.h == y.h)
                return true;
            return false;
        }
        public static bool operator != (Box x, Box y)
        {
            if(x.l != y.l || x.b != y.b || x.h != y.h)
                return true;
            return false;
        }
        public override string ToString()
        {
            return "l = " + l + " b = " + b + " h = " + h;
        }
    }
    class Demo
    {
        static void Main(string[] arg)
        {
            Box b1 = new Box(), b2 = new Box(), b3 = new Box();
            b1.getVal(2, 3, 4);
            b2.getVal(5, 6, 7);
            if(b1 == b2)
                Console.WriteLine("Equal");

            b3 = b1 + b2;
            Console.WriteLine(b1.ToString());
            Console.WriteLine("Volume1: " + b1.vol());
            Console.WriteLine(b2.ToString());
            Console.WriteLine("Volume2: " + b2.vol());
            Console.WriteLine(b3.ToString());
            Console.WriteLine("Volume3: " + b3.vol());
        }
    }


}
