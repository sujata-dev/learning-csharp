using System;

namespace N
{

    class Enum
    {
        enum Mon {Jan, Feb, Mar = 5, Apr};

        static void Main(string[] args)
        {
            Console.WriteLine((int)Mon.Jan);
            Console.WriteLine((int)Mon.Apr);
        }
    }
}
