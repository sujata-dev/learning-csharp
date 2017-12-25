using System;

namespace N
{
    public class TempException: Exception
    {
        public TempException(string msg): base(msg){}
    }
    class Temp
    {
        private int temp;
        public Temp()
        {
            temp = 0;
        }
        static void Main(string[] arg)
        {
            try
            {
                Temp t = new Temp();
                if(t.temp == 0)
                    throw new TempException("This is TempException");
            }
            catch(TempException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Bye");
            }
        }
    }
}

