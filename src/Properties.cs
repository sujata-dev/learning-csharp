using System;

namespace N
{
    class Student
    {
        private int id = 0;
        public string name { get; set; } = "abc"; // auto-implemented properties

        public int Prop_Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public override string ToString()
        {
            return "ID: " + Prop_Id + "\nName: " + name;
        }
    }
    class Properties
    {
        public static void Main(string[] arg)
        {
            Student s = new Student();
            s.Prop_Id = 123;
            s.name = "Ria";
            Console.WriteLine(s);
        }

    }
}
