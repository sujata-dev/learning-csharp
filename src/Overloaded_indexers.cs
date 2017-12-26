using System;

namespace N
{
    class Indexers
    {
        static public int size = 5;
        private string[] list = new string[size];

        public string this[int x]
        {
            get
            {
                return list[x];
            }
            set
            {
                list[x] = value;
            }
        }

        public int this[string val]
        {
            get
            {
                int x = 0;
                while(x < size)
                {
                    if(list[x] == val)
                        return x;
                    x++;
                }
                return x;
            }

        }

        static void Main(string[] args)
        {
            Indexers index = new Indexers();
            index[0] = "abc";
            index[1] = "efg";
            index[2] = "ghi";

            for (int i = 0; i < Indexers.size; i++)
                Console.WriteLine(index[i]);

            Console.WriteLine(index["efg"]);
        }
    }
}
