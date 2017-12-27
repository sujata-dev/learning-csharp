using System;
using System.Collections;

namespace N
{
    class Arraylist_Operations
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();

            a1.Add(2);
            a1.Add(3);

            Console.WriteLine(a1.Capacity);
            Console.WriteLine(a1.Count);

            a1.Insert(1, 0);
            a1.Remove(2);
            a1.TrimToSize();
            a1.Sort();
            foreach (int i in a1)
                Console.Write(i + " ");

            a1.Clear();
        }
    }
}
