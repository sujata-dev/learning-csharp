using System;

namespace A
{
    class X
    {
        public void func()
        {
            Console.WriteLine("Namespace A");
        }
    }
}

namespace B
{
    class X
    {
        public void func()
        {
            Console.WriteLine("Namespace B");
        }
    }
}

class TestClass
{
    static void Main(string[] args)
    {
        A.X ax = new A.X();
        B.X bx = new B.X();
        ax.func();
        bx.func();
    }
}
