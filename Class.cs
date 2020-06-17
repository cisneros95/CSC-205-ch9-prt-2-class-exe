using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace CSC_205_ch9_prt_2_class_exe
{
    class Program
    {

        public static void MyMethod()

        { 
        
        
        
        }           

        static void Main(string[] args)

        {
             MyMethod();

              

            ///////////////////////////////////////////////////////
            ///Student 1
            //////////////////////////////////////////////////////
            Student st1 = new Student();  // new Student is the constructor
            st1.Name = "Monty Python";
            st1.Major = "Basket weaving";
            //st1.GetAge = 56;
            st1.SetAge(56);
            st1.GPA = 4.0;
            st1.Print();
            //st1.NumberOfStudents = 10;
            //Student.NumberOfStudents = 10;
                      
            //////////////////////////////////////////////////
            ///// studen 3
            //////////////////////////////////////////////////

            Student st3 = new Student("Bob");
            st3.Print();

            //////////////////////////////////////////////////
            ///Studtent 4
            //////////////////////////////////////////////////
            Student st4 = new Student("Jerry","Comedy");
            st4.Print();

            //////////////////////////////////////////////////////
            ///Student 5
            /////////////////////////////////////////////////////
            Student st5 = new Student("Sally", "History", 20, 3.0);
            st5.GPA = 3.5;
            st5.Print();

            Console.WriteLine($"number of students created so far: {Student.NumberOfStudents}");

            //////////////////////////////////////////////////////
            ///Student 2 Create a new studen using user input
            //////////////////////////////////////////////////////
            Student st2 = new Student();

            Console.WriteLine("please enter a name: ");
            st2.Name = Console.ReadLine();

            Console.WriteLine("Please enter a major for {0}: ", st2.Name);
            st2.Major = Console.ReadLine();

            Console.WriteLine("Please enter an age for {0}: ", st2.Name);
            st2.SetAge(int.Parse(Console.ReadLine() ) );


            Console.WriteLine("Please enter an age for {0}: ", st2.Name);
            st2.GPA = double.Parse(Console.ReadLine() );
            st2.Print();


        }
    }   
}
