using System;
using System.Collections;

namespace N
{
    class SortedList_Operations
    {
        static void Main(string[] args)
        {
            SortedList s1 = new SortedList();
            s1.Add("000", "abc");
            s1.Add("001", "def");
            s1.Add("002", "efg");
            s1.Remove("001");
            s1.TrimToSize();

            IList list = s1.GetKeyList();
            foreach(string i in list)
                Console.Write(i + " ");

            Console.WriteLine();
            Console.WriteLine(s1.Capacity);
            Console.WriteLine(s1.Count);
            Console.WriteLine(s1.ContainsKey("000"));
            Console.WriteLine(s1.ContainsValue("def"));
            Console.WriteLine(s1.GetByIndex(1));
            Console.WriteLine(s1.IndexOfKey("001"));

            ICollection key = s1.Keys;
            foreach(string i in key)
                Console.WriteLine(i + " " + s1[i]);

            s1.Clear();
        }
    }
}



