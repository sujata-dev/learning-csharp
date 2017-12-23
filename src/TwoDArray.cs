using System;

namespace N
{
    class TwoDArr
    {
        static void Main(string[] arg)
        {
            int[,] arr = new int[3,4]{
                {0, 1, 2, 3},
                {4, 5, 6, 7},
                {8, 9, 10, 11}
            };
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<4;j++)
                    Console.Write(arr[i,j]+" ");
                Console.WriteLine();
            }
        }
    }
}
