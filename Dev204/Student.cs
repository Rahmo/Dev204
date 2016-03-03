using System;
using System.Collections;
using System.Collections.Generic;


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

        public Stack<string> Grades = new Stack<string>();

        public string AddressLine { get; set; }
    }
}
