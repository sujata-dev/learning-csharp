using System;
using System.Linq;

class Linq
{
    static void Main()
    {
        Console.Write("Enter size: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter " + n + " elements: ");
        string[] str = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(str, Int32.Parse);
        var query = (from i in arr
                    where i < 0
                    select Math.Pow(i, 2)).Distinct().OrderBy(x => x);

        Console.Write("Powers of the -ve numbers in ascending order: ");
        foreach(int i in query)
            Console.Write(i+" ");

        Console.Write("\n" + query.Count());
    }
}
