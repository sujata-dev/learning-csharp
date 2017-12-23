using System;

namespace N
{
    class Null
    {
        static void Main(string[] arg)
        {
            int ?a = null;
            int ?b = 45;
            double ?c = new double?();
            int ?d = a ?? b;
            int e = a ?? -1;
            Console.WriteLine(a+" "+b+" "+c+" "+d+" "+e);
        }
    }
}
