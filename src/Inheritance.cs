using System;

namespace N
{
    class Shape
    {
        protected int h, w;
        public Shape(int h, int w)
        {
            this.h = h;
            this.w = w;
        }
        public void disp()
        {
            Console.Write(h + " x " + w + " = ");
        }
    }
    class Rect: Shape
    {
        public Rect(int h, int w): base(h, w) {}
        public int area()
        {
            base.disp();
            return h * w;
        }
    }

    class Demo
    {
        static void Main(string[] arg)
        {
            Rect r = new Rect(2, 3);
            Console.Write(r.area());
        }
    }
}
