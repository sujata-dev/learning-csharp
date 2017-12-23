using System;

namespace N
{
    class JaggedArr
    {
        static void Main(string[] arg)
        {
            int[][] arr = new int[][]{
                new int[]{0, 0},
                new int[]{1, 2},
                new int[]{2, 4},
                new int[]{3, 6},
                new int[]{4, 8}
            };

            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 2; j++)
                    Console.WriteLine("arr[{0}][{1}] = {2}", i, j, arr[i][j]);

        }
    }
}
