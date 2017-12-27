using System;
using System.Collections;

namespace N
{
    class Arraylists
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();

            a1.Add(2);
            a1.Add(3);

            Console.WriteLine("Capacity of arraylist: " + a1.Capacity);
            Console.WriteLine("No of elements: " + a1.Count);

            Console.Write("Elements: ");
            foreach (int i in a1)
                Console.Write(i + " ");

            Console.Write("\nSorted Arraylist: ");
            a1.Sort();
            foreach (int i in a1)
                Console.Write(i + " ");
        }
    }
}
