using System;

namespace size
{
    class abc
    {
        static void Main(string[] arg)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(nameof(abc));
            Console.WriteLine(typeof(System.IO.StreamReader));
            Console.WriteLine(typeof(abc).Name);
            Console.WriteLine(sizeof(uint));
        }
    }
}
