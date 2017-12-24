using System;

namespace N
{
    struct Student
    {
        private int id;
        private string name;
        private double marks;

        public void getValue(int id, string name, double marks)
        {
            this.id = id;
            this.name = name;
            this.marks = marks;
        }

        public void display()
        {
            Console.WriteLine(this.id+" "+this.name+" "+this.marks);
        }
    };

    class StructDemo
    {
        static void Main(string[] arg)
        {
            Student s = new Student();
            s.getValue(123, "abc", 23.4);
            s.display();

        }
    }
}
