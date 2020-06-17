using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC_205_ch9_prt_2_class_exe
{
    class Student
    {
        public static int NumberOfStudents;

        ///charactteristics
        public string Name { get; set; }
        public string Major { get; set; }
        public double GPA { get; set; }

        private int age;  // this is a field
        public int GetAge()
        {
            return age;
        }

        public void SetAge(int newValue)
        {
            age = newValue;
        }

        //behavior - methods
        public void Print()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"{Name}");
            Console.WriteLine($"{Name}\t {Major} \t {GPA} \t{age}");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(NumberOfStudents);
        }
        //ctor (s)
        public Student() //default constructor is constructor with no parameters
        {
            NumberOfStudents++;
        }

              
        public Student(string Name)
        {
            this.Name = Name;
            this.Major = "N/A";
            this.age = -1;
            NumberOfStudents++;
        }

        public Student(string Name, string Major)

        {
            this.Name = Name;
            this.Major = Major;
            this.age = -1;
            NumberOfStudents++;

        }


        public Student(string Name, string Major, int Age, double GPA)
        {
            this.Name = Name;
            this.Major = Major;
            SetAge(Age); //this.age = Age;
            this.GPA = GPA;
            NumberOfStudents++;
        }
    }
}
