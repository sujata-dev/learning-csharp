using System;

namespace N1
{
    class Max
    {
        public int findMax(int a, int b)
        {
            return a > b ? a : b;
        }
        static void Main(string[] arg)
        {
            Console.WriteLine("Enter 2 numbers: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Max m = new Max();
            Console.WriteLine("Max No: " + m.findMax(a, b));
        }
    }
}
