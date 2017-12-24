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
            Console.WriteLine("h = " + h + "\nw = " + w);
        }
    }

    public interface PaintCost
    {
        void getCost(int cost);
    }

    class Rect: Shape, PaintCost
    {
        int cost;
        public Rect(int h, int w): base(h, w) {}
        public void getCost(int cost)
        {
            this.cost = cost;
        }
        public int area()
        {
            base.disp();
            return h * w;
        }
        public int costcalc()
        {
            return area() * cost;
        }
    }

    class Demo
    {
        static void Main(string[] arg)
        {
            Rect r = new Rect(2, 3);
            r.getCost(5);
            Console.Write("Cost: " + r.costcalc());
        }
    }
}
