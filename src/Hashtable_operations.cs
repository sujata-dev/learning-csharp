using System;
using System.Collections;

namespace N
{
    class HashTable_Operations
    {
        static void Main(string[] args)
        {
            Hashtable h1 = new Hashtable();
            h1.Add("000", "abc");
            h1.Add("001", "def");
            h1.Add("002", "efg");
            h1.Remove("001");

            Console.WriteLine(h1.Count);
            Console.WriteLine(h1.ContainsKey("000"));
            Console.WriteLine(h1.ContainsValue("def"));

            ICollection key = h1.Keys;

            foreach(string i in key)
                Console.WriteLine(i + " " + h1[i]);

            h1.Clear();
        }
    }
}



