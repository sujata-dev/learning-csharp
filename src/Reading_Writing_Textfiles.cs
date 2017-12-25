using System;
using System.IO;

namespace N
{
    class Reading_Writing_Textfiles
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("a.txt"))
                {
                    sw.WriteLine("abc");
                    sw.WriteLine("def");
                }
                using (StreamReader sr = new StreamReader("a.txt"))
                {
                    string line;
                    while((line = sr.ReadLine()) != null)
                        Console.WriteLine(line);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }
}
