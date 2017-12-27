using System;
using System.Collections;

namespace N
{
    class Queue_Operations
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue("abc");
            q.Enqueue("def");
            q.Enqueue("efg");
            q.Dequeue();
            q.TrimToSize();

            Console.WriteLine(q.Count);
            Console.WriteLine(q.Contains("efg"));

            foreach(string s in q)
                Console.WriteLine(s);

            q.Clear();
        }
    }
}
