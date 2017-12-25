#define pi
#define e
using System;

namespace N
{
    class PreprocessorDirectives
    {
        static void Main(string[] arg)
        {
            #if (pi && e)
                Console.Write("pi and e are defined");
            #elif (pi && !e)
                Console.Write("only pi is defined");
            #elif (!pi && e)
                Console.Write("only e is defined");
            #else
                Console.Write("pi and e are not defined");
            #endif
        }
    }
}
