using System;
using System.Text.RegularExpressions;

namespace N
{
    class RegEx
    {
        static void Main(string[] args)
        {
            string str = "make maze and manage to measure it";
            Console.WriteLine("Words that start with 'm' and ends with 'e': ");
            MatchCollection mc = Regex.Matches(str, @"\bm\w*e\b");
            foreach(Match m in mc)
                Console.WriteLine(m);
        }
    }
}

