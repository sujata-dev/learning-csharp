using System;

namespace N
{
    class Student
    {
        private int id = 0;
        private string name = "abc";

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
        public string Prop_Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override string ToString()
        {
            return "ID: " + Prop_Id + "\nName: " + Prop_Name;
        }
    }
    class Properties
    {
        public static void Main(string[] arg)
        {
            Student s = new Student();
            s.Prop_Id = 123;
            s.Prop_Name = "Ria";
            Console.WriteLine(s);
        }

    }
}
