using System;
using System.Collections;

namespace N
{
    class Stack_Operations
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push("abc");
            st.Push("def");
            st.Push("efg");
            st.Pop();

            Console.WriteLine(st.Count);
            Console.WriteLine(st.Contains("efg"));
            Console.WriteLine(st.Peek());

            foreach(string s in st)
                Console.WriteLine(s);

            st.Clear();
        }
    }
}
