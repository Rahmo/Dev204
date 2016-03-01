using System;
using System.Collections;


namespace Dev204
{
    public class Student : Person
    {
        public static int NoOfStudentsEnrolled;

        public Student()
        {
          
            NoOfStudentsEnrolled++;
        }

        public void TakeTest()
        {
            Console.WriteLine("Test 's been taken ");
        }

       public Stack Grades = new Stack();

        public string AddressLine { get; set; }
    }
}
