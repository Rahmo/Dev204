using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        public string AddressLine { get; set; }
    }
}
