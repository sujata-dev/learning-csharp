using System;

namespace N
{
    class Strings
    {
        static void Main(string[] arg)
        {
            char[] letters = new char[]{'H', 'e', 'l', 'l','o'};
            string word = new string(letters);
            Console.WriteLine(word);
            Console.WriteLine(word.Length);

            string[] sarr = new string[]{"Hello,", "Sujata", "here"};
            string txt = String.Join(" ", sarr);
            Console.WriteLine(txt);
        }
    }
}
