using System;

namespace N
{
    class StrMethods
    {
        static void Main(string[] arg)
        {
            string str1 = "Hi world", str2 = "hello world";

            if (str1.Equals(str2))
                Console.WriteLine("equal");

            Console.WriteLine(str1.Contains("Hi"));

            string str3 = String.Copy(str1);
            Console.WriteLine(str3);

            Console.WriteLine(str1.EndsWith("rld"));

            string str4 = String.Concat(str1, str2);

            Console.WriteLine(str1.IndexOf("h"));

            Console.WriteLine(String.IsNullOrEmpty(str4));

            Console.WriteLine(str4.Replace("rld", "abc"));


            foreach (var x in str1.Split(' '))
                Console.WriteLine(x);

            Console.WriteLine(str4.ToLower());
            Console.WriteLine(str4.Trim());

            Console.WriteLine(str2.Substring(2, 4));


        }
    }
}
