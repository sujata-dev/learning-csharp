using System;

namespace N
{
    abstract class Shape
    {
        public virtual double area()
        {
            return 0;
        }
    }

    class Circle: Shape
    {
        private const double pi = 3.14;
        private int rad;
        public Circle(int rad)
        {
            this.rad = rad;
        }
        public override double area()
        {
            return pi * Math.Pow(rad, 2);
        }
    }
    class Override
    {
        static void Main(string[] arg)
        {
            Circle c = new Circle(4);
            Console.WriteLine(c.area());
        }
    }
}
